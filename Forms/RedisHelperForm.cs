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
        private static readonly string cacheKeyDelimiter = ConfigurationManager.AppSettings["cacheKeyDelimiter"] ?? ":";
        private static readonly int createTestKeysCount = ConfigurationManager.AppSettings["createTestKeysCount"] != null 
            ? int.Parse(ConfigurationManager.AppSettings["createTestKeysCount"].ToString()) 
            : 0;
        private const int CheckColumnIndex = 0;
        private const int KeyColumnIndex = 1;

        private RedisService redisService;

        public RedisHelperForm()
        {
            InitializeComponent();
            setupResultsGrid();

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

                if (redisService.IsMigrateMode())
                {
                    migrateButton.Enabled = true;
                }

                if (createTestKeysCount > 0)
                {
                    createTestKeysButton.Enabled = true;
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

        private void setupResultsGrid()
        {
            resultsDataGridView.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colCheck",
                HeaderText = "",
                Width = 36,
                Resizable = DataGridViewTriState.False
            });

            resultsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colKey",
                HeaderText = "Key",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            resultsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Theme.GridAltRow;
            resultsDataGridView.DefaultCellStyle.SelectionBackColor = Theme.GridSelected;
            resultsDataGridView.DefaultCellStyle.SelectionForeColor = Theme.TextPrimary;
            resultsDataGridView.ColumnHeadersDefaultCellStyle.Font = Theme.BaseBold;
            resultsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Theme.CardBackground;
            resultsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Theme.TextMuted;
            resultsDataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Theme.CardBackground;
            resultsDataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Theme.TextMuted;

            resultsDataGridView.CellContentClick += resultsDataGridView_CellContentClick;
            resultsDataGridView.CellClick += resultsDataGridView_CellClick;
        }

        private IEnumerable<string> getCheckedKeys()
        {
            foreach (DataGridViewRow row in resultsDataGridView.Rows)
            {
                if (row.Cells[CheckColumnIndex].Value is bool isChecked && isChecked)
                {
                    yield return row.Cells[KeyColumnIndex].Value.ToString();
                }
            }
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
                            resultsDataGridView.Rows.Add(false, result);
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

            var checkedKeys = getCheckedKeys().ToList();

            if (checkedKeys.Count == 0)
            {
                showErrorMessage("No keys selected.");
                return;
            }

            try
            {
                var deletedKeys = new List<string>();

                foreach (var key in checkedKeys)
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

        private void migrateButton_Click(object sender, EventArgs e)
        {
            hideErrorMessage();

            try
            {
                showLoadingLabel("Migrating...");

                var results = redisService.MigrateRedis();

                resetElements();
                showSuccessMessage($"Redis migrated! Migrated: {results.MigratedCount} Failed: {results.FailedCount} Skipped: {results.SkippedCount} Elapsed: {results.Elapsed}");
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

        private void createTestKeysButton_Click(object sender, EventArgs e)
        {
            hideErrorMessage();

            try
            {
                if (createTestKeysCount <= 0)
                {
                    showErrorMessage("No key count specified.");
                }                

                showLoadingLabel("Creating test keys...");

                var entries = Enumerable.Range(0, createTestKeysCount).ToDictionary(i => $"redis-helper-test{cacheKeyDelimiter}{i}", _ => "test");

                redisService.SetBatch(entries);

                resetElements();
                showSuccessMessage($"Test keys created!");
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

        private void delMultiButton_Click(object sender, EventArgs e)
        {
            hideErrorMessage();

            var keysToDelete = getCheckedKeys().ToList();

            if (keysToDelete.Count == 0)
            {
                showErrorMessage("No keys selected.");
                return;
            }

            try
            {
                redisService.DeleteMulti(keysToDelete);

                resetElements();
                showResultTextBox($"Deleted{Environment.NewLine}{string.Join(Environment.NewLine, keysToDelete)}");
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void resultsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != CheckColumnIndex) return;

            resultsDataGridView.EndEdit();
        }

        private void resultsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != KeyColumnIndex) return;

            var key = resultsDataGridView.Rows[e.RowIndex].Cells[KeyColumnIndex].Value?.ToString();

            if (string.IsNullOrEmpty(key)) return;

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
            var allChecked = getCheckedKeys().Count() == resultsDataGridView.Rows.Count;
            var newCheckState = !allChecked;

            resultsDataGridView.EndEdit();

            foreach (DataGridViewRow row in resultsDataGridView.Rows)
            {
                row.Cells[CheckColumnIndex].Value = newCheckState;
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

        private void showLoadingLabel(string label = "Loading...")
        {
            loadingLabel.Text = label;
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
            resultsSplitContainer.Visible = false;
            resultsDataGridView.Rows.Clear();
            selectAllButton.Visible = false;
            delButton.Visible = false;
            delMultiButton.Visible = false;
        }

        private void showCheckedBoxList()
        {
            resultsSplitContainer.Visible = true;
            selectAllButton.Visible = true;
            delButton.Visible = true;
            delMultiButton.Visible = true;
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
