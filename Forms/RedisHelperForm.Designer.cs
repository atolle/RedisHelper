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
            this.topLayout = new System.Windows.Forms.TableLayoutPanel();
            this.controlsCardOuter = new System.Windows.Forms.Panel();
            this.controlsCardInner = new System.Windows.Forms.Panel();
            this.successLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.setButton = new System.Windows.Forms.Button();
            this.getButton = new System.Windows.Forms.Button();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.cacheKeyDelimiterValueLabel = new System.Windows.Forms.Label();
            this.cacheKeyDelimiterLabel = new System.Windows.Forms.Label();
            this.cachePartitionKeyValueLabel = new System.Windows.Forms.Label();
            this.cachePartitionKeyLabel = new System.Windows.Forms.Label();
            this.prefixComboBox = new System.Windows.Forms.ComboBox();
            this.getPrefixesButton = new System.Windows.Forms.Button();
            this.createTestKeysButton = new System.Windows.Forms.Button();
            this.migrateButton = new System.Windows.Forms.Button();
            this.helpCardOuter = new System.Windows.Forms.Panel();
            this.helpCardInner = new System.Windows.Forms.Panel();
            this.helpLabel = new System.Windows.Forms.Label();
            this.helpHeaderLabel = new System.Windows.Forms.Label();
            this.resultsCardOuter = new System.Windows.Forms.Panel();
            this.resultsCardInner = new System.Windows.Forms.Panel();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.resultValueTextBox = new System.Windows.Forms.TextBox();
            this.keyTtlLabel = new System.Windows.Forms.Label();
            this.keyCountLabel = new System.Windows.Forms.Label();
            this.delMultiButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.resultsHeaderLabel = new System.Windows.Forms.Label();
            this.resultsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.topLayout.SuspendLayout();
            this.controlsCardOuter.SuspendLayout();
            this.controlsCardInner.SuspendLayout();
            this.helpCardOuter.SuspendLayout();
            this.helpCardInner.SuspendLayout();
            this.resultsCardOuter.SuspendLayout();
            this.resultsCardInner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsSplitContainer)).BeginInit();
            this.resultsSplitContainer.Panel1.SuspendLayout();
            this.resultsSplitContainer.Panel2.SuspendLayout();
            this.resultsSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLayout
            // 
            this.topLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topLayout.ColumnCount = 2;
            this.topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.topLayout.Controls.Add(this.controlsCardOuter, 0, 0);
            this.topLayout.Controls.Add(this.helpCardOuter, 1, 0);
            this.topLayout.Location = new System.Drawing.Point(12, 12);
            this.topLayout.Name = "topLayout";
            this.topLayout.RowCount = 1;
            this.topLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topLayout.Size = new System.Drawing.Size(1176, 195);
            this.topLayout.TabIndex = 0;
            // 
            // controlsCardOuter
            // 
            this.controlsCardOuter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.controlsCardOuter.Controls.Add(this.controlsCardInner);
            this.controlsCardOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsCardOuter.Location = new System.Drawing.Point(3, 3);
            this.controlsCardOuter.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.controlsCardOuter.Name = "controlsCardOuter";
            this.controlsCardOuter.Padding = new System.Windows.Forms.Padding(1);
            this.controlsCardOuter.Size = new System.Drawing.Size(858, 189);
            this.controlsCardOuter.TabIndex = 0;
            // 
            // controlsCardInner
            // 
            this.controlsCardInner.BackColor = System.Drawing.Color.White;
            this.controlsCardInner.Controls.Add(this.successLabel);
            this.controlsCardInner.Controls.Add(this.errorLabel);
            this.controlsCardInner.Controls.Add(this.setButton);
            this.controlsCardInner.Controls.Add(this.getButton);
            this.controlsCardInner.Controls.Add(this.valueTextBox);
            this.controlsCardInner.Controls.Add(this.valueLabel);
            this.controlsCardInner.Controls.Add(this.keyTextBox);
            this.controlsCardInner.Controls.Add(this.keyLabel);
            this.controlsCardInner.Controls.Add(this.cacheKeyDelimiterValueLabel);
            this.controlsCardInner.Controls.Add(this.cacheKeyDelimiterLabel);
            this.controlsCardInner.Controls.Add(this.cachePartitionKeyValueLabel);
            this.controlsCardInner.Controls.Add(this.cachePartitionKeyLabel);
            this.controlsCardInner.Controls.Add(this.prefixComboBox);
            this.controlsCardInner.Controls.Add(this.getPrefixesButton);
            this.controlsCardInner.Controls.Add(this.createTestKeysButton);
            this.controlsCardInner.Controls.Add(this.migrateButton);
            this.controlsCardInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsCardInner.Location = new System.Drawing.Point(1, 1);
            this.controlsCardInner.Name = "controlsCardInner";
            this.controlsCardInner.Size = new System.Drawing.Size(856, 187);
            this.controlsCardInner.TabIndex = 0;
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.successLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.successLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.successLabel.Location = new System.Drawing.Point(16, 150);
            this.successLabel.Name = "successLabel";
            this.successLabel.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.successLabel.Size = new System.Drawing.Size(125, 25);
            this.successLabel.TabIndex = 21;
            this.successLabel.Text = "Success message";
            this.successLabel.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.errorLabel.Location = new System.Drawing.Point(16, 150);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.errorLabel.Size = new System.Drawing.Size(110, 25);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.Text = "Error message";
            this.errorLabel.Visible = false;
            // 
            // setButton
            // 
            this.setButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.setButton.FlatAppearance.BorderSize = 0;
            this.setButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.setButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setButton.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.setButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.setButton.Location = new System.Drawing.Point(766, 124);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(84, 30);
            this.setButton.TabIndex = 1;
            this.setButton.Text = "SET";
            this.setButton.UseVisualStyleBackColor = false;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // getButton
            // 
            this.getButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.getButton.FlatAppearance.BorderSize = 0;
            this.getButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.getButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getButton.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.getButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.getButton.Location = new System.Drawing.Point(766, 88);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(84, 30);
            this.getButton.TabIndex = 0;
            this.getButton.Text = "GET";
            this.getButton.UseVisualStyleBackColor = false;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // valueTextBox
            // 
            this.valueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueTextBox.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.valueTextBox.Location = new System.Drawing.Point(292, 108);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(300, 24);
            this.valueTextBox.TabIndex = 5;
            this.valueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valueTextBox_KeyDown);
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.valueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.valueLabel.Location = new System.Drawing.Point(292, 91);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(41, 13);
            this.valueLabel.TabIndex = 6;
            this.valueLabel.Text = "VALUE";
            // 
            // keyTextBox
            // 
            this.keyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyTextBox.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.keyTextBox.Location = new System.Drawing.Point(16, 108);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(260, 24);
            this.keyTextBox.TabIndex = 3;
            this.keyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyTextBox_KeyDown);
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.keyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.keyLabel.Location = new System.Drawing.Point(16, 91);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(27, 13);
            this.keyLabel.TabIndex = 4;
            this.keyLabel.Text = "KEY";
            // 
            // cacheKeyDelimiterValueLabel
            // 
            this.cacheKeyDelimiterValueLabel.AutoSize = true;
            this.cacheKeyDelimiterValueLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.cacheKeyDelimiterValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.cacheKeyDelimiterValueLabel.Location = new System.Drawing.Point(450, 55);
            this.cacheKeyDelimiterValueLabel.Name = "cacheKeyDelimiterValueLabel";
            this.cacheKeyDelimiterValueLabel.Size = new System.Drawing.Size(49, 17);
            this.cacheKeyDelimiterValueLabel.TabIndex = 25;
            this.cacheKeyDelimiterValueLabel.Text = "(none)";
            // 
            // cacheKeyDelimiterLabel
            // 
            this.cacheKeyDelimiterLabel.AutoSize = true;
            this.cacheKeyDelimiterLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.cacheKeyDelimiterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.cacheKeyDelimiterLabel.Location = new System.Drawing.Point(330, 58);
            this.cacheKeyDelimiterLabel.Name = "cacheKeyDelimiterLabel";
            this.cacheKeyDelimiterLabel.Size = new System.Drawing.Size(114, 15);
            this.cacheKeyDelimiterLabel.TabIndex = 24;
            this.cacheKeyDelimiterLabel.Text = "Cache key delimiter:";
            // 
            // cachePartitionKeyValueLabel
            // 
            this.cachePartitionKeyValueLabel.AutoSize = true;
            this.cachePartitionKeyValueLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.cachePartitionKeyValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.cachePartitionKeyValueLabel.Location = new System.Drawing.Point(134, 55);
            this.cachePartitionKeyValueLabel.Name = "cachePartitionKeyValueLabel";
            this.cachePartitionKeyValueLabel.Size = new System.Drawing.Size(49, 17);
            this.cachePartitionKeyValueLabel.TabIndex = 23;
            this.cachePartitionKeyValueLabel.Text = "(none)";
            // 
            // cachePartitionKeyLabel
            // 
            this.cachePartitionKeyLabel.AutoSize = true;
            this.cachePartitionKeyLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.cachePartitionKeyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.cachePartitionKeyLabel.Location = new System.Drawing.Point(16, 58);
            this.cachePartitionKeyLabel.Name = "cachePartitionKeyLabel";
            this.cachePartitionKeyLabel.Size = new System.Drawing.Size(112, 15);
            this.cachePartitionKeyLabel.TabIndex = 22;
            this.cachePartitionKeyLabel.Text = "Cache partition key:";
            // 
            // prefixComboBox
            // 
            this.prefixComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prefixComboBox.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.prefixComboBox.FormattingEnabled = true;
            this.prefixComboBox.Location = new System.Drawing.Point(404, 16);
            this.prefixComboBox.Name = "prefixComboBox";
            this.prefixComboBox.Size = new System.Drawing.Size(260, 25);
            this.prefixComboBox.TabIndex = 16;
            this.prefixComboBox.SelectedIndexChanged += new System.EventHandler(this.tenantComboBox_SelectedIndexChanged);
            // 
            // getPrefixesButton
            // 
            this.getPrefixesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.getPrefixesButton.FlatAppearance.BorderSize = 0;
            this.getPrefixesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.getPrefixesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getPrefixesButton.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.getPrefixesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.getPrefixesButton.Location = new System.Drawing.Point(266, 14);
            this.getPrefixesButton.Name = "getPrefixesButton";
            this.getPrefixesButton.Size = new System.Drawing.Size(130, 30);
            this.getPrefixesButton.TabIndex = 17;
            this.getPrefixesButton.Text = "GET PREFIXES";
            this.getPrefixesButton.UseVisualStyleBackColor = false;
            this.getPrefixesButton.Click += new System.EventHandler(this.getPrefixesButton_Click);
            // 
            // createTestKeysButton
            // 
            this.createTestKeysButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.createTestKeysButton.Enabled = false;
            this.createTestKeysButton.FlatAppearance.BorderSize = 0;
            this.createTestKeysButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.createTestKeysButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTestKeysButton.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.createTestKeysButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.createTestKeysButton.Location = new System.Drawing.Point(108, 14);
            this.createTestKeysButton.Name = "createTestKeysButton";
            this.createTestKeysButton.Size = new System.Drawing.Size(150, 30);
            this.createTestKeysButton.TabIndex = 27;
            this.createTestKeysButton.Text = "CREATE TEST KEYS";
            this.createTestKeysButton.UseVisualStyleBackColor = false;
            this.createTestKeysButton.Click += new System.EventHandler(this.createTestKeysButton_Click);
            // 
            // migrateButton
            // 
            this.migrateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.migrateButton.Enabled = false;
            this.migrateButton.FlatAppearance.BorderSize = 0;
            this.migrateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.migrateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.migrateButton.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.migrateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.migrateButton.Location = new System.Drawing.Point(16, 14);
            this.migrateButton.Name = "migrateButton";
            this.migrateButton.Size = new System.Drawing.Size(84, 30);
            this.migrateButton.TabIndex = 26;
            this.migrateButton.Text = "MIGRATE";
            this.migrateButton.UseVisualStyleBackColor = false;
            this.migrateButton.Click += new System.EventHandler(this.migrateButton_Click);
            // 
            // helpCardOuter
            // 
            this.helpCardOuter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.helpCardOuter.Controls.Add(this.helpCardInner);
            this.helpCardOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpCardOuter.Location = new System.Drawing.Point(879, 3);
            this.helpCardOuter.Name = "helpCardOuter";
            this.helpCardOuter.Padding = new System.Windows.Forms.Padding(1);
            this.helpCardOuter.Size = new System.Drawing.Size(294, 189);
            this.helpCardOuter.TabIndex = 1;
            // 
            // helpCardInner
            // 
            this.helpCardInner.BackColor = System.Drawing.Color.White;
            this.helpCardInner.Controls.Add(this.helpLabel);
            this.helpCardInner.Controls.Add(this.helpHeaderLabel);
            this.helpCardInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpCardInner.Location = new System.Drawing.Point(1, 1);
            this.helpCardInner.Name = "helpCardInner";
            this.helpCardInner.Size = new System.Drawing.Size(292, 187);
            this.helpCardInner.TabIndex = 0;
            // 
            // helpLabel
            // 
            this.helpLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.helpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.helpLabel.Location = new System.Drawing.Point(16, 42);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(268, 134);
            this.helpLabel.TabIndex = 18;
            this.helpLabel.Text = "Keys are case sensitive.\r\nUse wildcards to GET all keys. You can then pick keys f" +
    "or DEL. \r\nUse exact key to GET value. Invalid characters will be removed.\r\nWildc" +
    "ards cannot SET values.\r\n";
            // 
            // helpHeaderLabel
            // 
            this.helpHeaderLabel.AutoSize = true;
            this.helpHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.helpHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.helpHeaderLabel.Location = new System.Drawing.Point(16, 12);
            this.helpHeaderLabel.Name = "helpHeaderLabel";
            this.helpHeaderLabel.Size = new System.Drawing.Size(41, 20);
            this.helpHeaderLabel.TabIndex = 0;
            this.helpHeaderLabel.Text = "Help";
            // 
            // resultsCardOuter
            // 
            this.resultsCardOuter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsCardOuter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.resultsCardOuter.Controls.Add(this.resultsCardInner);
            this.resultsCardOuter.Location = new System.Drawing.Point(12, 219);
            this.resultsCardOuter.Name = "resultsCardOuter";
            this.resultsCardOuter.Padding = new System.Windows.Forms.Padding(1);
            this.resultsCardOuter.Size = new System.Drawing.Size(1176, 569);
            this.resultsCardOuter.TabIndex = 19;
            // 
            // resultsCardInner
            // 
            this.resultsCardInner.BackColor = System.Drawing.Color.White;
            this.resultsCardInner.Controls.Add(this.loadingLabel);
            this.resultsCardInner.Controls.Add(this.resultTextBox);
            this.resultsCardInner.Controls.Add(this.delMultiButton);
            this.resultsCardInner.Controls.Add(this.delButton);
            this.resultsCardInner.Controls.Add(this.selectAllButton);
            this.resultsCardInner.Controls.Add(this.resultsSplitContainer);
            this.resultsCardInner.Controls.Add(this.resultsHeaderLabel);
            this.resultsCardInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsCardInner.Location = new System.Drawing.Point(1, 1);
            this.resultsCardInner.Name = "resultsCardInner";
            this.resultsCardInner.Size = new System.Drawing.Size(1174, 567);
            this.resultsCardInner.TabIndex = 0;
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.loadingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.loadingLabel.Location = new System.Drawing.Point(491, 250);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(95, 25);
            this.loadingLabel.TabIndex = 24;
            this.loadingLabel.Text = "Loading...";
            this.loadingLabel.Visible = false;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultTextBox.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.resultTextBox.Location = new System.Drawing.Point(16, 44);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(1034, 507);
            this.resultTextBox.TabIndex = 22;
            this.resultTextBox.Visible = false;
            // 
            // resultValueTextBox
            //
            this.resultValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultValueTextBox.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.resultValueTextBox.Location = new System.Drawing.Point(0, 26);
            this.resultValueTextBox.Multiline = true;
            this.resultValueTextBox.Name = "resultValueTextBox";
            this.resultValueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultValueTextBox.Size = new System.Drawing.Size(1034, 75);
            this.resultValueTextBox.TabIndex = 23;
            this.resultValueTextBox.Visible = false;
            //
            // keyTtlLabel
            //
            this.keyTtlLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.keyTtlLabel.AutoSize = true;
            this.keyTtlLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.keyTtlLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.keyTtlLabel.Location = new System.Drawing.Point(204, 6);
            this.keyTtlLabel.Name = "keyTtlLabel";
            this.keyTtlLabel.Size = new System.Drawing.Size(30, 15);
            this.keyTtlLabel.TabIndex = 17;
            this.keyTtlLabel.Text = "TTL:";
            this.keyTtlLabel.Visible = false;
            //
            // keyCountLabel
            //
            this.keyCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.keyCountLabel.AutoSize = true;
            this.keyCountLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.keyCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.keyCountLabel.Location = new System.Drawing.Point(0, 6);
            this.keyCountLabel.Name = "keyCountLabel";
            this.keyCountLabel.Size = new System.Drawing.Size(65, 15);
            this.keyCountLabel.TabIndex = 16;
            this.keyCountLabel.Text = "Key Count:";
            this.keyCountLabel.Visible = false;
            //
            // delMultiButton
            // 
            this.delMultiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delMultiButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.delMultiButton.FlatAppearance.BorderSize = 0;
            this.delMultiButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.delMultiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delMultiButton.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.delMultiButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.delMultiButton.Location = new System.Drawing.Point(1066, 132);
            this.delMultiButton.Name = "delMultiButton";
            this.delMultiButton.Size = new System.Drawing.Size(90, 40);
            this.delMultiButton.TabIndex = 25;
            this.delMultiButton.Text = "DEL MULTI";
            this.delMultiButton.UseVisualStyleBackColor = false;
            this.delMultiButton.Visible = false;
            this.delMultiButton.Click += new System.EventHandler(this.delMultiButton_Click);
            // 
            // delButton
            // 
            this.delButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.delButton.FlatAppearance.BorderSize = 0;
            this.delButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.delButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delButton.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.delButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.delButton.Location = new System.Drawing.Point(1066, 96);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(90, 28);
            this.delButton.TabIndex = 14;
            this.delButton.Text = "DEL";
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Visible = false;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // selectAllButton
            // 
            this.selectAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.selectAllButton.FlatAppearance.BorderSize = 0;
            this.selectAllButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.selectAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectAllButton.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.selectAllButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.selectAllButton.Location = new System.Drawing.Point(1066, 44);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(90, 44);
            this.selectAllButton.TabIndex = 15;
            this.selectAllButton.Text = "SELECT ALL";
            this.selectAllButton.UseVisualStyleBackColor = false;
            this.selectAllButton.Visible = false;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.AllowUserToAddRows = false;
            this.resultsDataGridView.AllowUserToDeleteRows = false;
            this.resultsDataGridView.AllowUserToResizeRows = false;
            this.resultsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.resultsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.resultsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.resultsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsDataGridView.EnableHeadersVisualStyles = false;
            this.resultsDataGridView.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.resultsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.resultsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.resultsDataGridView.MultiSelect = false;
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.RowHeadersVisible = false;
            this.resultsDataGridView.RowTemplate.Height = 26;
            this.resultsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultsDataGridView.Size = new System.Drawing.Size(1034, 400);
            this.resultsDataGridView.TabIndex = 12;
            //
            // resultsSplitContainer
            //
            this.resultsSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.None;
            this.resultsSplitContainer.Location = new System.Drawing.Point(16, 44);
            this.resultsSplitContainer.Name = "resultsSplitContainer";
            this.resultsSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            // resultsSplitContainer.Panel1
            //
            this.resultsSplitContainer.Panel1.Controls.Add(this.resultsDataGridView);
            this.resultsSplitContainer.Panel1MinSize = 100;
            //
            // resultsSplitContainer.Panel2
            //
            this.resultsSplitContainer.Panel2.Controls.Add(this.keyCountLabel);
            this.resultsSplitContainer.Panel2.Controls.Add(this.keyTtlLabel);
            this.resultsSplitContainer.Panel2.Controls.Add(this.resultValueTextBox);
            this.resultsSplitContainer.Panel2MinSize = 70;
            this.resultsSplitContainer.Size = new System.Drawing.Size(1034, 507);
            this.resultsSplitContainer.SplitterDistance = 400;
            this.resultsSplitContainer.SplitterWidth = 6;
            this.resultsSplitContainer.TabIndex = 27;
            this.resultsSplitContainer.Visible = false;
            //
            // resultsHeaderLabel
            //
            this.resultsHeaderLabel.AutoSize = true;
            this.resultsHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.resultsHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.resultsHeaderLabel.Location = new System.Drawing.Point(16, 12);
            this.resultsHeaderLabel.Name = "resultsHeaderLabel";
            this.resultsHeaderLabel.Size = new System.Drawing.Size(60, 20);
            this.resultsHeaderLabel.TabIndex = 26;
            this.resultsHeaderLabel.Text = "Results";
            // 
            // RedisHelperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.resultsCardOuter);
            this.Controls.Add(this.topLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1216, 815);
            this.Name = "RedisHelperForm";
            this.Text = "Redis Helper";
            this.topLayout.ResumeLayout(false);
            this.controlsCardOuter.ResumeLayout(false);
            this.controlsCardInner.ResumeLayout(false);
            this.controlsCardInner.PerformLayout();
            this.helpCardOuter.ResumeLayout(false);
            this.helpCardInner.ResumeLayout(false);
            this.helpCardInner.PerformLayout();
            this.resultsCardOuter.ResumeLayout(false);
            this.resultsCardInner.ResumeLayout(false);
            this.resultsCardInner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.resultsSplitContainer.Panel1.ResumeLayout(false);
            this.resultsSplitContainer.Panel2.ResumeLayout(false);
            this.resultsSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsSplitContainer)).EndInit();
            this.resultsSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel topLayout;
        private System.Windows.Forms.Panel controlsCardOuter;
        private System.Windows.Forms.Panel controlsCardInner;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.ComboBox prefixComboBox;
        private System.Windows.Forms.Button getPrefixesButton;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.Panel helpCardOuter;
        private System.Windows.Forms.Panel helpCardInner;
        private System.Windows.Forms.Label helpHeaderLabel;
        private System.Windows.Forms.Panel resultsCardOuter;
        private System.Windows.Forms.Panel resultsCardInner;
        private System.Windows.Forms.Label resultsHeaderLabel;
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
        private System.Windows.Forms.Button delMultiButton;
        private System.Windows.Forms.Button migrateButton;
        private System.Windows.Forms.Button createTestKeysButton;
        private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.SplitContainer resultsSplitContainer;
    }
}
