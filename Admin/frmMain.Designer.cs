namespace Admin
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCreateData = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.txtConnection = new System.Windows.Forms.TextBox();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.btnUnlockConnectionText = new System.Windows.Forms.Button();
            this.btnUnlockQueryText = new System.Windows.Forms.Button();
            this.btnUnlockOutputFileText = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtLocalFolder = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnUnlockFTPCredentials = new System.Windows.Forms.Button();
            this.lblSlash = new System.Windows.Forms.Label();
            this.txtFTPHost = new System.Windows.Forms.TextBox();
            this.txtFTPPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFTPUsername = new System.Windows.Forms.TextBox();
            this.lblFTPUsername = new System.Windows.Forms.Label();
            this.btnUnlockFTPLocation = new System.Windows.Forms.Button();
            this.txtFTPLocation = new System.Windows.Forms.TextBox();
            this.btnCreateAndUpload = new System.Windows.Forms.Button();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.tabAdmin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateData
            // 
            this.btnCreateData.Location = new System.Drawing.Point(3, 29);
            this.btnCreateData.Name = "btnCreateData";
            this.btnCreateData.Size = new System.Drawing.Size(75, 23);
            this.btnCreateData.TabIndex = 3;
            this.btnCreateData.Text = "Create Data";
            this.btnCreateData.UseVisualStyleBackColor = true;
            this.btnCreateData.Click += new System.EventHandler(this.btnCreateData_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.Location = new System.Drawing.Point(6, 6);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ReadOnly = true;
            this.txtQuery.Size = new System.Drawing.Size(608, 340);
            this.txtQuery.TabIndex = 0;
            this.txtQuery.Text = resources.GetString("txtQuery.Text");
            // 
            // txtConnection
            // 
            this.txtConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnection.Location = new System.Drawing.Point(6, 6);
            this.txtConnection.Name = "txtConnection";
            this.txtConnection.ReadOnly = true;
            this.txtConnection.Size = new System.Drawing.Size(605, 20);
            this.txtConnection.TabIndex = 0;
            this.txtConnection.Text = "Server=sql.example.com;Port=5432; User Id=example_user;Password=REDACTED;Database=example;";
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputFile.Location = new System.Drawing.Point(306, 3);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.ReadOnly = true;
            this.txtOutputFile.Size = new System.Drawing.Size(311, 20);
            this.txtOutputFile.TabIndex = 1;
            this.txtOutputFile.Text = "Products.xml";
            // 
            // btnUnlockConnectionText
            // 
            this.btnUnlockConnectionText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnlockConnectionText.Location = new System.Drawing.Point(620, 4);
            this.btnUnlockConnectionText.Name = "btnUnlockConnectionText";
            this.btnUnlockConnectionText.Size = new System.Drawing.Size(75, 23);
            this.btnUnlockConnectionText.TabIndex = 1;
            this.btnUnlockConnectionText.Text = "Unlock";
            this.btnUnlockConnectionText.UseVisualStyleBackColor = true;
            this.btnUnlockConnectionText.Click += new System.EventHandler(this.btnUnlockConnectionText_Click);
            // 
            // btnUnlockQueryText
            // 
            this.btnUnlockQueryText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnlockQueryText.Location = new System.Drawing.Point(623, 323);
            this.btnUnlockQueryText.Name = "btnUnlockQueryText";
            this.btnUnlockQueryText.Size = new System.Drawing.Size(75, 23);
            this.btnUnlockQueryText.TabIndex = 1;
            this.btnUnlockQueryText.Text = "Unlock";
            this.btnUnlockQueryText.UseVisualStyleBackColor = true;
            this.btnUnlockQueryText.Click += new System.EventHandler(this.btnUnlockQueryText_Click);
            // 
            // btnUnlockOutputFileText
            // 
            this.btnUnlockOutputFileText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnlockOutputFileText.Location = new System.Drawing.Point(623, 1);
            this.btnUnlockOutputFileText.Name = "btnUnlockOutputFileText";
            this.btnUnlockOutputFileText.Size = new System.Drawing.Size(75, 23);
            this.btnUnlockOutputFileText.TabIndex = 2;
            this.btnUnlockOutputFileText.Text = "Unlock";
            this.btnUnlockOutputFileText.UseVisualStyleBackColor = true;
            this.btnUnlockOutputFileText.Click += new System.EventHandler(this.btnUnlockOutputFileText_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.Location = new System.Drawing.Point(623, 323);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 10;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(3, 594);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1571, 20);
            this.lblStatus.TabIndex = 9;
            // 
            // tabAdmin
            // 
            this.tabAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabAdmin.Controls.Add(this.tabPage1);
            this.tabAdmin.Controls.Add(this.tabPage2);
            this.tabAdmin.Controls.Add(this.tabPage3);
            this.tabAdmin.Controls.Add(this.tabPage4);
            this.tabAdmin.Enabled = false;
            this.tabAdmin.Location = new System.Drawing.Point(12, 99);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(709, 375);
            this.tabAdmin.TabIndex = 2;
            this.tabAdmin.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtConnection);
            this.tabPage1.Controls.Add(this.btnUnlockConnectionText);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(701, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtQuery);
            this.tabPage2.Controls.Add(this.btnUnlockQueryText);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(701, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Query";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtLocalFolder);
            this.tabPage3.Controls.Add(this.txtOutputFile);
            this.tabPage3.Controls.Add(this.btnUnlockOutputFileText);
            this.tabPage3.Controls.Add(this.btnCreateData);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(701, 349);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Output";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtLocalFolder
            // 
            this.txtLocalFolder.Location = new System.Drawing.Point(3, 3);
            this.txtLocalFolder.Name = "txtLocalFolder";
            this.txtLocalFolder.ReadOnly = true;
            this.txtLocalFolder.Size = new System.Drawing.Size(297, 20);
            this.txtLocalFolder.TabIndex = 0;
            this.txtLocalFolder.Text = "D:\\Projects\\ShelfTalkers\\Admin\\bin\\Release";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnUnlockFTPCredentials);
            this.tabPage4.Controls.Add(this.lblSlash);
            this.tabPage4.Controls.Add(this.txtFTPHost);
            this.tabPage4.Controls.Add(this.txtFTPPassword);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.txtFTPUsername);
            this.tabPage4.Controls.Add(this.lblFTPUsername);
            this.tabPage4.Controls.Add(this.btnUnlockFTPLocation);
            this.tabPage4.Controls.Add(this.txtFTPLocation);
            this.tabPage4.Controls.Add(this.btnUpload);
            this.tabPage4.Controls.Add(this.lblStatus);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(701, 349);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "FTP";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnUnlockFTPCredentials
            // 
            this.btnUnlockFTPCredentials.Location = new System.Drawing.Point(330, 79);
            this.btnUnlockFTPCredentials.Name = "btnUnlockFTPCredentials";
            this.btnUnlockFTPCredentials.Size = new System.Drawing.Size(75, 23);
            this.btnUnlockFTPCredentials.TabIndex = 8;
            this.btnUnlockFTPCredentials.Text = "Unlock";
            this.btnUnlockFTPCredentials.UseVisualStyleBackColor = true;
            this.btnUnlockFTPCredentials.Click += new System.EventHandler(this.btnUnlockFTPCredentials_Click);
            // 
            // lblSlash
            // 
            this.lblSlash.Location = new System.Drawing.Point(344, 6);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(13, 17);
            this.lblSlash.TabIndex = 1;
            this.lblSlash.Text = "/";
            // 
            // txtFTPHost
            // 
            this.txtFTPHost.Location = new System.Drawing.Point(6, 3);
            this.txtFTPHost.Name = "txtFTPHost";
            this.txtFTPHost.ReadOnly = true;
            this.txtFTPHost.Size = new System.Drawing.Size(332, 20);
            this.txtFTPHost.TabIndex = 0;
            // 
            // txtFTPPassword
            // 
            this.txtFTPPassword.Location = new System.Drawing.Point(171, 81);
            this.txtFTPPassword.Name = "txtFTPPassword";
            this.txtFTPPassword.ReadOnly = true;
            this.txtFTPPassword.Size = new System.Drawing.Size(153, 20);
            this.txtFTPPassword.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(168, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "FTP Password";
            // 
            // txtFTPUsername
            // 
            this.txtFTPUsername.Location = new System.Drawing.Point(3, 81);
            this.txtFTPUsername.Name = "txtFTPUsername";
            this.txtFTPUsername.ReadOnly = true;
            this.txtFTPUsername.Size = new System.Drawing.Size(153, 20);
            this.txtFTPUsername.TabIndex = 6;
            // 
            // lblFTPUsername
            // 
            this.lblFTPUsername.Location = new System.Drawing.Point(3, 58);
            this.lblFTPUsername.Name = "lblFTPUsername";
            this.lblFTPUsername.Size = new System.Drawing.Size(78, 20);
            this.lblFTPUsername.TabIndex = 4;
            this.lblFTPUsername.Text = "FTP Username";
            // 
            // btnUnlockFTPLocation
            // 
            this.btnUnlockFTPLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnlockFTPLocation.Location = new System.Drawing.Point(623, 1);
            this.btnUnlockFTPLocation.Name = "btnUnlockFTPLocation";
            this.btnUnlockFTPLocation.Size = new System.Drawing.Size(75, 23);
            this.btnUnlockFTPLocation.TabIndex = 3;
            this.btnUnlockFTPLocation.Text = "Unlock";
            this.btnUnlockFTPLocation.UseVisualStyleBackColor = true;
            this.btnUnlockFTPLocation.Click += new System.EventHandler(this.btnUnlockFTPLocation_Click);
            // 
            // txtFTPLocation
            // 
            this.txtFTPLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFTPLocation.Location = new System.Drawing.Point(363, 3);
            this.txtFTPLocation.Name = "txtFTPLocation";
            this.txtFTPLocation.ReadOnly = true;
            this.txtFTPLocation.Size = new System.Drawing.Size(254, 20);
            this.txtFTPLocation.TabIndex = 2;
            // 
            // btnCreateAndUpload
            // 
            this.btnCreateAndUpload.Location = new System.Drawing.Point(72, 12);
            this.btnCreateAndUpload.Name = "btnCreateAndUpload";
            this.btnCreateAndUpload.Size = new System.Drawing.Size(129, 23);
            this.btnCreateAndUpload.TabIndex = 0;
            this.btnCreateAndUpload.Text = "Create and Upload";
            this.btnCreateAndUpload.UseVisualStyleBackColor = true;
            this.btnCreateAndUpload.Click += new System.EventHandler(this.btnCreateAndUpload_Click);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Location = new System.Drawing.Point(72, 60);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(129, 23);
            this.btnAdvanced.TabIndex = 1;
            this.btnAdvanced.Text = "Advanced...";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 486);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.btnCreateAndUpload);
            this.Controls.Add(this.tabAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LabelMaker Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabAdmin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateData;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.TextBox txtConnection;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Button btnUnlockConnectionText;
        private System.Windows.Forms.Button btnUnlockQueryText;
        private System.Windows.Forms.Button btnUnlockOutputFileText;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnUnlockFTPLocation;
        private System.Windows.Forms.TextBox txtFTPLocation;
        private System.Windows.Forms.TextBox txtFTPPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFTPUsername;
        private System.Windows.Forms.Label lblFTPUsername;
        private System.Windows.Forms.TextBox txtFTPHost;
        private System.Windows.Forms.Label lblSlash;
        private System.Windows.Forms.Button btnUnlockFTPCredentials;
        private System.Windows.Forms.TextBox txtLocalFolder;
        private System.Windows.Forms.Button btnCreateAndUpload;
        private System.Windows.Forms.Button btnAdvanced;
    }
}

