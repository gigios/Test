namespace AutoVerUICS.Forms
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
            this.tsbExplore = new System.Windows.Forms.ToolStripButton();
            this.SysTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MainScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SysTrayToolStripMenuPauseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExporeBackupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnsureBackupIsCurrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestoreAllFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddWatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteWatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PauseResumeWatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tmrEngineUpdates = new System.Windows.Forms.Timer(this.components);
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tmrEnsureSyncUpdates = new System.Windows.Forms.Timer(this.components);
            this.tsbRestore = new System.Windows.Forms.ToolStripButton();
            this.lvwWatches = new System.Windows.Forms.ListView();
            this.lvcName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcStats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbProperties = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tspHelp = new System.Windows.Forms.ToolStripButton();
            this.tspAbout = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSettings = new System.Windows.Forms.ToolStripButton();
            this.tsbPause = new System.Windows.Forms.ToolStripSplitButton();
            this.tsbPauseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbEnsureBackup = new System.Windows.Forms.ToolStripSplitButton();
            this.tsbEnsureBackupALL = new System.Windows.Forms.ToolStripMenuItem();
            this.bwBackupRestore = new System.ComponentModel.BackgroundWorker();
            this.ContextMenuStrip1.SuspendLayout();
            this.ContextMenuStrip2.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsbExplore
            // 
            this.tsbExplore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExplore.Image = ((System.Drawing.Image)(resources.GetObject("tsbExplore.Image")));
            this.tsbExplore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExplore.Name = "tsbExplore";
            this.tsbExplore.Size = new System.Drawing.Size(36, 36);
            this.tsbExplore.Text = "Explore Backups";
            this.tsbExplore.ToolTipText = "Explore Backups for the selected Watcher.";
            // 
            // SysTrayIcon
            // 
            this.SysTrayIcon.ContextMenuStrip = this.ContextMenuStrip1;
            this.SysTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("SysTrayIcon.Icon")));
            this.SysTrayIcon.Text = "AutoVer";
            this.SysTrayIcon.Visible = true;
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainScreenToolStripMenuItem,
            this.SysTrayToolStripMenuPauseAll,
            this.ExitToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(185, 70);
            // 
            // MainScreenToolStripMenuItem
            // 
            this.MainScreenToolStripMenuItem.Name = "MainScreenToolStripMenuItem";
            this.MainScreenToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.MainScreenToolStripMenuItem.Text = "AutoVer &Main Screen";
            // 
            // SysTrayToolStripMenuPauseAll
            // 
            this.SysTrayToolStripMenuPauseAll.Name = "SysTrayToolStripMenuPauseAll";
            this.SysTrayToolStripMenuPauseAll.Size = new System.Drawing.Size(184, 22);
            this.SysTrayToolStripMenuPauseAll.Text = "Pause/Resume All";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ExitToolStripMenuItem.Text = "E&xit AutoVer";
            // 
            // ContextMenuStrip2
            // 
            this.ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExporeBackupsToolStripMenuItem,
            this.EnsureBackupIsCurrentToolStripMenuItem,
            this.RestoreAllFilesToolStripMenuItem,
            this.ViewPropertiesToolStripMenuItem,
            this.AddWatchToolStripMenuItem,
            this.DeleteWatchToolStripMenuItem,
            this.PauseResumeWatchToolStripMenuItem});
            this.ContextMenuStrip2.Name = "ContextMenuStrip2";
            this.ContextMenuStrip2.Size = new System.Drawing.Size(202, 158);
            // 
            // ExporeBackupsToolStripMenuItem
            // 
            this.ExporeBackupsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ExporeBackupsToolStripMenuItem.Image")));
            this.ExporeBackupsToolStripMenuItem.Name = "ExporeBackupsToolStripMenuItem";
            this.ExporeBackupsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ExporeBackupsToolStripMenuItem.Text = "Explore Backups";
            // 
            // EnsureBackupIsCurrentToolStripMenuItem
            // 
            this.EnsureBackupIsCurrentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EnsureBackupIsCurrentToolStripMenuItem.Image")));
            this.EnsureBackupIsCurrentToolStripMenuItem.Name = "EnsureBackupIsCurrentToolStripMenuItem";
            this.EnsureBackupIsCurrentToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.EnsureBackupIsCurrentToolStripMenuItem.Text = "Synchronise Backup";
            // 
            // RestoreAllFilesToolStripMenuItem
            // 
            this.RestoreAllFilesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("RestoreAllFilesToolStripMenuItem.Image")));
            this.RestoreAllFilesToolStripMenuItem.Name = "RestoreAllFilesToolStripMenuItem";
            this.RestoreAllFilesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.RestoreAllFilesToolStripMenuItem.Text = "Restore all Watcher Files";
            // 
            // ViewPropertiesToolStripMenuItem
            // 
            this.ViewPropertiesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ViewPropertiesToolStripMenuItem.Image")));
            this.ViewPropertiesToolStripMenuItem.Name = "ViewPropertiesToolStripMenuItem";
            this.ViewPropertiesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ViewPropertiesToolStripMenuItem.Text = "Watcher Properties";
            // 
            // AddWatchToolStripMenuItem
            // 
            this.AddWatchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AddWatchToolStripMenuItem.Image")));
            this.AddWatchToolStripMenuItem.Name = "AddWatchToolStripMenuItem";
            this.AddWatchToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.AddWatchToolStripMenuItem.Text = "Add Watcher";
            // 
            // DeleteWatchToolStripMenuItem
            // 
            this.DeleteWatchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DeleteWatchToolStripMenuItem.Image")));
            this.DeleteWatchToolStripMenuItem.Name = "DeleteWatchToolStripMenuItem";
            this.DeleteWatchToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.DeleteWatchToolStripMenuItem.Text = "Delete Watcher";
            // 
            // PauseResumeWatchToolStripMenuItem
            // 
            this.PauseResumeWatchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PauseResumeWatchToolStripMenuItem.Image")));
            this.PauseResumeWatchToolStripMenuItem.Name = "PauseResumeWatchToolStripMenuItem";
            this.PauseResumeWatchToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.PauseResumeWatchToolStripMenuItem.Text = "Pause/Resume Watcher";
            // 
            // HelpProvider1
            // 
            this.HelpProvider1.HelpNamespace = "AutoVer.chm";
            // 
            // tmrEngineUpdates
            // 
            this.tmrEngineUpdates.Enabled = true;
            this.tmrEngineUpdates.Interval = 10000;
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tmrEnsureSyncUpdates
            // 
            this.tmrEnsureSyncUpdates.Interval = 1000;
            // 
            // tsbRestore
            // 
            this.tsbRestore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRestore.Image = ((System.Drawing.Image)(resources.GetObject("tsbRestore.Image")));
            this.tsbRestore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRestore.Name = "tsbRestore";
            this.tsbRestore.Size = new System.Drawing.Size(36, 36);
            this.tsbRestore.Text = "Restore All Files";
            this.tsbRestore.ToolTipText = "Restore files for the selected Watcher.";
            // 
            // lvwWatches
            // 
            this.lvwWatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwWatches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvcName,
            this.lvcStatus,
            this.lvcStats,
            this.lvcMessage});
            this.lvwWatches.FullRowSelect = true;
            this.lvwWatches.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwWatches.HideSelection = false;
            this.lvwWatches.Location = new System.Drawing.Point(-77, 40);
            this.lvwWatches.MultiSelect = false;
            this.lvwWatches.Name = "lvwWatches";
            this.lvwWatches.Size = new System.Drawing.Size(640, 222);
            this.lvwWatches.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwWatches.TabIndex = 4;
            this.lvwWatches.UseCompatibleStateImageBehavior = false;
            this.lvwWatches.View = System.Windows.Forms.View.Details;
            // 
            // lvcName
            // 
            this.lvcName.Text = "Watch";
            this.lvcName.Width = 355;
            // 
            // lvcStatus
            // 
            this.lvcStatus.Text = "Status";
            this.lvcStatus.Width = 95;
            // 
            // lvcStats
            // 
            this.lvcStats.Text = "Events";
            this.lvcStats.Width = 80;
            // 
            // lvcMessage
            // 
            this.lvcMessage.Text = "Messages";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbProperties,
            this.tsbDelete,
            this.ToolStripSeparator1,
            this.tspHelp,
            this.tspAbout,
            this.ToolStripSeparator2,
            this.tsbSettings,
            this.tsbPause,
            this.tsbEnsureBackup,
            this.tsbRestore,
            this.tsbExplore,
            this.ToolStripSeparator3});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToolStrip1.Size = new System.Drawing.Size(474, 39);
            this.ToolStrip1.TabIndex = 5;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(36, 36);
            this.tsbAdd.Text = "ToolStripButton1";
            this.tsbAdd.ToolTipText = "Add new Watcher";
            // 
            // tsbProperties
            // 
            this.tsbProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProperties.Image = ((System.Drawing.Image)(resources.GetObject("tsbProperties.Image")));
            this.tsbProperties.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProperties.Name = "tsbProperties";
            this.tsbProperties.Size = new System.Drawing.Size(36, 36);
            this.tsbProperties.Text = "ToolStripButton1";
            this.tsbProperties.ToolTipText = "Watcher Properties";
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(36, 36);
            this.tsbDelete.Text = "ToolStripButton1";
            this.tsbDelete.ToolTipText = "Delete watcher";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tspHelp
            // 
            this.tspHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tspHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspHelp.Image = ((System.Drawing.Image)(resources.GetObject("tspHelp.Image")));
            this.tspHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspHelp.Name = "tspHelp";
            this.tspHelp.Size = new System.Drawing.Size(36, 36);
            this.tspHelp.Text = "Help";
            this.tspHelp.ToolTipText = "Help";
            // 
            // tspAbout
            // 
            this.tspAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tspAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspAbout.Image = ((System.Drawing.Image)(resources.GetObject("tspAbout.Image")));
            this.tspAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspAbout.Name = "tspAbout";
            this.tspAbout.Size = new System.Drawing.Size(36, 36);
            this.tspAbout.Text = "About";
            this.tspAbout.ToolTipText = "About AutoVer";
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbSettings
            // 
            this.tsbSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSettings.Image = ((System.Drawing.Image)(resources.GetObject("tsbSettings.Image")));
            this.tsbSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSettings.Name = "tsbSettings";
            this.tsbSettings.Size = new System.Drawing.Size(36, 36);
            this.tsbSettings.Text = "Application Settings";
            // 
            // tsbPause
            // 
            this.tsbPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPause.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPauseAll});
            this.tsbPause.Image = ((System.Drawing.Image)(resources.GetObject("tsbPause.Image")));
            this.tsbPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPause.Name = "tsbPause";
            this.tsbPause.Size = new System.Drawing.Size(48, 36);
            this.tsbPause.Text = "Pause/Resume Watcher";
            // 
            // tsbPauseAll
            // 
            this.tsbPauseAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbPauseAll.Image")));
            this.tsbPauseAll.Name = "tsbPauseAll";
            this.tsbPauseAll.Size = new System.Drawing.Size(175, 22);
            this.tsbPauseAll.Text = "Pause/Resume ALL";
            this.tsbPauseAll.ToolTipText = "Pause/Resume ALL Watchers";
            // 
            // tsbEnsureBackup
            // 
            this.tsbEnsureBackup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEnsureBackup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEnsureBackupALL});
            this.tsbEnsureBackup.Image = ((System.Drawing.Image)(resources.GetObject("tsbEnsureBackup.Image")));
            this.tsbEnsureBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEnsureBackup.Name = "tsbEnsureBackup";
            this.tsbEnsureBackup.Size = new System.Drawing.Size(48, 36);
            this.tsbEnsureBackup.Text = "Synchronise (Backup now!)";
            this.tsbEnsureBackup.ToolTipText = "Synchronise the selected Watcher (Backup now!)";
            // 
            // tsbEnsureBackupALL
            // 
            this.tsbEnsureBackupALL.Image = ((System.Drawing.Image)(resources.GetObject("tsbEnsureBackupALL.Image")));
            this.tsbEnsureBackupALL.Name = "tsbEnsureBackupALL";
            this.tsbEnsureBackupALL.Size = new System.Drawing.Size(208, 22);
            this.tsbEnsureBackupALL.Text = "Synchronise ALL backups";
            this.tsbEnsureBackupALL.ToolTipText = "Ensure ALL backups are current. (Sync ALL now!)";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 266);
            this.Controls.Add(this.lvwWatches);
            this.Controls.Add(this.ToolStrip1);
            this.HelpButton = true;
            this.HelpProvider1.SetHelpKeyword(this, "2");
            this.HelpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.HelpProvider1.SetHelpString(this, "2");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.HelpProvider1.SetShowHelp(this, true);
            this.Text = "AutoVer";
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ContextMenuStrip2.ResumeLayout(false);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripButton tsbExplore;
        internal System.Windows.Forms.NotifyIcon SysTrayIcon;
        internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem MainScreenToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SysTrayToolStripMenuPauseAll;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip2;
        internal System.Windows.Forms.ToolStripMenuItem ExporeBackupsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EnsureBackupIsCurrentToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RestoreAllFilesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ViewPropertiesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AddWatchToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DeleteWatchToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PauseResumeWatchToolStripMenuItem;
        internal System.Windows.Forms.HelpProvider HelpProvider1;
        internal System.Windows.Forms.Timer tmrEngineUpdates;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.Timer tmrEnsureSyncUpdates;
        internal System.Windows.Forms.ToolStripButton tsbRestore;
        internal System.Windows.Forms.ListView lvwWatches;
        internal System.Windows.Forms.ColumnHeader lvcName;
        internal System.Windows.Forms.ColumnHeader lvcStatus;
        internal System.Windows.Forms.ColumnHeader lvcStats;
        internal System.Windows.Forms.ColumnHeader lvcMessage;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton tsbAdd;
        internal System.Windows.Forms.ToolStripButton tsbProperties;
        internal System.Windows.Forms.ToolStripButton tsbDelete;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton tspHelp;
        internal System.Windows.Forms.ToolStripButton tspAbout;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton tsbSettings;
        internal System.Windows.Forms.ToolStripSplitButton tsbPause;
        internal System.Windows.Forms.ToolStripMenuItem tsbPauseAll;
        internal System.Windows.Forms.ToolStripSplitButton tsbEnsureBackup;
        internal System.Windows.Forms.ToolStripMenuItem tsbEnsureBackupALL;
        internal System.ComponentModel.BackgroundWorker bwBackupRestore;
    }
}