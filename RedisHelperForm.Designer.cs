namespace RedisHelper
{
    partial class RedisHelperForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedisHelperForm));
            this.getButton = new System.Windows.Forms.Button();
            this.setButton = new System.Windows.Forms.Button();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.resultsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.delButton = new System.Windows.Forms.Button();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.prefixComboBox = new System.Windows.Forms.ComboBox();
            this.getPrefixesButton = new System.Windows.Forms.Button();
            this.helpLabel = new System.Windows.Forms.Label();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.resultValueTextBox = new System.Windows.Forms.TextBox();
            this.keyTtlLabel = new System.Windows.Forms.Label();
            this.keyCountLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.helpGroupBox = new System.Windows.Forms.GroupBox();
            this.successLabel = new System.Windows.Forms.Label();
            this.cachePartitionKeyLabel = new System.Windows.Forms.Label();
            this.cachePartitionKeyValueLabel = new System.Windows.Forms.Label();
            this.cacheKeyDelimiterValueLabel = new System.Windows.Forms.Label();
            this.cacheKeyDelimiterLabel = new System.Windows.Forms.Label();
            this.resultsGroupBox.SuspendLayout();
            this.helpGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // getButton
            // 
            this.getButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getButton.Location = new System.Drawing.Point(734, 25);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(75, 23);
            this.getButton.TabIndex = 0;
            this.getButton.Text = "GET";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // setButton
            // 
            this.setButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setButton.Location = new System.Drawing.Point(734, 53);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 1;
            this.setButton.Text = "SET";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyTextBox.Location = new System.Drawing.Point(446, 27);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(282, 20);
            this.keyTextBox.TabIndex = 3;
            this.keyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyTextBox_KeyDown);
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(415, 30);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(25, 13);
            this.keyLabel.TabIndex = 4;
            this.keyLabel.Text = "Key";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueTextBox.Location = new System.Drawing.Point(446, 55);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(282, 20);
            this.valueTextBox.TabIndex = 5;
            this.valueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valueTextBox_KeyDown);
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(406, 58);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(34, 13);
            this.valueLabel.TabIndex = 6;
            this.valueLabel.Text = "Value";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(14, 4);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(74, 13);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.Text = "Error message";
            this.errorLabel.Visible = false;
            // 
            // resultsCheckedListBox
            // 
            this.resultsCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsCheckedListBox.CheckOnClick = true;
            this.resultsCheckedListBox.FormattingEnabled = true;
            this.resultsCheckedListBox.Location = new System.Drawing.Point(9, 16);
            this.resultsCheckedListBox.Name = "resultsCheckedListBox";
            this.resultsCheckedListBox.Size = new System.Drawing.Size(1076, 484);
            this.resultsCheckedListBox.TabIndex = 12;
            this.resultsCheckedListBox.Visible = false;
            this.resultsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.resultsCheckedListBox_SelectedIndexChanged);
            // 
            // delButton
            // 
            this.delButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delButton.Location = new System.Drawing.Point(1091, 59);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(69, 23);
            this.delButton.TabIndex = 14;
            this.delButton.Text = "DEL";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Visible = false;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // selectAllButton
            // 
            this.selectAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectAllButton.Location = new System.Drawing.Point(1091, 14);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(69, 40);
            this.selectAllButton.TabIndex = 15;
            this.selectAllButton.Text = "SELECT ALL";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Visible = false;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // prefixComboBox
            // 
            this.prefixComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prefixComboBox.FormattingEnabled = true;
            this.prefixComboBox.Location = new System.Drawing.Point(86, 55);
            this.prefixComboBox.Name = "prefixComboBox";
            this.prefixComboBox.Size = new System.Drawing.Size(314, 21);
            this.prefixComboBox.TabIndex = 16;
            this.prefixComboBox.SelectedIndexChanged += new System.EventHandler(this.tenantComboBox_SelectedIndexChanged);
            // 
            // getPrefixesButton
            // 
            this.getPrefixesButton.Location = new System.Drawing.Point(12, 47);
            this.getPrefixesButton.Name = "getPrefixesButton";
            this.getPrefixesButton.Size = new System.Drawing.Size(68, 34);
            this.getPrefixesButton.TabIndex = 17;
            this.getPrefixesButton.Text = "GET PREFIXES";
            this.getPrefixesButton.UseVisualStyleBackColor = true;
            this.getPrefixesButton.Click += new System.EventHandler(this.getPrefixesButton_Click);
            // 
            // helpLabel
            // 
            this.helpLabel.Location = new System.Drawing.Point(6, 19);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(351, 54);
            this.helpLabel.TabIndex = 18;
            this.helpLabel.Text = "Keys are case sensitive.\r\nUse wildcards to GET all keys. You can then pick keys f" +
    "or DEL. \r\nUse exact key to GET value. Invalid characters will be removed.\r\nWildc" +
    "ards cannot SET values.\r\n";
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsGroupBox.Controls.Add(this.loadingLabel);
            this.resultsGroupBox.Controls.Add(this.resultValueTextBox);
            this.resultsGroupBox.Controls.Add(this.keyTtlLabel);
            this.resultsGroupBox.Controls.Add(this.keyCountLabel);
            this.resultsGroupBox.Controls.Add(this.resultsCheckedListBox);
            this.resultsGroupBox.Controls.Add(this.delButton);
            this.resultsGroupBox.Controls.Add(this.selectAllButton);
            this.resultsGroupBox.Controls.Add(this.resultTextBox);
            this.resultsGroupBox.Location = new System.Drawing.Point(12, 80);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(1166, 643);
            this.resultsGroupBox.TabIndex = 19;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results";
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.loadingLabel.Location = new System.Drawing.Point(547, 264);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(107, 26);
            this.loadingLabel.TabIndex = 24;
            this.loadingLabel.Text = "Loading...";
            this.loadingLabel.Visible = false;
            // 
            // resultValueTextBox
            // 
            this.resultValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultValueTextBox.Location = new System.Drawing.Point(9, 519);
            this.resultValueTextBox.Multiline = true;
            this.resultValueTextBox.Name = "resultValueTextBox";
            this.resultValueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultValueTextBox.Size = new System.Drawing.Size(1076, 118);
            this.resultValueTextBox.TabIndex = 23;
            this.resultValueTextBox.Visible = false;
            // 
            // keyTtlLabel
            // 
            this.keyTtlLabel.AutoSize = true;
            this.keyTtlLabel.Location = new System.Drawing.Point(192, 503);
            this.keyTtlLabel.Name = "keyTtlLabel";
            this.keyTtlLabel.Size = new System.Drawing.Size(30, 13);
            this.keyTtlLabel.TabIndex = 17;
            this.keyTtlLabel.Text = "TTL:";
            this.keyTtlLabel.Visible = false;
            // 
            // keyCountLabel
            // 
            this.keyCountLabel.AutoSize = true;
            this.keyCountLabel.Location = new System.Drawing.Point(6, 503);
            this.keyCountLabel.Name = "keyCountLabel";
            this.keyCountLabel.Size = new System.Drawing.Size(59, 13);
            this.keyCountLabel.TabIndex = 16;
            this.keyCountLabel.Text = "Key Count:";
            this.keyCountLabel.Visible = false;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTextBox.Location = new System.Drawing.Point(9, 16);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(1076, 621);
            this.resultTextBox.TabIndex = 22;
            this.resultTextBox.Visible = false;
            // 
            // helpGroupBox
            // 
            this.helpGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpGroupBox.Controls.Add(this.helpLabel);
            this.helpGroupBox.Location = new System.Drawing.Point(815, 1);
            this.helpGroupBox.Name = "helpGroupBox";
            this.helpGroupBox.Size = new System.Drawing.Size(363, 82);
            this.helpGroupBox.TabIndex = 20;
            this.helpGroupBox.TabStop = false;
            this.helpGroupBox.Text = "Help";
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.ForeColor = System.Drawing.Color.Green;
            this.successLabel.Location = new System.Drawing.Point(14, 4);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(93, 13);
            this.successLabel.TabIndex = 21;
            this.successLabel.Text = "Success message";
            this.successLabel.Visible = false;
            // 
            // cachePartitionKeyLabel
            // 
            this.cachePartitionKeyLabel.AutoSize = true;
            this.cachePartitionKeyLabel.Location = new System.Drawing.Point(83, 28);
            this.cachePartitionKeyLabel.Name = "cachePartitionKeyLabel";
            this.cachePartitionKeyLabel.Size = new System.Drawing.Size(101, 13);
            this.cachePartitionKeyLabel.TabIndex = 22;
            this.cachePartitionKeyLabel.Text = "Cache partition key:";
            // 
            // cachePartitionKeyValueLabel
            // 
            this.cachePartitionKeyValueLabel.AutoSize = true;
            this.cachePartitionKeyValueLabel.Location = new System.Drawing.Point(181, 28);
            this.cachePartitionKeyValueLabel.Name = "cachePartitionKeyValueLabel";
            this.cachePartitionKeyValueLabel.Size = new System.Drawing.Size(37, 13);
            this.cachePartitionKeyValueLabel.TabIndex = 23;
            this.cachePartitionKeyValueLabel.Text = "(none)";
            // 
            // cacheKeyDelimiterValueLabel
            // 
            this.cacheKeyDelimiterValueLabel.AutoSize = true;
            this.cacheKeyDelimiterValueLabel.Location = new System.Drawing.Point(181, 41);
            this.cacheKeyDelimiterValueLabel.Name = "cacheKeyDelimiterValueLabel";
            this.cacheKeyDelimiterValueLabel.Size = new System.Drawing.Size(37, 13);
            this.cacheKeyDelimiterValueLabel.TabIndex = 25;
            this.cacheKeyDelimiterValueLabel.Text = "(none)";
            // 
            // cacheKeyDelimiterLabel
            // 
            this.cacheKeyDelimiterLabel.AutoSize = true;
            this.cacheKeyDelimiterLabel.Location = new System.Drawing.Point(83, 41);
            this.cacheKeyDelimiterLabel.Name = "cacheKeyDelimiterLabel";
            this.cacheKeyDelimiterLabel.Size = new System.Drawing.Size(102, 13);
            this.cacheKeyDelimiterLabel.TabIndex = 24;
            this.cacheKeyDelimiterLabel.Text = "Cache key delimiter:";
            // 
            // RedisHelperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 737);
            this.Controls.Add(this.cacheKeyDelimiterValueLabel);
            this.Controls.Add(this.cacheKeyDelimiterLabel);
            this.Controls.Add(this.cachePartitionKeyValueLabel);
            this.Controls.Add(this.cachePartitionKeyLabel);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.helpGroupBox);
            this.Controls.Add(this.getPrefixesButton);
            this.Controls.Add(this.prefixComboBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.resultsGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1209, 752);
            this.Name = "RedisHelperForm";
            this.Text = "Redis Helper";
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.helpGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.CheckedListBox resultsCheckedListBox;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.ComboBox prefixComboBox;
        private System.Windows.Forms.Button getPrefixesButton;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.GroupBox helpGroupBox;
        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.Label keyCountLabel;
        private System.Windows.Forms.Label keyTtlLabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox resultValueTextBox;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.Label cachePartitionKeyLabel;
        private System.Windows.Forms.Label cachePartitionKeyValueLabel;
        private System.Windows.Forms.Label cacheKeyDelimiterValueLabel;
        private System.Windows.Forms.Label cacheKeyDelimiterLabel;
    }
}

