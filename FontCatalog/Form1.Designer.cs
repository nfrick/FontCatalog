namespace FontCatalog {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSearchFileName = new System.Windows.Forms.Button();
            this.buttonSymbol = new System.Windows.Forms.Button();
            this.buttonSearchFontName = new System.Windows.Forms.Button();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.buttonSearchFamily = new System.Windows.Forms.Button();
            this.lvSearch = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tvFonts = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lvSelected = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tlpDisplayFont = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelBaseline = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelStretch = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelStyle = new System.Windows.Forms.Label();
            this.labelCapsHeight = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelGlyphs = new System.Windows.Forms.Label();
            this.labelXHeight = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelFamily = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelSymbol = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelManufacturerName = new System.Windows.Forms.Label();
            this.labelTrademark = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonColorSwap = new System.Windows.Forms.Button();
            this.buttonBackground = new System.Windows.Forms.Button();
            this.buttonForeground = new System.Windows.Forms.Button();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxSample = new System.Windows.Forms.TextBox();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSelect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUncheck = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeselect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRenameFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCataloger = new System.Windows.Forms.ToolStripButton();
            this.CD = new System.Windows.Forms.ColorDialog();
            this.toolStripButtonExpand = new System.Windows.Forms.ToolStripButton();
            this.tlpMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tlpDisplayFont.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            this.panel3.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpMain.Controls.Add(this.tabControl1, 0, 0);
            this.tlpMain.Controls.Add(this.tlpDisplayFont, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1274, 712);
            this.tlpMain.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(376, 706);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(368, 665);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lvSearch, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(362, 659);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.26966F));
            this.tableLayoutPanel5.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.51366F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(356, 88);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSearchFileName);
            this.panel1.Controls.Add(this.buttonSymbol);
            this.panel1.Controls.Add(this.buttonSearchFontName);
            this.panel1.Controls.Add(this.textBoxTarget);
            this.panel1.Controls.Add(this.buttonSearchFamily);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 82);
            this.panel1.TabIndex = 4;
            // 
            // buttonSearchFileName
            // 
            this.buttonSearchFileName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchFileName.Location = new System.Drawing.Point(177, 43);
            this.buttonSearchFileName.Name = "buttonSearchFileName";
            this.buttonSearchFileName.Size = new System.Drawing.Size(81, 34);
            this.buttonSearchFileName.TabIndex = 5;
            this.buttonSearchFileName.Text = "File";
            this.buttonSearchFileName.UseVisualStyleBackColor = true;
            this.buttonSearchFileName.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSymbol
            // 
            this.buttonSymbol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSymbol.Location = new System.Drawing.Point(264, 43);
            this.buttonSymbol.Name = "buttonSymbol";
            this.buttonSymbol.Size = new System.Drawing.Size(81, 34);
            this.buttonSymbol.TabIndex = 5;
            this.buttonSymbol.Text = "Symbols";
            this.buttonSymbol.UseVisualStyleBackColor = true;
            this.buttonSymbol.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSearchFontName
            // 
            this.buttonSearchFontName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchFontName.Location = new System.Drawing.Point(90, 43);
            this.buttonSearchFontName.Name = "buttonSearchFontName";
            this.buttonSearchFontName.Size = new System.Drawing.Size(81, 34);
            this.buttonSearchFontName.TabIndex = 4;
            this.buttonSearchFontName.Text = "Name";
            this.buttonSearchFontName.UseVisualStyleBackColor = true;
            this.buttonSearchFontName.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Location = new System.Drawing.Point(3, 3);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.Size = new System.Drawing.Size(168, 34);
            this.textBoxTarget.TabIndex = 1;
            this.textBoxTarget.Text = "Segoe";
            // 
            // buttonSearchFamily
            // 
            this.buttonSearchFamily.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchFamily.Location = new System.Drawing.Point(3, 43);
            this.buttonSearchFamily.Name = "buttonSearchFamily";
            this.buttonSearchFamily.Size = new System.Drawing.Size(81, 34);
            this.buttonSearchFamily.TabIndex = 3;
            this.buttonSearchFamily.Text = "Family";
            this.buttonSearchFamily.UseVisualStyleBackColor = true;
            this.buttonSearchFamily.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // lvSearch
            // 
            this.lvSearch.CheckBoxes = true;
            this.lvSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup1";
            this.lvSearch.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3});
            this.lvSearch.Location = new System.Drawing.Point(3, 97);
            this.lvSearch.MultiSelect = false;
            this.lvSearch.Name = "lvSearch";
            this.lvSearch.Size = new System.Drawing.Size(356, 559);
            this.lvSearch.SmallImageList = this.imageList1;
            this.lvSearch.TabIndex = 1;
            this.lvSearch.UseCompatibleStateImageBehavior = false;
            this.lvSearch.View = System.Windows.Forms.View.Details;
            this.lvSearch.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvFonts_DrawItem);
            this.lvSearch.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView_ItemChecked);
            this.lvSearch.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Font";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Glyphs";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Version";
            this.columnHeader3.Width = 80;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder-green-font2-icon.png");
            this.imageList1.Images.SetKeyName(1, "folder-orange-font2-icon.png");
            this.imageList1.Images.SetKeyName(2, "OT.png");
            this.imageList1.Images.SetKeyName(3, "TT.png");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tvFonts);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(368, 665);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Folder View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tvFonts
            // 
            this.tvFonts.CheckBoxes = true;
            this.tvFonts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFonts.ImageIndex = 0;
            this.tvFonts.ImageList = this.imageList1;
            this.tvFonts.Location = new System.Drawing.Point(3, 3);
            this.tvFonts.Name = "tvFonts";
            this.tvFonts.SelectedImageIndex = 0;
            this.tvFonts.Size = new System.Drawing.Size(362, 659);
            this.tvFonts.TabIndex = 0;
            this.tvFonts.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvFonts_AfterCheck);
            this.tvFonts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFonts_AfterSelect);
            this.tvFonts.DoubleClick += new System.EventHandler(this.tvFonts_DoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvSelected);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(368, 677);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Selected";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lvSelected
            // 
            this.lvSelected.CheckBoxes = true;
            this.lvSelected.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.lvSelected.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lvSelected.Location = new System.Drawing.Point(3, 3);
            this.lvSelected.MultiSelect = false;
            this.lvSelected.Name = "lvSelected";
            this.lvSelected.Size = new System.Drawing.Size(362, 671);
            this.lvSelected.SmallImageList = this.imageList1;
            this.lvSelected.TabIndex = 2;
            this.lvSelected.UseCompatibleStateImageBehavior = false;
            this.lvSelected.View = System.Windows.Forms.View.Details;
            this.lvSelected.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView_ItemChecked);
            this.lvSelected.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Font";
            this.columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Glyphs";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Version";
            this.columnHeader6.Width = 80;
            // 
            // tlpDisplayFont
            // 
            this.tlpDisplayFont.ColumnCount = 1;
            this.tlpDisplayFont.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDisplayFont.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tlpDisplayFont.Controls.Add(this.panel2, 0, 1);
            this.tlpDisplayFont.Controls.Add(this.panel3, 0, 0);
            this.tlpDisplayFont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDisplayFont.Location = new System.Drawing.Point(385, 3);
            this.tlpDisplayFont.Name = "tlpDisplayFont";
            this.tlpDisplayFont.RowCount = 3;
            this.tlpDisplayFont.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpDisplayFont.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDisplayFont.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpDisplayFont.Size = new System.Drawing.Size(886, 706);
            this.tlpDisplayFont.TabIndex = 1;
            this.tlpDisplayFont.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.labelWeight, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelDescription, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.labelBaseline, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDescription, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.labelStretch, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelHeight, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelStyle, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelCapsHeight, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelPath, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelGlyphs, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelXHeight, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelName, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelFamily, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelVersion, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelSymbol, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelDate, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelSize, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelManufacturerName, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelTrademark, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 303);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(880, 400);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.BackColor = System.Drawing.SystemColors.Control;
            this.labelWeight.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeight.Location = new System.Drawing.Point(3, 105);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(96, 32);
            this.labelWeight.TabIndex = 9;
            this.labelWeight.Text = "Weigth:";
            this.labelWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(3, 245);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(141, 32);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Description:";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBaseline
            // 
            this.labelBaseline.AutoSize = true;
            this.labelBaseline.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaseline.Location = new System.Drawing.Point(223, 140);
            this.labelBaseline.Name = "labelBaseline";
            this.labelBaseline.Size = new System.Drawing.Size(108, 32);
            this.labelBaseline.TabIndex = 0;
            this.labelBaseline.Text = "Baseline:";
            this.labelBaseline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel2.SetColumnSpan(this.textBoxDescription, 4);
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(3, 283);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(874, 114);
            this.textBoxDescription.TabIndex = 12;
            // 
            // labelStretch
            // 
            this.labelStretch.AutoSize = true;
            this.labelStretch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStretch.Location = new System.Drawing.Point(443, 105);
            this.labelStretch.Name = "labelStretch";
            this.labelStretch.Size = new System.Drawing.Size(94, 32);
            this.labelStretch.TabIndex = 4;
            this.labelStretch.Text = "Stretch:";
            this.labelStretch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.Location = new System.Drawing.Point(3, 140);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(92, 32);
            this.labelHeight.TabIndex = 3;
            this.labelHeight.Text = "Heigth:";
            this.labelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStyle
            // 
            this.labelStyle.AutoSize = true;
            this.labelStyle.BackColor = System.Drawing.SystemColors.Control;
            this.labelStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStyle.Location = new System.Drawing.Point(223, 105);
            this.labelStyle.Name = "labelStyle";
            this.labelStyle.Size = new System.Drawing.Size(71, 32);
            this.labelStyle.TabIndex = 5;
            this.labelStyle.Text = "Style:";
            this.labelStyle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCapsHeight
            // 
            this.labelCapsHeight.AutoSize = true;
            this.labelCapsHeight.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapsHeight.Location = new System.Drawing.Point(443, 140);
            this.labelCapsHeight.Name = "labelCapsHeight";
            this.labelCapsHeight.Size = new System.Drawing.Size(150, 32);
            this.labelCapsHeight.TabIndex = 1;
            this.labelCapsHeight.Text = "Caps Height:";
            this.labelCapsHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.labelPath, 4);
            this.labelPath.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPath.Location = new System.Drawing.Point(3, 0);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(61, 32);
            this.labelPath.TabIndex = 15;
            this.labelPath.Text = "Path";
            this.labelPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGlyphs
            // 
            this.labelGlyphs.AutoSize = true;
            this.labelGlyphs.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGlyphs.Location = new System.Drawing.Point(663, 105);
            this.labelGlyphs.Name = "labelGlyphs";
            this.labelGlyphs.Size = new System.Drawing.Size(92, 32);
            this.labelGlyphs.TabIndex = 2;
            this.labelGlyphs.Text = "Glyphs:";
            this.labelGlyphs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelXHeight
            // 
            this.labelXHeight.AutoSize = true;
            this.labelXHeight.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXHeight.Location = new System.Drawing.Point(663, 140);
            this.labelXHeight.Name = "labelXHeight";
            this.labelXHeight.Size = new System.Drawing.Size(113, 32);
            this.labelXHeight.TabIndex = 18;
            this.labelXHeight.Text = "X Height:";
            this.labelXHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(3, 70);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(84, 32);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "Name:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFamily
            // 
            this.labelFamily.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.labelFamily, 2);
            this.labelFamily.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFamily.Location = new System.Drawing.Point(223, 70);
            this.labelFamily.Name = "labelFamily";
            this.labelFamily.Size = new System.Drawing.Size(88, 32);
            this.labelFamily.TabIndex = 19;
            this.labelFamily.Text = "Family:";
            this.labelFamily.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(443, 35);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(98, 32);
            this.labelVersion.TabIndex = 17;
            this.labelVersion.Text = "Version:";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSymbol
            // 
            this.labelSymbol.AutoSize = true;
            this.labelSymbol.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSymbol.Location = new System.Drawing.Point(663, 35);
            this.labelSymbol.Name = "labelSymbol";
            this.labelSymbol.Size = new System.Drawing.Size(99, 32);
            this.labelSymbol.TabIndex = 6;
            this.labelSymbol.Text = "Symbol:";
            this.labelSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(3, 35);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(70, 32);
            this.labelDate.TabIndex = 21;
            this.labelDate.Text = "Date:";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(223, 35);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(63, 32);
            this.labelSize.TabIndex = 22;
            this.labelSize.Text = "Size:";
            this.labelSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelManufacturerName
            // 
            this.labelManufacturerName.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.labelManufacturerName, 4);
            this.labelManufacturerName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManufacturerName.Location = new System.Drawing.Point(3, 175);
            this.labelManufacturerName.Name = "labelManufacturerName";
            this.labelManufacturerName.Size = new System.Drawing.Size(164, 32);
            this.labelManufacturerName.TabIndex = 11;
            this.labelManufacturerName.Text = "Manufacturer:";
            this.labelManufacturerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTrademark
            // 
            this.labelTrademark.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.labelTrademark, 4);
            this.labelTrademark.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrademark.Location = new System.Drawing.Point(3, 210);
            this.labelTrademark.Name = "labelTrademark";
            this.labelTrademark.Size = new System.Drawing.Size(131, 32);
            this.labelTrademark.TabIndex = 7;
            this.labelTrademark.Text = "Trademark:";
            this.labelTrademark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonColorSwap);
            this.panel2.Controls.Add(this.buttonBackground);
            this.panel2.Controls.Add(this.buttonForeground);
            this.panel2.Controls.Add(this.trackBarSize);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 24);
            this.panel2.TabIndex = 5;
            // 
            // buttonColorSwap
            // 
            this.buttonColorSwap.BackColor = System.Drawing.Color.Transparent;
            this.buttonColorSwap.Font = new System.Drawing.Font("Wingdings", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonColorSwap.Location = new System.Drawing.Point(821, 1);
            this.buttonColorSwap.Name = "buttonColorSwap";
            this.buttonColorSwap.Size = new System.Drawing.Size(27, 23);
            this.buttonColorSwap.TabIndex = 9;
            this.buttonColorSwap.Text = "ó";
            this.buttonColorSwap.UseVisualStyleBackColor = false;
            this.buttonColorSwap.Click += new System.EventHandler(this.buttonColorSwap_Click);
            // 
            // buttonBackground
            // 
            this.buttonBackground.BackColor = System.Drawing.Color.White;
            this.buttonBackground.Location = new System.Drawing.Point(847, 0);
            this.buttonBackground.Name = "buttonBackground";
            this.buttonBackground.Size = new System.Drawing.Size(27, 23);
            this.buttonBackground.TabIndex = 8;
            this.buttonBackground.UseVisualStyleBackColor = false;
            this.buttonBackground.Click += new System.EventHandler(this.buttonBackground_Click);
            // 
            // buttonForeground
            // 
            this.buttonForeground.BackColor = System.Drawing.Color.Black;
            this.buttonForeground.Location = new System.Drawing.Point(795, 1);
            this.buttonForeground.Name = "buttonForeground";
            this.buttonForeground.Size = new System.Drawing.Size(27, 23);
            this.buttonForeground.TabIndex = 7;
            this.buttonForeground.UseVisualStyleBackColor = false;
            this.buttonForeground.Click += new System.EventHandler(this.buttonForeground_Click);
            // 
            // trackBarSize
            // 
            this.trackBarSize.Location = new System.Drawing.Point(3, -16);
            this.trackBarSize.Maximum = 72;
            this.trackBarSize.Minimum = 6;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(785, 56);
            this.trackBarSize.TabIndex = 6;
            this.trackBarSize.Value = 36;
            this.trackBarSize.ValueChanged += new System.EventHandler(this.trackBarSize_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.textBoxSample);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(6);
            this.panel3.Size = new System.Drawing.Size(880, 264);
            this.panel3.TabIndex = 6;
            // 
            // textBoxSample
            // 
            this.textBoxSample.BackColor = System.Drawing.Color.White;
            this.textBoxSample.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSample.Location = new System.Drawing.Point(6, 6);
            this.textBoxSample.Multiline = true;
            this.textBoxSample.Name = "textBoxSample";
            this.textBoxSample.ReadOnly = true;
            this.textBoxSample.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSample.Size = new System.Drawing.Size(868, 252);
            this.textBoxSample.TabIndex = 5;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tlpMain);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1274, 712);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1274, 739);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSelect,
            this.toolStripButtonUncheck,
            this.toolStripButtonDeselect,
            this.toolStripButtonCataloger,
            this.toolStripButtonDelete,
            this.toolStripButtonRenameFile,
            this.toolStripButtonExpand});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(567, 27);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButtonSelect
            // 
            this.toolStripButtonSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStripButtonSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSelect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSelect.Image")));
            this.toolStripButtonSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSelect.Name = "toolStripButtonSelect";
            this.toolStripButtonSelect.Size = new System.Drawing.Size(53, 24);
            this.toolStripButtonSelect.Text = "Select";
            this.toolStripButtonSelect.Visible = false;
            this.toolStripButtonSelect.Click += new System.EventHandler(this.toolStripButtonSelect_Click);
            // 
            // toolStripButtonUncheck
            // 
            this.toolStripButtonUncheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolStripButtonUncheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUncheck.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUncheck.Image")));
            this.toolStripButtonUncheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUncheck.Name = "toolStripButtonUncheck";
            this.toolStripButtonUncheck.Size = new System.Drawing.Size(68, 24);
            this.toolStripButtonUncheck.Text = "Uncheck";
            this.toolStripButtonUncheck.Visible = false;
            this.toolStripButtonUncheck.Click += new System.EventHandler(this.toolStripButtonUncheck_Click);
            // 
            // toolStripButtonDeselect
            // 
            this.toolStripButtonDeselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStripButtonDeselect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDeselect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeselect.Image")));
            this.toolStripButtonDeselect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeselect.Name = "toolStripButtonDeselect";
            this.toolStripButtonDeselect.Size = new System.Drawing.Size(70, 24);
            this.toolStripButtonDeselect.Text = "Deselect";
            this.toolStripButtonDeselect.Visible = false;
            this.toolStripButtonDeselect.Click += new System.EventHandler(this.toolStripButtonDeselect_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.BackColor = System.Drawing.Color.Red;
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(58, 24);
            this.toolStripButtonDelete.Text = "Delete";
            this.toolStripButtonDelete.Visible = false;
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripButtonRenameFile
            // 
            this.toolStripButtonRenameFile.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStripButtonRenameFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRenameFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonRenameFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripButtonRenameFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRenameFile.Image")));
            this.toolStripButtonRenameFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRenameFile.Name = "toolStripButtonRenameFile";
            this.toolStripButtonRenameFile.Size = new System.Drawing.Size(98, 24);
            this.toolStripButtonRenameFile.Text = "Rename File";
            this.toolStripButtonRenameFile.Visible = false;
            this.toolStripButtonRenameFile.Click += new System.EventHandler(this.toolStripButtonRenameFile_Click);
            // 
            // toolStripButtonCataloger
            // 
            this.toolStripButtonCataloger.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCataloger.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCataloger.Image")));
            this.toolStripButtonCataloger.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCataloger.Name = "toolStripButtonCataloger";
            this.toolStripButtonCataloger.Size = new System.Drawing.Size(107, 24);
            this.toolStripButtonCataloger.Text = "Run Cataloger";
            this.toolStripButtonCataloger.Click += new System.EventHandler(this.toolStripButtonCataloger_Click);
            // 
            // toolStripButtonExpand
            // 
            this.toolStripButtonExpand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonExpand.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExpand.Image")));
            this.toolStripButtonExpand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExpand.Name = "toolStripButtonExpand";
            this.toolStripButtonExpand.Size = new System.Drawing.Size(62, 24);
            this.toolStripButtonExpand.Text = "Expand";
            this.toolStripButtonExpand.Visible = false;
            this.toolStripButtonExpand.Click += new System.EventHandler(this.toolStripButtonExpand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 739);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Font Catalog";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpMain.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tlpDisplayFont.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView tvFonts;
        private System.Windows.Forms.TableLayoutPanel tlpDisplayFont;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ListView lvSearch;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelBaseline;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelSymbol;
        private System.Windows.Forms.Label labelStyle;
        private System.Windows.Forms.Label labelStretch;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelGlyphs;
        private System.Windows.Forms.Label labelCapsHeight;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelXHeight;
        private System.Windows.Forms.Label labelFamily;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxTarget;
        private System.Windows.Forms.Button buttonSearchFamily;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonSymbol;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelManufacturerName;
        private System.Windows.Forms.Label labelTrademark;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lvSelected;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSelect;
        private System.Windows.Forms.ToolStripButton toolStripButtonUncheck;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeselect;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.Button buttonSearchFileName;
        private System.Windows.Forms.Button buttonSearchFontName;
        private System.Windows.Forms.ColorDialog CD;
        private System.Windows.Forms.ToolStripButton toolStripButtonRenameFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonBackground;
        private System.Windows.Forms.Button buttonForeground;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.Button buttonColorSwap;
        private System.Windows.Forms.ToolStripButton toolStripButtonCataloger;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxSample;
        private System.Windows.Forms.ToolStripButton toolStripButtonExpand;
    }
}

