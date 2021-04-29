namespace DbProviderFactory
{
    partial class Window
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
            this.comboBoxProviders = new System.Windows.Forms.ComboBox();
            this.textBoxConnectionString = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxSqlRequest = new System.Windows.Forms.TextBox();
            this.buttonGetProviders = new System.Windows.Forms.Button();
            this.buttonSendRequest = new System.Windows.Forms.Button();
            this.labelConnectionString = new System.Windows.Forms.Label();
            this.labelSqlRequest = new System.Windows.Forms.Label();
            this.labelProvider = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxProviders
            // 
            this.comboBoxProviders.FormattingEnabled = true;
            this.comboBoxProviders.Location = new System.Drawing.Point(12, 26);
            this.comboBoxProviders.Name = "comboBoxProviders";
            this.comboBoxProviders.Size = new System.Drawing.Size(220, 21);
            this.comboBoxProviders.TabIndex = 0;
            this.comboBoxProviders.Click += new System.EventHandler(this.ClickSelectedIndexChanged);
            // 
            // textBoxConnectionString
            // 
            this.textBoxConnectionString.AccessibleDescription = "";
            this.textBoxConnectionString.AccessibleName = "";
            this.textBoxConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConnectionString.Location = new System.Drawing.Point(12, 75);
            this.textBoxConnectionString.Name = "textBoxConnectionString";
            this.textBoxConnectionString.ReadOnly = true;
            this.textBoxConnectionString.Size = new System.Drawing.Size(531, 20);
            this.textBoxConnectionString.TabIndex = 1;
            this.textBoxConnectionString.Tag = "";
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 168);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(532, 277);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxSqlRequest
            // 
            this.textBoxSqlRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSqlRequest.Location = new System.Drawing.Point(12, 123);
            this.textBoxSqlRequest.Name = "textBoxSqlRequest";
            this.textBoxSqlRequest.Size = new System.Drawing.Size(377, 20);
            this.textBoxSqlRequest.TabIndex = 3;
            this.textBoxSqlRequest.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TextChanged);
            this.textBoxSqlRequest.Text = "select * from products";
            // 
            // buttonGetProviders
            // 
            this.buttonGetProviders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetProviders.Location = new System.Drawing.Point(395, 26);
            this.buttonGetProviders.Name = "buttonGetProviders";
            this.buttonGetProviders.Size = new System.Drawing.Size(149, 21);
            this.buttonGetProviders.TabIndex = 4;
            this.buttonGetProviders.Text = "Get providers";
            this.buttonGetProviders.UseVisualStyleBackColor = true;
            this.buttonGetProviders.Click += new System.EventHandler(this.ClickGetProviders);
            // 
            // buttonSendRequest
            // 
            this.buttonSendRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSendRequest.Location = new System.Drawing.Point(395, 123);
            this.buttonSendRequest.Name = "buttonSendRequest";
            this.buttonSendRequest.Size = new System.Drawing.Size(149, 20);
            this.buttonSendRequest.TabIndex = 5;
            this.buttonSendRequest.Text = "Send request";
            this.buttonSendRequest.UseVisualStyleBackColor = true;
            this.buttonSendRequest.Click += new System.EventHandler(this.ClickSendRequest);
            // 
            // labelConnectionString
            // 
            this.labelConnectionString.AutoSize = true;
            this.labelConnectionString.Location = new System.Drawing.Point(9, 59);
            this.labelConnectionString.Name = "labelConnectionString";
            this.labelConnectionString.Size = new System.Drawing.Size(95, 13);
            this.labelConnectionString.TabIndex = 6;
            this.labelConnectionString.Text = "Connection string: ";
            // 
            // labelSqlRequest
            // 
            this.labelSqlRequest.AutoSize = true;
            this.labelSqlRequest.Location = new System.Drawing.Point(9, 107);
            this.labelSqlRequest.Name = "labelSqlRequest";
            this.labelSqlRequest.Size = new System.Drawing.Size(69, 13);
            this.labelSqlRequest.TabIndex = 7;
            this.labelSqlRequest.Text = "SQL request:";
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.Location = new System.Drawing.Point(9, 9);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(54, 13);
            this.labelProvider.TabIndex = 8;
            this.labelProvider.Text = "Providers:";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 457);
            this.Controls.Add(this.labelProvider);
            this.Controls.Add(this.labelSqlRequest);
            this.Controls.Add(this.labelConnectionString);
            this.Controls.Add(this.buttonSendRequest);
            this.Controls.Add(this.buttonGetProviders);
            this.Controls.Add(this.textBoxSqlRequest);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxConnectionString);
            this.Controls.Add(this.comboBoxProviders);
            this.Name = "Window";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProviders;
        private System.Windows.Forms.TextBox textBoxConnectionString;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxSqlRequest;
        private System.Windows.Forms.Button buttonGetProviders;
        private System.Windows.Forms.Button buttonSendRequest;
        private System.Windows.Forms.Label labelConnectionString;
        private System.Windows.Forms.Label labelSqlRequest;
        private System.Windows.Forms.Label labelProvider;
    }
}

