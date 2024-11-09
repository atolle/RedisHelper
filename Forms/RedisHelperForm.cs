using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RedisHelper
{
    public partial class RedisHelperForm : Form
    {
        private static readonly string cachePartitionKey = ConfigurationManager.AppSettings["cachePartitionKey"] ?? "";
        private static readonly string cacheKeyDelimiter = ConfigurationManager.AppSettings["cacheKeyDelimiter"] ?? "";
        private RedisService redisService;

        public RedisHelperForm()
        {
            InitializeComponent();

            try
            {
                redisService = new RedisService();

                if (!string.IsNullOrEmpty(cachePartitionKey))
                {
                    cachePartitionKeyValueLabel.Text = cachePartitionKey;
                }

                if (!string.IsNullOrEmpty(cacheKeyDelimiter))
                {
                    cacheKeyDelimiterValueLabel.Text = cacheKeyDelimiter;
                }
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private string getPrefix(string key)
        {
            if (!string.IsNullOrEmpty(getCachePartitionKey()))
            {
                var cachePartitionKeyLocation = key.IndexOf(cachePartitionKey, StringComparison.Ordinal);

                if (cachePartitionKeyLocation > -1)
                {
                    key = key.Substring(cachePartitionKeyLocation + cachePartitionKey.Length + cacheKeyDelimiter.Length, key.Length - (cachePartitionKey.Length + cacheKeyDelimiter.Length));
                }
            }

            var colonLocation = key.IndexOf(cacheKeyDelimiter, StringComparison.Ordinal);

            if (colonLocation > 0)
            {
                return key.Substring(0, colonLocation);
            }

            return "";
        }

        private string cleanValue(string value)
        {
            return Regex.Replace(value, "[^a-zA-Z0-9_ :;.,\\/\"'?!(){}\\[@<>=\\-+\\*#$&`|~^%\\]]+", "");
        }

        private string getCachePartitionKey()
        {
            if (string.IsNullOrEmpty(cachePartitionKey))
            {
                return "";
            }

            return cachePartitionKey + cacheKeyDelimiter;
        }

        #region Events

        private void getButton_Click(object sender, EventArgs e)
        {
            resetElements();

            if (string.IsNullOrWhiteSpace(keyTextBox.Text))
            {
                keyLabel.ForeColor = Color.Red;
                return;
            }

            try
            {
                if (keyTextBox.Text.Contains("*"))
                {
                    showLoadingLabel();

                    var results = redisService.GetWildcard($"{getCachePartitionKey()}{keyTextBox.Text}").OrderBy(key => key).ThenBy(key => key.Length);

                    if (results.Count() == 0)
                    {
                        showResultTextBox($"{keyTextBox.Text} pattern not found.");
                    }
                    else
                    {
                        foreach (var result in results)
                        {
                            resultsCheckedListBox.Items.Add(result);
                        }

                        showCheckedBoxList();
                        showKeyCountLabel(results.Count());
                    }
                }
                else
                {
                    var result = redisService.Get(keyTextBox.Text);

                    if (string.IsNullOrEmpty(result))
                    {
                        showResultTextBox("Data is null or empty string.");
                    }
                    else
                    {
                        // Removing invalid characters
                        showResultTextBox(cleanValue(result));
                    }                       
                }
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
            finally
            {
                hideLoadingLabel();
            }
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            resetElements();

            if (string.IsNullOrWhiteSpace(keyTextBox.Text) || keyTextBox.Text.Contains("*"))
            {
                keyLabel.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(valueTextBox.Text))
            {
                valueLabel.ForeColor = Color.Red;
                return;
            }

            try
            {
                redisService.Set(keyTextBox.Text, valueTextBox.Text);
                showResultTextBox($"{keyTextBox.Text} SET with {valueTextBox.Text}");
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            hideErrorMessage();

            if (resultsCheckedListBox.CheckedItems.Count == 0)
            {
                showErrorMessage("No keys selected.");
                return;
            }

            try
            {
                var deletedKeys = new List<string>();

                foreach (var key in resultsCheckedListBox.CheckedItems.Cast<string>())
                {
                    redisService.Delete(key);
                    deletedKeys.Add(key);
                }

                resetElements();
                showResultTextBox($"Deleted{Environment.NewLine}{string.Join(Environment.NewLine, deletedKeys)}");
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void resultsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as CheckedListBox).SelectedItem == null) return;

            string key = (sender as CheckedListBox).SelectedItem.ToString();

            // Copy to clipboard
            try
            {
                Clipboard.SetText(key);
                showSuccessMessage("Key copied to clipboard");
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }

            // Get TTL
            try
            {
                var ttl = "None";
                var keyTtl = redisService.GetTtl(key);

                if (keyTtl != null)
                {
                    ttl = $"{keyTtl.Value.TotalSeconds} seconds";
                }

                showKeyTtlLabel(ttl);
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }

            // Get value
            try
            {
                var value = redisService.Get(key);

                showResultValueTextBox(cleanValue(value));
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            var allChecked = resultsCheckedListBox.CheckedItems.Count == resultsCheckedListBox.Items.Count;
            var newCheckState = !allChecked;

            for (var i = 0; i < resultsCheckedListBox.Items.Count; i++)
            {
                resultsCheckedListBox.SetItemChecked(i, newCheckState);
            }
        }

        private void keyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (keyLabel.ForeColor == Color.Red)
            {
                keyLabel.ForeColor = Color.Black;
            }
        }

        private void valueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (valueLabel.ForeColor == Color.Red)
            {
                valueLabel.ForeColor = Color.Black;
            }
        }

        private void getPrefixesButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cacheKeyDelimiter))
                {
                    showErrorMessage("Cache key delimiter must be configured.");
                    return;
                }

                showLoadingLabel();

                var pattern = $"{getCachePartitionKey()}*";
                var results = redisService.GetWildcard(pattern);

                if (results.Count == 0)
                {
                    showResultTextBox($"No keys found.");
                    return;
                }

                prefixComboBox.Items.Clear();
                var resultsDictionary = new Dictionary<string, string>();

                foreach (var result in results)
                {
                    var prefix = getPrefix(result);
                        
                    if (!string.IsNullOrWhiteSpace(prefix) && !resultsDictionary.ContainsKey(prefix))
                    {
                        resultsDictionary.Add(prefix, prefix);
                    }
                }

                prefixComboBox.Items.AddRange(resultsDictionary.Keys.OrderBy(key => key).ThenBy(key => key.Length).ToArray());
                showSuccessMessage("Prefixes added to drop down.");
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
            finally
            {
                hideLoadingLabel();
            }
        }

        private void tenantComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyTextBox.Text = $"*{prefixComboBox.SelectedItem}*";
        }

        #endregion

        #region UI

        private void resetElements()
        {
            hideErrorMessage();
            hideSuccessMessage();
            hideKeyCountLabel();
            hideKeyTtlLabel();
            hideCheckedBoxList();
            hideResultTextBox();
            hideResultValueTextBox();
            hideLoadingLabel();
            keyLabel.ForeColor = Color.Black;
            valueLabel.ForeColor = Color.Black;
        }

        private void hideLoadingLabel()
        {
            loadingLabel.Visible = false;
        }

        private void showLoadingLabel()
        {
            loadingLabel.Visible = true;
        }

        private void hideErrorMessage()
        {
            errorLabel.Text = "";
            errorLabel.Visible = false;
        }

        private void showErrorMessage(string message)
        {
            errorLabel.Text = message;
            errorLabel.Visible = true;
        }

        private void hideSuccessMessage()
        {
            successLabel.Text = "";
            successLabel.Visible = false;
        }

        private void showSuccessMessage(string message)
        {
            successLabel.Text = message;
            successLabel.Visible = true;
        }

        private void hideResultTextBox()
        {
            resultTextBox.Text = "";
            resultTextBox.Visible = false;
        }

        private void showResultTextBox(string result)
        {
            resultTextBox.Text = result;
            resultTextBox.Visible = true;
        }

        private void hideKeyCountLabel()
        {
            keyCountLabel.Text = "";
            keyCountLabel.Visible = false;
        }

        private void showKeyCountLabel(int count)
        {
            keyCountLabel.Text = $"Key count: {count}";
            keyCountLabel.Visible = true;
        }

        private void hideKeyTtlLabel()
        {
            keyTtlLabel.Text = "";
            keyTtlLabel.Visible = false;
        }

        private void showKeyTtlLabel(string ttl)
        {
            keyTtlLabel.Text = $"TTL: {ttl}";
            keyTtlLabel.Visible = true;
        }

        private void hideCheckedBoxList()
        {
            resultsCheckedListBox.Visible = false;
            resultsCheckedListBox.Items.Clear();
            selectAllButton.Visible = false;
            delButton.Visible = false;
        }

        private void showCheckedBoxList()
        {
            resultsCheckedListBox.Visible = true;
            selectAllButton.Visible = true;
            delButton.Visible = true;
        }

        private void hideResultValueTextBox()
        {
            resultValueTextBox.Text = "";
            resultValueTextBox.Visible = false;
        }

        private void showResultValueTextBox(string result)
        {
            resultValueTextBox.Text = result;
            resultValueTextBox.Visible = true;
        }

        #endregion
    }
}
