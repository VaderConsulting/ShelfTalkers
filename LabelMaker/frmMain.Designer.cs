namespace LabelMaker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvwMain = new System.Windows.Forms.ListView();
            this.imlLabels = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvwInput = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grpAutomatic = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.chkOnlyDisplayCatalogItems = new System.Windows.Forms.CheckBox();
            this.chkOnlyDisplayShelfTalkerItems = new System.Windows.Forms.CheckBox();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.cmbFilterValue = new System.Windows.Forms.ComboBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbFilterField = new System.Windows.Forms.ComboBox();
            this.radSearch = new System.Windows.Forms.RadioButton();
            this.radFilter = new System.Windows.Forms.RadioButton();
            this.splitSelection = new System.Windows.Forms.SplitContainer();
            this.lblSource = new System.Windows.Forms.Label();
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            this.lblSelection = new System.Windows.Forms.Label();
            this.dgvSelection = new System.Windows.Forms.DataGridView();
            this.radNone = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnPreview = new System.Windows.Forms.Button();
            this.lblOverview = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grpAutomatic.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.splitSelection.Panel1.SuspendLayout();
            this.splitSelection.Panel2.SuspendLayout();
            this.splitSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelection)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Controls.Add(this.tabPage5);
            this.tabMain.Controls.Add(this.tabPage4);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(767, 365);
            this.tabMain.TabIndex = 0;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            this.tabMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabMain_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvwMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(759, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Size";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvwMain
            // 
            this.lvwMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwMain.LargeImageList = this.imlLabels;
            this.lvwMain.Location = new System.Drawing.Point(6, 6);
            this.lvwMain.MultiSelect = false;
            this.lvwMain.Name = "lvwMain";
            this.lvwMain.Size = new System.Drawing.Size(725, 330);
            this.lvwMain.TabIndex = 0;
            this.lvwMain.TileSize = new System.Drawing.Size(350, 320);
            this.lvwMain.UseCompatibleStateImageBehavior = false;
            this.lvwMain.View = System.Windows.Forms.View.Tile;
            this.lvwMain.SelectedIndexChanged += new System.EventHandler(this.lvwMain_SelectedIndexChanged);
            // 
            // imlLabels
            // 
            this.imlLabels.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlLabels.ImageStream")));
            this.imlLabels.TransparentColor = System.Drawing.Color.Transparent;
            this.imlLabels.Images.SetKeyName(0, "Savemor 1x1 Landscape.jpg");
            this.imlLabels.Images.SetKeyName(1, "Savemor 1x1 Portrait.jpg");
            this.imlLabels.Images.SetKeyName(2, "Savemor 3x2 Portrait.jpg");
            this.imlLabels.Images.SetKeyName(3, "Savemor 4x3 Portrait.jpg");
            this.imlLabels.Images.SetKeyName(4, "server.png");
            this.imlLabels.Images.SetKeyName(5, "compkey.gif");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvwInput);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(759, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data input type";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvwInput
            // 
            this.lvwInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwInput.LargeImageList = this.imlLabels;
            this.lvwInput.Location = new System.Drawing.Point(6, 6);
            this.lvwInput.Name = "lvwInput";
            this.lvwInput.Size = new System.Drawing.Size(728, 330);
            this.lvwInput.TabIndex = 0;
            this.lvwInput.TileSize = new System.Drawing.Size(350, 320);
            this.lvwInput.UseCompatibleStateImageBehavior = false;
            this.lvwInput.View = System.Windows.Forms.View.Tile;
            this.lvwInput.SelectedIndexChanged += new System.EventHandler(this.lvwInput_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grpAutomatic);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(759, 339);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Data source";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grpAutomatic
            // 
            this.grpAutomatic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAutomatic.Controls.Add(this.btnOpen);
            this.grpAutomatic.Controls.Add(this.lstInfo);
            this.grpAutomatic.Controls.Add(this.lblInfo);
            this.grpAutomatic.Controls.Add(this.btnBrowse);
            this.grpAutomatic.Controls.Add(this.txtPath);
            this.grpAutomatic.Controls.Add(this.lblPath);
            this.grpAutomatic.Location = new System.Drawing.Point(3, 3);
            this.grpAutomatic.Name = "grpAutomatic";
            this.grpAutomatic.Size = new System.Drawing.Size(731, 333);
            this.grpAutomatic.TabIndex = 0;
            this.grpAutomatic.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(650, 38);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lstInfo
            // 
            this.lstInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.Location = new System.Drawing.Point(9, 86);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(716, 238);
            this.lstInfo.TabIndex = 5;
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(6, 66);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(85, 17);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "File Information";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(611, 38);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(33, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(9, 40);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(596, 20);
            this.txtPath.TabIndex = 1;
            // 
            // lblPath
            // 
            this.lblPath.Location = new System.Drawing.Point(6, 16);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(99, 21);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Path to data file";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.chkOnlyDisplayCatalogItems);
            this.tabPage5.Controls.Add(this.chkOnlyDisplayShelfTalkerItems);
            this.tabPage5.Controls.Add(this.btnRemoveAll);
            this.tabPage5.Controls.Add(this.btnRemove);
            this.tabPage5.Controls.Add(this.btnCopy);
            this.tabPage5.Controls.Add(this.btnSelectAll);
            this.tabPage5.Controls.Add(this.btnSearch);
            this.tabPage5.Controls.Add(this.btnApplyFilter);
            this.tabPage5.Controls.Add(this.cmbFilterValue);
            this.tabPage5.Controls.Add(this.cmbSearch);
            this.tabPage5.Controls.Add(this.txtSearch);
            this.tabPage5.Controls.Add(this.cmbFilterField);
            this.tabPage5.Controls.Add(this.radSearch);
            this.tabPage5.Controls.Add(this.radFilter);
            this.tabPage5.Controls.Add(this.splitSelection);
            this.tabPage5.Controls.Add(this.radNone);
            this.tabPage5.Controls.Add(this.radAll);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(759, 339);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Selection";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // chkOnlyDisplayCatalogItems
            // 
            this.chkOnlyDisplayCatalogItems.AutoSize = true;
            this.chkOnlyDisplayCatalogItems.Checked = true;
            this.chkOnlyDisplayCatalogItems.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOnlyDisplayCatalogItems.Location = new System.Drawing.Point(586, 29);
            this.chkOnlyDisplayCatalogItems.Name = "chkOnlyDisplayCatalogItems";
            this.chkOnlyDisplayCatalogItems.Size = new System.Drawing.Size(150, 17);
            this.chkOnlyDisplayCatalogItems.TabIndex = 16;
            this.chkOnlyDisplayCatalogItems.Text = "Only Display Catalog items";
            this.chkOnlyDisplayCatalogItems.UseVisualStyleBackColor = true;
            this.chkOnlyDisplayCatalogItems.CheckedChanged += new System.EventHandler(this.chkOnlyDisplayCatalogItems_CheckedChanged);
            // 
            // chkOnlyDisplayShelfTalkerItems
            // 
            this.chkOnlyDisplayShelfTalkerItems.AutoSize = true;
            this.chkOnlyDisplayShelfTalkerItems.Checked = true;
            this.chkOnlyDisplayShelfTalkerItems.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOnlyDisplayShelfTalkerItems.Location = new System.Drawing.Point(586, 7);
            this.chkOnlyDisplayShelfTalkerItems.Name = "chkOnlyDisplayShelfTalkerItems";
            this.chkOnlyDisplayShelfTalkerItems.Size = new System.Drawing.Size(164, 17);
            this.chkOnlyDisplayShelfTalkerItems.TabIndex = 15;
            this.chkOnlyDisplayShelfTalkerItems.Text = "Only Display Shelftalker items";
            this.chkOnlyDisplayShelfTalkerItems.UseVisualStyleBackColor = true;
            this.chkOnlyDisplayShelfTalkerItems.CheckedChanged += new System.EventHandler(this.chkOnlyDisplayShelfTalkerItems_CheckedChanged);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAll.Enabled = false;
            this.btnRemoveAll.Location = new System.Drawing.Point(600, 313);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAll.TabIndex = 13;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(681, 313);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopy.Enabled = false;
            this.btnCopy.Location = new System.Drawing.Point(85, 313);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 12;
            this.btnCopy.Text = "Add";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectAll.Location = new System.Drawing.Point(4, 313);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 11;
            this.btnSelectAll.Text = "Add All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(504, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Enabled = false;
            this.btnApplyFilter.Location = new System.Drawing.Point(504, 2);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(75, 23);
            this.btnApplyFilter.TabIndex = 4;
            this.btnApplyFilter.Text = "Apply Filter";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // cmbFilterValue
            // 
            this.cmbFilterValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterValue.Enabled = false;
            this.cmbFilterValue.FormattingEnabled = true;
            this.cmbFilterValue.Location = new System.Drawing.Point(316, 4);
            this.cmbFilterValue.Name = "cmbFilterValue";
            this.cmbFilterValue.Size = new System.Drawing.Size(182, 21);
            this.cmbFilterValue.Sorted = true;
            this.cmbFilterValue.TabIndex = 3;
            this.cmbFilterValue.SelectedIndexChanged += new System.EventHandler(this.cmbFilterValue_SelectedIndexChanged);
            // 
            // cmbSearch
            // 
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.Enabled = false;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(128, 31);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(182, 21);
            this.cmbSearch.Sorted = true;
            this.cmbSearch.TabIndex = 8;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Location = new System.Drawing.Point(316, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(182, 20);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbFilterField
            // 
            this.cmbFilterField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterField.Enabled = false;
            this.cmbFilterField.FormattingEnabled = true;
            this.cmbFilterField.Location = new System.Drawing.Point(128, 4);
            this.cmbFilterField.Name = "cmbFilterField";
            this.cmbFilterField.Size = new System.Drawing.Size(182, 21);
            this.cmbFilterField.Sorted = true;
            this.cmbFilterField.TabIndex = 2;
            this.cmbFilterField.SelectedIndexChanged += new System.EventHandler(this.cmbFilterField_SelectedIndexChanged);
            // 
            // radSearch
            // 
            this.radSearch.AutoSize = true;
            this.radSearch.Location = new System.Drawing.Point(63, 31);
            this.radSearch.Name = "radSearch";
            this.radSearch.Size = new System.Drawing.Size(59, 17);
            this.radSearch.TabIndex = 6;
            this.radSearch.Text = "Search";
            this.radSearch.UseVisualStyleBackColor = true;
            this.radSearch.CheckedChanged += new System.EventHandler(this.radSearch_CheckedChanged);
            // 
            // radFilter
            // 
            this.radFilter.AutoSize = true;
            this.radFilter.Location = new System.Drawing.Point(63, 4);
            this.radFilter.Name = "radFilter";
            this.radFilter.Size = new System.Drawing.Size(47, 17);
            this.radFilter.TabIndex = 1;
            this.radFilter.Text = "Filter";
            this.radFilter.UseVisualStyleBackColor = true;
            this.radFilter.CheckedChanged += new System.EventHandler(this.radFilter_CheckedChanged);
            // 
            // splitSelection
            // 
            this.splitSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitSelection.Location = new System.Drawing.Point(4, 58);
            this.splitSelection.Name = "splitSelection";
            // 
            // splitSelection.Panel1
            // 
            this.splitSelection.Panel1.Controls.Add(this.lblSource);
            this.splitSelection.Panel1.Controls.Add(this.dgvPreview);
            // 
            // splitSelection.Panel2
            // 
            this.splitSelection.Panel2.Controls.Add(this.lblSelection);
            this.splitSelection.Panel2.Controls.Add(this.dgvSelection);
            this.splitSelection.Size = new System.Drawing.Size(752, 251);
            this.splitSelection.SplitterDistance = 365;
            this.splitSelection.TabIndex = 10;
            // 
            // lblSource
            // 
            this.lblSource.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSource.Location = new System.Drawing.Point(0, 0);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(365, 16);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source";
            this.lblSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPreview
            // 
            this.dgvPreview.AllowUserToAddRows = false;
            this.dgvPreview.AllowUserToDeleteRows = false;
            this.dgvPreview.AllowUserToOrderColumns = true;
            this.dgvPreview.AllowUserToResizeRows = false;
            this.dgvPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPreview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreview.Location = new System.Drawing.Point(0, 19);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreview.Size = new System.Drawing.Size(365, 232);
            this.dgvPreview.TabIndex = 1;
            this.dgvPreview.DataSourceChanged += new System.EventHandler(this.dgvPreview_DataSourceChanged);
            this.dgvPreview.SelectionChanged += new System.EventHandler(this.dgvPreview_SelectionChanged);
            // 
            // lblSelection
            // 
            this.lblSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSelection.Location = new System.Drawing.Point(0, 0);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(383, 16);
            this.lblSelection.TabIndex = 0;
            this.lblSelection.Text = "Selection";
            this.lblSelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSelection
            // 
            this.dgvSelection.AllowUserToAddRows = false;
            this.dgvSelection.AllowUserToDeleteRows = false;
            this.dgvSelection.AllowUserToOrderColumns = true;
            this.dgvSelection.AllowUserToResizeRows = false;
            this.dgvSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSelection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSelection.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelection.Location = new System.Drawing.Point(0, 19);
            this.dgvSelection.Name = "dgvSelection";
            this.dgvSelection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelection.Size = new System.Drawing.Size(383, 232);
            this.dgvSelection.TabIndex = 1;
            this.dgvSelection.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSelection_RowsAdded);
            this.dgvSelection.SelectionChanged += new System.EventHandler(this.dgvSelection_SelectionChanged);
            // 
            // radNone
            // 
            this.radNone.AutoSize = true;
            this.radNone.Location = new System.Drawing.Point(4, 31);
            this.radNone.Name = "radNone";
            this.radNone.Size = new System.Drawing.Size(51, 17);
            this.radNone.TabIndex = 5;
            this.radNone.Text = "None";
            this.radNone.UseVisualStyleBackColor = true;
            this.radNone.CheckedChanged += new System.EventHandler(this.radNone_CheckedChanged);
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Location = new System.Drawing.Point(4, 4);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(36, 17);
            this.radAll.TabIndex = 0;
            this.radAll.Text = "All";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnPreview);
            this.tabPage4.Controls.Add(this.lblOverview);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(759, 339);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Overview";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.Location = new System.Drawing.Point(659, 313);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 1;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // lblOverview
            // 
            this.lblOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOverview.Location = new System.Drawing.Point(3, 0);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(731, 339);
            this.lblOverview.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(700, 383);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(619, 383);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 418);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Label Maker";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.grpAutomatic.ResumeLayout(false);
            this.grpAutomatic.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.splitSelection.Panel1.ResumeLayout(false);
            this.splitSelection.Panel2.ResumeLayout(false);
            this.splitSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelection)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lvwMain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imlLabels;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ListView lvwInput;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox grpAutomatic;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.ListBox lstInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblOverview;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvPreview;
        private System.Windows.Forms.SplitContainer splitSelection;
        private System.Windows.Forms.DataGridView dgvSelection;
        private System.Windows.Forms.RadioButton radNone;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.RadioButton radFilter;
        private System.Windows.Forms.ComboBox cmbFilterValue;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbFilterField;
        private System.Windows.Forms.RadioButton radSearch;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.CheckBox chkOnlyDisplayShelfTalkerItems;
        private System.Windows.Forms.CheckBox chkOnlyDisplayCatalogItems;

    }
}

