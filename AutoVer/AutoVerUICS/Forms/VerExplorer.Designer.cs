namespace AutoVerUICS.Forms
{
    partial class VerExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerExplorer));
            this.HelpProvider1 = new System.Windows.Forms.HelpProvider();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RestoreAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompareFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenViewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColumnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imlSmallListView = new System.Windows.Forms.ImageList(this.components);
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsv = new System.Windows.Forms.ListView();
            this.trv = new System.Windows.Forms.TreeView();
            this.imlTreeView = new System.Windows.Forms.ImageList(this.components);
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvwVersions = new System.Windows.Forms.ListView();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tspRestore = new System.Windows.Forms.ToolStripButton();
            this.tspCompare = new System.Windows.Forms.ToolStripButton();
            this.tspRefresh = new System.Windows.Forms.ToolStripButton();
            this.tspView = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tspBackup = new System.Windows.Forms.ToolStripButton();
            this.tspWatch = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.sbr1 = new System.Windows.Forms.StatusBar();
            this.MainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.ToolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HelpProvider1
            // 
            this.HelpProvider1.HelpNamespace = "AutoVer.chm";
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(310, 6);
            // 
            // RestoreAsToolStripMenuItem
            // 
            this.RestoreAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("RestoreAsToolStripMenuItem.Image")));
            this.RestoreAsToolStripMenuItem.Name = "RestoreAsToolStripMenuItem";
            this.RestoreAsToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.RestoreAsToolStripMenuItem.Text = "Restore As";
            // 
            // CompareFilesToolStripMenuItem
            // 
            this.CompareFilesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CompareFilesToolStripMenuItem.Image")));
            this.CompareFilesToolStripMenuItem.Name = "CompareFilesToolStripMenuItem";
            this.CompareFilesToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.CompareFilesToolStripMenuItem.Text = "Compare a file with current / Compare 2 Files";
            // 
            // OpenViewFileToolStripMenuItem
            // 
            this.OpenViewFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenViewFileToolStripMenuItem.Image")));
            this.OpenViewFileToolStripMenuItem.Name = "OpenViewFileToolStripMenuItem";
            this.OpenViewFileToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.OpenViewFileToolStripMenuItem.Text = "Open/View";
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenViewFileToolStripMenuItem,
            this.CompareFilesToolStripMenuItem,
            this.RestoreAsToolStripMenuItem,
            this.ToolStripSeparator2,
            this.DeleteToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(314, 98);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolStripMenuItem.Image")));
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "Name";
            this.ColumnName.Width = 0;
            // 
            // ColumnSize
            // 
            this.ColumnSize.Text = "Size";
            this.ColumnSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ColumnSize.Width = 90;
            // 
            // ColumnDate
            // 
            this.ColumnDate.Text = "Version Date";
            this.ColumnDate.Width = 140;
            // 
            // imlSmallListView
            // 
            this.imlSmallListView.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imlSmallListView.ImageSize = new System.Drawing.Size(16, 16);
            this.imlSmallListView.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Date Changed";
            this.ColumnHeader3.Width = 120;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Size";
            this.ColumnHeader2.Width = 0;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Name";
            this.ColumnHeader1.Width = 180;
            // 
            // lsv
            // 
            this.lsv.AllowColumnReorder = true;
            this.lsv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3});
            this.lsv.HideSelection = false;
            this.lsv.Location = new System.Drawing.Point(0, 0);
            this.lsv.Name = "lsv";
            this.lsv.Size = new System.Drawing.Size(312, 329);
            this.lsv.SmallImageList = this.imlSmallListView;
            this.lsv.TabIndex = 2;
            this.lsv.UseCompatibleStateImageBehavior = false;
            // 
            // trv
            // 
            this.trv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv.HideSelection = false;
            this.trv.ImageIndex = 0;
            this.trv.ImageList = this.imlTreeView;
            this.trv.Location = new System.Drawing.Point(0, 0);
            this.trv.Name = "trv";
            this.trv.SelectedImageIndex = 0;
            this.trv.Size = new System.Drawing.Size(178, 329);
            this.trv.TabIndex = 1;
            // 
            // imlTreeView
            // 
            this.imlTreeView.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imlTreeView.ImageSize = new System.Drawing.Size(16, 16);
            this.imlTreeView.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 25);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.trv);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.lsv);
            this.SplitContainer1.Panel2.Controls.Add(this.lvwVersions);
            this.SplitContainer1.Size = new System.Drawing.Size(753, 329);
            this.SplitContainer1.SplitterDistance = 178;
            this.SplitContainer1.TabIndex = 93;
            // 
            // lvwVersions
            // 
            this.lvwVersions.AllowColumnReorder = true;
            this.lvwVersions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnDate,
            this.ColumnSize,
            this.ColumnName});
            this.lvwVersions.Dock = System.Windows.Forms.DockStyle.Right;
            this.lvwVersions.Location = new System.Drawing.Point(318, 0);
            this.lvwVersions.Name = "lvwVersions";
            this.lvwVersions.Size = new System.Drawing.Size(253, 329);
            this.lvwVersions.TabIndex = 3;
            this.lvwVersions.UseCompatibleStateImageBehavior = false;
            this.lvwVersions.View = System.Windows.Forms.View.Details;
            // 
            // tsbDelete
            // 
            this.tsbDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "Delete Files";
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tspRestore
            // 
            this.tspRestore.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tspRestore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspRestore.Image = ((System.Drawing.Image)(resources.GetObject("tspRestore.Image")));
            this.tspRestore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspRestore.Name = "tspRestore";
            this.tspRestore.Size = new System.Drawing.Size(23, 22);
            this.tspRestore.Text = "Restore File";
            // 
            // tspCompare
            // 
            this.tspCompare.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tspCompare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspCompare.Image = ((System.Drawing.Image)(resources.GetObject("tspCompare.Image")));
            this.tspCompare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspCompare.Name = "tspCompare";
            this.tspCompare.Size = new System.Drawing.Size(23, 22);
            this.tspCompare.Text = "Compare a file with current / Compare 2 Files";
            // 
            // tspRefresh
            // 
            this.tspRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tspRefresh.Image")));
            this.tspRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspRefresh.Name = "tspRefresh";
            this.tspRefresh.Size = new System.Drawing.Size(23, 22);
            this.tspRefresh.Text = "Refresh Folders";
            // 
            // tspView
            // 
            this.tspView.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tspView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspView.Image = ((System.Drawing.Image)(resources.GetObject("tspView.Image")));
            this.tspView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspView.Name = "tspView";
            this.tspView.Size = new System.Drawing.Size(23, 22);
            this.tspView.Text = "Open/View Files";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tspBackup
            // 
            this.tspBackup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspBackup.Image = ((System.Drawing.Image)(resources.GetObject("tspBackup.Image")));
            this.tspBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspBackup.Name = "tspBackup";
            this.tspBackup.Size = new System.Drawing.Size(23, 22);
            this.tspBackup.Text = "View Backup Folder";
            // 
            // tspWatch
            // 
            this.tspWatch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspWatch.Image = ((System.Drawing.Image)(resources.GetObject("tspWatch.Image")));
            this.tspWatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspWatch.Name = "tspWatch";
            this.tspWatch.Size = new System.Drawing.Size(23, 22);
            this.tspWatch.Text = "View Watch Folder";
            // 
            // ToolStrip2
            // 
            this.ToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspWatch,
            this.tspBackup,
            this.ToolStripSeparator1,
            this.tspView,
            this.tspRefresh,
            this.tspCompare,
            this.tspRestore,
            this.ToolStripSeparator3,
            this.tsbDelete});
            this.ToolStrip2.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip2.Name = "ToolStrip2";
            this.ToolStrip2.Size = new System.Drawing.Size(753, 25);
            this.ToolStrip2.TabIndex = 92;
            this.ToolStrip2.Text = "ToolStrip2";
            // 
            // sbr1
            // 
            this.sbr1.Location = new System.Drawing.Point(0, 354);
            this.sbr1.Name = "sbr1";
            this.sbr1.Size = new System.Drawing.Size(753, 17);
            this.sbr1.TabIndex = 91;
            this.sbr1.Text = "Ready";
            // 
            // VerExplorer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(753, 371);
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.ToolStrip2);
            this.Controls.Add(this.sbr1);
            this.HelpProvider1.SetHelpKeyword(this, "5");
            this.HelpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.HelpProvider1.SetHelpString(this, "5");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.MainMenu1;
            this.Name = "VerExplorer";
            this.HelpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoVer Explorer";
            this.ContextMenuStrip1.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.ToolStrip2.ResumeLayout(false);
            this.ToolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.HelpProvider HelpProvider1;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripMenuItem RestoreAsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CompareFilesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OpenViewFileToolStripMenuItem;
        internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        internal System.Windows.Forms.ColumnHeader ColumnName;
        internal System.Windows.Forms.ColumnHeader ColumnSize;
        internal System.Windows.Forms.ColumnHeader ColumnDate;
        internal System.Windows.Forms.ImageList imlSmallListView;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ListView lsv;
        internal System.Windows.Forms.TreeView trv;
        internal System.Windows.Forms.ImageList imlTreeView;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.ListView lvwVersions;
        internal System.Windows.Forms.ToolStripButton tsbDelete;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripButton tspRestore;
        internal System.Windows.Forms.ToolStripButton tspCompare;
        internal System.Windows.Forms.ToolStripButton tspRefresh;
        internal System.Windows.Forms.ToolStripButton tspView;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton tspBackup;
        internal System.Windows.Forms.ToolStripButton tspWatch;
        internal System.Windows.Forms.ToolStrip ToolStrip2;
        internal System.Windows.Forms.StatusBar sbr1;
        internal System.Windows.Forms.MainMenu MainMenu1;
    }
}