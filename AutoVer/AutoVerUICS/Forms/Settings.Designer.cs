namespace AutoVerUICS.Forms
{
    partial class Settings
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
            this.rbVersionPrev = new System.Windows.Forms.RadioButton();
            this.txtVerRateS = new System.Windows.Forms.TextBox();
            this.lblHourMinSec = new System.Windows.Forms.Label();
            this.txtVerRateM = new System.Windows.Forms.TextBox();
            this.txtVerRateH = new System.Windows.Forms.TextBox();
            this.rbVerRate = new System.Windows.Forms.RadioButton();
            this.rbVerAll = new System.Windows.Forms.RadioButton();
            this.grpVerMax = new System.Windows.Forms.GroupBox();
            this.rbZipModeF = new System.Windows.Forms.RadioButton();
            this.rbZipModeD = new System.Windows.Forms.RadioButton();
            this.rbZipModeW = new System.Windows.Forms.RadioButton();
            this.lblZip1 = new System.Windows.Forms.Label();
            this.grpArcTo = new System.Windows.Forms.GroupBox();
            this.txtMaxVersionAge = new System.Windows.Forms.TextBox();
            this.lblVerDays = new System.Windows.Forms.Label();
            this.radNothing = new System.Windows.Forms.RadioButton();
            this.radDelete = new System.Windows.Forms.RadioButton();
            this.radZip = new System.Windows.Forms.RadioButton();
            this.rad7Zip = new System.Windows.Forms.RadioButton();
            this.grpArc = new System.Windows.Forms.GroupBox();
            this.lblVersOlder = new System.Windows.Forms.Label();
            this.grpVerMode = new System.Windows.Forms.GroupBox();
            this.rbVersionAll = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.bwBackupRestore = new System.ComponentModel.BackgroundWorker();
            this.tabGen = new System.Windows.Forms.TabPage();
            this.chkShowEvents = new System.Windows.Forms.CheckBox();
            this.chkSubFolders = new System.Windows.Forms.CheckBox();
            this.chkShowErrors = new System.Windows.Forms.CheckBox();
            this.lblStats = new System.Windows.Forms.Label();
            this.lblCounts = new System.Windows.Forms.Label();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.rbFolder = new System.Windows.Forms.RadioButton();
            this.rbFTP = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkBackup = new System.Windows.Forms.CheckBox();
            this.butBackupFolder = new System.Windows.Forms.Button();
            this.btnWatchFolder = new System.Windows.Forms.Button();
            this.txtWatch = new System.Windows.Forms.TextBox();
            this.txtBackup = new System.Windows.Forms.TextBox();
            this.lblBackFold = new System.Windows.Forms.Label();
            this.lblWatchFold = new System.Windows.Forms.Label();
            this.ToolTip1 = new System.Windows.Forms.ToolTip();
            this.chkFTPPassive = new System.Windows.Forms.CheckBox();
            this.txtFTPPassword = new System.Windows.Forms.TextBox();
            this.txtFTPLogin = new System.Windows.Forms.TextBox();
            this.txtFTPHost = new System.Windows.Forms.TextBox();
            this.txtDateTimeStamp = new System.Windows.Forms.TextBox();
            this.chkCompareBeforeCopy = new System.Windows.Forms.CheckBox();
            this.txtSettleDelay = new System.Windows.Forms.TextBox();
            this.chkRunCopyFirst = new System.Windows.Forms.CheckBox();
            this.txtRunCopy = new System.Windows.Forms.TextBox();
            this.txtEnsureTime = new System.Windows.Forms.TextBox();
            this.txtMaxFileSize = new System.Windows.Forms.TextBox();
            this.txtExcludeFiles = new System.Windows.Forms.TextBox();
            this.txtExcludeFolders = new System.Windows.Forms.TextBox();
            this.txtIncludeFiles = new System.Windows.Forms.TextBox();
            this.HelpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblFtpAnon = new System.Windows.Forms.Label();
            this.lblFtpPass = new System.Windows.Forms.Label();
            this.lblFtpUser = new System.Windows.Forms.Label();
            this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.butOK = new System.Windows.Forms.Button();
            this.lblFtpHost = new System.Windows.Forms.Label();
            this.lblFtpIf = new System.Windows.Forms.Label();
            this.lblTimeStamp = new System.Windows.Forms.Label();
            this.butCancel = new System.Windows.Forms.Button();
            this.tabAdv = new System.Windows.Forms.TabPage();
            this.lblSettle = new System.Windows.Forms.Label();
            this.lblRunCopy = new System.Windows.Forms.Label();
            this.rbEnsureHourly = new System.Windows.Forms.RadioButton();
            this.rbEnsureDaily = new System.Windows.Forms.RadioButton();
            this.rbEnsureNever = new System.Windows.Forms.RadioButton();
            this.lblSync = new System.Windows.Forms.Label();
            this.lblFoldSep = new System.Windows.Forms.Label();
            this.lblFileSep = new System.Windows.Forms.Label();
            this.lblMaxFileSize = new System.Windows.Forms.Label();
            this.lblExclFiles = new System.Windows.Forms.Label();
            this.lblExclFold = new System.Windows.Forms.Label();
            this.lblIncFiles = new System.Windows.Forms.Label();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.tabVer = new System.Windows.Forms.TabPage();
            this.tmrEnsureSyncUpdates = new System.Windows.Forms.Timer();
            this.tabFTP = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.grpVerMax.SuspendLayout();
            this.grpArcTo.SuspendLayout();
            this.grpArc.SuspendLayout();
            this.grpVerMode.SuspendLayout();
            this.tabGen.SuspendLayout();
            this.grpType.SuspendLayout();
            this.tabAdv.SuspendLayout();
            this.tabVer.SuspendLayout();
            this.tabFTP.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbVersionPrev
            // 
            this.rbVersionPrev.AutoSize = true;
            this.rbVersionPrev.Location = new System.Drawing.Point(6, 65);
            this.rbVersionPrev.Name = "rbVersionPrev";
            this.rbVersionPrev.Size = new System.Drawing.Size(169, 17);
            this.rbVersionPrev.TabIndex = 9;
            this.rbVersionPrev.Text = "Version previous backups only";
            this.ToolTip1.SetToolTip(this.rbVersionPrev, "Previous backup is renamed to include a timestamp. Current backup does not have a" +
        " timestamp");
            this.rbVersionPrev.UseVisualStyleBackColor = true;
            // 
            // txtVerRateS
            // 
            this.txtVerRateS.Location = new System.Drawing.Point(99, 44);
            this.txtVerRateS.MaxLength = 2;
            this.txtVerRateS.Name = "txtVerRateS";
            this.txtVerRateS.Size = new System.Drawing.Size(30, 20);
            this.txtVerRateS.TabIndex = 6;
            this.txtVerRateS.Text = "0";
            // 
            // lblHourMinSec
            // 
            this.lblHourMinSec.AutoSize = true;
            this.lblHourMinSec.Location = new System.Drawing.Point(24, 69);
            this.lblHourMinSec.Name = "lblHourMinSec";
            this.lblHourMinSec.Size = new System.Drawing.Size(99, 13);
            this.lblHourMinSec.TabIndex = 5;
            this.lblHourMinSec.Text = "Hours : Mins : Secs";
            // 
            // txtVerRateM
            // 
            this.txtVerRateM.Location = new System.Drawing.Point(63, 44);
            this.txtVerRateM.MaxLength = 2;
            this.txtVerRateM.Name = "txtVerRateM";
            this.txtVerRateM.Size = new System.Drawing.Size(30, 20);
            this.txtVerRateM.TabIndex = 4;
            // 
            // txtVerRateH
            // 
            this.txtVerRateH.Location = new System.Drawing.Point(27, 44);
            this.txtVerRateH.MaxLength = 3;
            this.txtVerRateH.Name = "txtVerRateH";
            this.txtVerRateH.Size = new System.Drawing.Size(30, 20);
            this.txtVerRateH.TabIndex = 2;
            // 
            // rbVerRate
            // 
            this.rbVerRate.AutoSize = true;
            this.rbVerRate.Location = new System.Drawing.Point(7, 44);
            this.rbVerRate.Name = "rbVerRate";
            this.rbVerRate.Size = new System.Drawing.Size(14, 13);
            this.rbVerRate.TabIndex = 1;
            this.ToolTip1.SetToolTip(this.rbVerRate, "Only copy the file every so often when it is changed/saved");
            this.rbVerRate.UseVisualStyleBackColor = true;
            // 
            // rbVerAll
            // 
            this.rbVerAll.AutoSize = true;
            this.rbVerAll.Checked = true;
            this.rbVerAll.Location = new System.Drawing.Point(7, 20);
            this.rbVerAll.Name = "rbVerAll";
            this.rbVerAll.Size = new System.Drawing.Size(81, 17);
            this.rbVerAll.TabIndex = 0;
            this.rbVerAll.TabStop = true;
            this.rbVerAll.Text = "All Changes";
            this.ToolTip1.SetToolTip(this.rbVerAll, "Make a new copy every time the file is changed or saved");
            this.rbVerAll.UseVisualStyleBackColor = true;
            // 
            // grpVerMax
            // 
            this.grpVerMax.Controls.Add(this.txtVerRateS);
            this.grpVerMax.Controls.Add(this.lblHourMinSec);
            this.grpVerMax.Controls.Add(this.txtVerRateM);
            this.grpVerMax.Controls.Add(this.txtVerRateH);
            this.grpVerMax.Controls.Add(this.rbVerRate);
            this.grpVerMax.Controls.Add(this.rbVerAll);
            this.grpVerMax.Location = new System.Drawing.Point(202, 6);
            this.grpVerMax.Name = "grpVerMax";
            this.grpVerMax.Size = new System.Drawing.Size(165, 90);
            this.grpVerMax.TabIndex = 33;
            this.grpVerMax.TabStop = false;
            this.grpVerMax.Text = "Max 1 version per ";
            // 
            // rbZipModeF
            // 
            this.rbZipModeF.AutoSize = true;
            this.rbZipModeF.Location = new System.Drawing.Point(285, 24);
            this.rbZipModeF.Name = "rbZipModeF";
            this.rbZipModeF.Size = new System.Drawing.Size(41, 17);
            this.rbZipModeF.TabIndex = 44;
            this.rbZipModeF.Text = "File";
            this.ToolTip1.SetToolTip(this.rbZipModeF, "Archive file will be the file name.zip/7z in the backed up folder");
            this.rbZipModeF.UseVisualStyleBackColor = true;
            // 
            // rbZipModeD
            // 
            this.rbZipModeD.AutoSize = true;
            this.rbZipModeD.Location = new System.Drawing.Point(217, 24);
            this.rbZipModeD.Name = "rbZipModeD";
            this.rbZipModeD.Size = new System.Drawing.Size(54, 17);
            this.rbZipModeD.TabIndex = 43;
            this.rbZipModeD.Text = "Folder";
            this.ToolTip1.SetToolTip(this.rbZipModeD, "Archive file will be the folder name.zip/7z in the backed up folder");
            this.rbZipModeD.UseVisualStyleBackColor = true;
            // 
            // rbZipModeW
            // 
            this.rbZipModeW.AutoSize = true;
            this.rbZipModeW.Checked = true;
            this.rbZipModeW.Location = new System.Drawing.Point(126, 24);
            this.rbZipModeW.Name = "rbZipModeW";
            this.rbZipModeW.Size = new System.Drawing.Size(66, 17);
            this.rbZipModeW.TabIndex = 42;
            this.rbZipModeW.TabStop = true;
            this.rbZipModeW.Text = "Watcher";
            this.ToolTip1.SetToolTip(this.rbZipModeW, "Archive file will be BackupVersions.zip/7z in the Backup folder root");
            this.rbZipModeW.UseVisualStyleBackColor = true;
            // 
            // lblZip1
            // 
            this.lblZip1.AutoSize = true;
            this.lblZip1.Location = new System.Drawing.Point(6, 26);
            this.lblZip1.Name = "lblZip1";
            this.lblZip1.Size = new System.Drawing.Size(80, 13);
            this.lblZip1.TabIndex = 41;
            this.lblZip1.Text = "Zip to 1 file per:";
            // 
            // grpArcTo
            // 
            this.grpArcTo.Controls.Add(this.rbZipModeF);
            this.grpArcTo.Controls.Add(this.rbZipModeD);
            this.grpArcTo.Controls.Add(this.rbZipModeW);
            this.grpArcTo.Controls.Add(this.lblZip1);
            this.grpArcTo.Location = new System.Drawing.Point(9, 211);
            this.grpArcTo.Name = "grpArcTo";
            this.grpArcTo.Size = new System.Drawing.Size(358, 58);
            this.grpArcTo.TabIndex = 42;
            this.grpArcTo.TabStop = false;
            this.grpArcTo.Text = "Archive To";
            // 
            // txtMaxVersionAge
            // 
            this.txtMaxVersionAge.Location = new System.Drawing.Point(126, 22);
            this.txtMaxVersionAge.MaxLength = 3;
            this.txtMaxVersionAge.Name = "txtMaxVersionAge";
            this.txtMaxVersionAge.Size = new System.Drawing.Size(35, 20);
            this.txtMaxVersionAge.TabIndex = 3;
            this.txtMaxVersionAge.Text = "90";
            // 
            // lblVerDays
            // 
            this.lblVerDays.AutoSize = true;
            this.lblVerDays.Location = new System.Drawing.Point(167, 25);
            this.lblVerDays.Name = "lblVerDays";
            this.lblVerDays.Size = new System.Drawing.Size(38, 13);
            this.lblVerDays.TabIndex = 26;
            this.lblVerDays.Text = "days...";
            // 
            // radNothing
            // 
            this.radNothing.AutoSize = true;
            this.radNothing.Checked = true;
            this.radNothing.Location = new System.Drawing.Point(217, 25);
            this.radNothing.Name = "radNothing";
            this.radNothing.Size = new System.Drawing.Size(62, 17);
            this.radNothing.TabIndex = 4;
            this.radNothing.TabStop = true;
            this.radNothing.Text = "Nothing";
            this.ToolTip1.SetToolTip(this.radNothing, "Default. Don\'t touch the old versions");
            this.radNothing.UseVisualStyleBackColor = true;
            // 
            // radDelete
            // 
            this.radDelete.AutoSize = true;
            this.radDelete.Location = new System.Drawing.Point(285, 25);
            this.radDelete.Name = "radDelete";
            this.radDelete.Size = new System.Drawing.Size(56, 17);
            this.radDelete.TabIndex = 5;
            this.radDelete.Text = "Delete";
            this.ToolTip1.SetToolTip(this.radDelete, "Delete the old versions");
            this.radDelete.UseVisualStyleBackColor = true;
            // 
            // radZip
            // 
            this.radZip.AutoSize = true;
            this.radZip.Location = new System.Drawing.Point(218, 48);
            this.radZip.Name = "radZip";
            this.radZip.Size = new System.Drawing.Size(40, 17);
            this.radZip.TabIndex = 6;
            this.radZip.Text = "Zip";
            this.ToolTip1.SetToolTip(this.radZip, "Good compression and very fast");
            this.radZip.UseVisualStyleBackColor = true;
            // 
            // rad7Zip
            // 
            this.rad7Zip.AutoSize = true;
            this.rad7Zip.Location = new System.Drawing.Point(285, 48);
            this.rad7Zip.Name = "rad7Zip";
            this.rad7Zip.Size = new System.Drawing.Size(49, 17);
            this.rad7Zip.TabIndex = 34;
            this.rad7Zip.Text = "7-Zip";
            this.ToolTip1.SetToolTip(this.rad7Zip, "7-Zip must be installed. Best compression");
            this.rad7Zip.UseVisualStyleBackColor = true;
            // 
            // grpArc
            // 
            this.grpArc.Controls.Add(this.lblVersOlder);
            this.grpArc.Controls.Add(this.txtMaxVersionAge);
            this.grpArc.Controls.Add(this.lblVerDays);
            this.grpArc.Controls.Add(this.radNothing);
            this.grpArc.Controls.Add(this.radDelete);
            this.grpArc.Controls.Add(this.radZip);
            this.grpArc.Controls.Add(this.rad7Zip);
            this.grpArc.Location = new System.Drawing.Point(9, 128);
            this.grpArc.Name = "grpArc";
            this.grpArc.Size = new System.Drawing.Size(358, 77);
            this.grpArc.TabIndex = 41;
            this.grpArc.TabStop = false;
            this.grpArc.Text = "Archiving";
            // 
            // lblVersOlder
            // 
            this.lblVersOlder.AutoSize = true;
            this.lblVersOlder.Location = new System.Drawing.Point(6, 25);
            this.lblVersOlder.Name = "lblVersOlder";
            this.lblVersOlder.Size = new System.Drawing.Size(114, 13);
            this.lblVersOlder.TabIndex = 24;
            this.lblVersOlder.Text = "For versions older than";
            // 
            // grpVerMode
            // 
            this.grpVerMode.Controls.Add(this.rbVersionPrev);
            this.grpVerMode.Controls.Add(this.rbVersionAll);
            this.grpVerMode.Controls.Add(this.rbNone);
            this.grpVerMode.Location = new System.Drawing.Point(9, 6);
            this.grpVerMode.Name = "grpVerMode";
            this.grpVerMode.Size = new System.Drawing.Size(187, 90);
            this.grpVerMode.TabIndex = 32;
            this.grpVerMode.TabStop = false;
            this.grpVerMode.Text = "Versioning Mode";
            // 
            // rbVersionAll
            // 
            this.rbVersionAll.AutoSize = true;
            this.rbVersionAll.Checked = true;
            this.rbVersionAll.Location = new System.Drawing.Point(6, 42);
            this.rbVersionAll.Name = "rbVersionAll";
            this.rbVersionAll.Size = new System.Drawing.Size(133, 17);
            this.rbVersionAll.TabIndex = 8;
            this.rbVersionAll.TabStop = true;
            this.rbVersionAll.Text = "Version all backup files";
            this.ToolTip1.SetToolTip(this.rbVersionAll, "Every backup file has a timestamp");
            this.rbVersionAll.UseVisualStyleBackColor = true;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(6, 19);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(172, 17);
            this.rbNone.TabIndex = 7;
            this.rbNone.Text = "None - Update backup file only";
            this.ToolTip1.SetToolTip(this.rbNone, "No versioning (time stamping). Just backup the file to the same name");
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // tabGen
            // 
            this.tabGen.Controls.Add(this.chkShowEvents);
            this.tabGen.Controls.Add(this.chkSubFolders);
            this.tabGen.Controls.Add(this.chkShowErrors);
            this.tabGen.Controls.Add(this.lblStats);
            this.tabGen.Controls.Add(this.lblCounts);
            this.tabGen.Controls.Add(this.chkEnabled);
            this.tabGen.Controls.Add(this.grpType);
            this.tabGen.Controls.Add(this.lblName);
            this.tabGen.Controls.Add(this.txtName);
            this.tabGen.Controls.Add(this.chkBackup);
            this.tabGen.Controls.Add(this.butBackupFolder);
            this.tabGen.Controls.Add(this.btnWatchFolder);
            this.tabGen.Controls.Add(this.txtWatch);
            this.tabGen.Controls.Add(this.txtBackup);
            this.tabGen.Controls.Add(this.lblBackFold);
            this.tabGen.Controls.Add(this.lblWatchFold);
            this.tabGen.Location = new System.Drawing.Point(4, 22);
            this.tabGen.Name = "tabGen";
            this.tabGen.Padding = new System.Windows.Forms.Padding(3);
            this.tabGen.Size = new System.Drawing.Size(373, 282);
            this.tabGen.TabIndex = 0;
            this.tabGen.Text = "General";
            this.tabGen.UseVisualStyleBackColor = true;
            // 
            // chkShowEvents
            // 
            this.chkShowEvents.AutoSize = true;
            this.chkShowEvents.Location = new System.Drawing.Point(6, 205);
            this.chkShowEvents.Name = "chkShowEvents";
            this.chkShowEvents.Size = new System.Drawing.Size(143, 17);
            this.chkShowEvents.TabIndex = 18;
            this.chkShowEvents.Text = "Show on all other events";
            this.ToolTip1.SetToolTip(this.chkShowEvents, "Show balloon alert in the System Tray on each copy/rename/delete event");
            this.chkShowEvents.UseVisualStyleBackColor = true;
            // 
            // chkSubFolders
            // 
            this.chkSubFolders.AutoSize = true;
            this.chkSubFolders.Checked = true;
            this.chkSubFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSubFolders.Location = new System.Drawing.Point(6, 136);
            this.chkSubFolders.Name = "chkSubFolders";
            this.chkSubFolders.Size = new System.Drawing.Size(115, 17);
            this.chkSubFolders.TabIndex = 17;
            this.chkSubFolders.Text = "Include sub folders";
            this.chkSubFolders.UseVisualStyleBackColor = true;
            // 
            // chkShowErrors
            // 
            this.chkShowErrors.AutoSize = true;
            this.chkShowErrors.Location = new System.Drawing.Point(6, 182);
            this.chkShowErrors.Name = "chkShowErrors";
            this.chkShowErrors.Size = new System.Drawing.Size(120, 17);
            this.chkShowErrors.TabIndex = 16;
            this.chkShowErrors.Text = "Show alert on errors";
            this.ToolTip1.SetToolTip(this.chkShowErrors, "Show balloon alert in the System Tray on each error");
            this.chkShowErrors.UseVisualStyleBackColor = true;
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.Location = new System.Drawing.Point(272, 220);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(88, 13);
            this.lblStats.TabIndex = 15;
            this.lblStats.Text = "Session Stats:";
            // 
            // lblCounts
            // 
            this.lblCounts.AutoSize = true;
            this.lblCounts.Location = new System.Drawing.Point(275, 233);
            this.lblCounts.Name = "lblCounts";
            this.lblCounts.Size = new System.Drawing.Size(65, 39);
            this.lblCounts.TabIndex = 14;
            this.lblCounts.Text = "Changed: 0 \r\nRenamed: 0\r\nDeleted: 0";
            this.ToolTip1.SetToolTip(this.lblCounts, "File statistics since AutoVer last started");
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Checked = true;
            this.chkEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnabled.Location = new System.Drawing.Point(298, 17);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(65, 17);
            this.chkEnabled.TabIndex = 1;
            this.chkEnabled.Text = "Enabled";
            this.ToolTip1.SetToolTip(this.chkEnabled, "Enable or disable the watcher");
            this.chkEnabled.UseVisualStyleBackColor = true;
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.rbFolder);
            this.grpType.Controls.Add(this.rbFTP);
            this.grpType.Location = new System.Drawing.Point(80, 94);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(150, 36);
            this.grpType.TabIndex = 12;
            this.grpType.TabStop = false;
            this.grpType.Text = "Backup Type";
            this.ToolTip1.SetToolTip(this.grpType, "Folder or FTP address selected in \"Backup to\" above");
            // 
            // rbFolder
            // 
            this.rbFolder.AutoSize = true;
            this.rbFolder.Checked = true;
            this.rbFolder.Location = new System.Drawing.Point(21, 13);
            this.rbFolder.Name = "rbFolder";
            this.rbFolder.Size = new System.Drawing.Size(54, 17);
            this.rbFolder.TabIndex = 6;
            this.rbFolder.TabStop = true;
            this.rbFolder.Text = "Folder";
            this.ToolTip1.SetToolTip(this.rbFolder, "Backup to any Windows accessable folder or drive");
            this.rbFolder.UseVisualStyleBackColor = true;
            // 
            // rbFTP
            // 
            this.rbFTP.AutoSize = true;
            this.rbFTP.Location = new System.Drawing.Point(89, 13);
            this.rbFTP.Name = "rbFTP";
            this.rbFTP.Size = new System.Drawing.Size(45, 17);
            this.rbFTP.TabIndex = 6;
            this.rbFTP.TabStop = true;
            this.rbFTP.Text = "FTP";
            this.ToolTip1.SetToolTip(this.rbFTP, "Ensure the FTP details are filled in on the FTP tab");
            this.rbFTP.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 20);
            this.txtName.TabIndex = 0;
            this.ToolTip1.SetToolTip(this.txtName, "Name for this watcher setting");
            // 
            // chkBackup
            // 
            this.chkBackup.AutoSize = true;
            this.chkBackup.Location = new System.Drawing.Point(6, 159);
            this.chkBackup.Name = "chkBackup";
            this.chkBackup.Size = new System.Drawing.Size(122, 17);
            this.chkBackup.TabIndex = 7;
            this.chkBackup.Text = "Create initial backup";
            this.ToolTip1.SetToolTip(this.chkBackup, "Create a full backup now");
            this.chkBackup.UseVisualStyleBackColor = true;
            // 
            // butBackupFolder
            // 
            this.butBackupFolder.Location = new System.Drawing.Point(297, 66);
            this.butBackupFolder.Name = "butBackupFolder";
            this.butBackupFolder.Size = new System.Drawing.Size(26, 23);
            this.butBackupFolder.TabIndex = 5;
            this.butBackupFolder.Text = "...";
            this.butBackupFolder.UseVisualStyleBackColor = true;
            // 
            // btnWatchFolder
            // 
            this.btnWatchFolder.Location = new System.Drawing.Point(297, 41);
            this.btnWatchFolder.Name = "btnWatchFolder";
            this.btnWatchFolder.Size = new System.Drawing.Size(26, 23);
            this.btnWatchFolder.TabIndex = 3;
            this.btnWatchFolder.Text = "...";
            this.btnWatchFolder.UseVisualStyleBackColor = true;
            // 
            // txtWatch
            // 
            this.txtWatch.Location = new System.Drawing.Point(80, 41);
            this.txtWatch.Name = "txtWatch";
            this.txtWatch.Size = new System.Drawing.Size(211, 20);
            this.txtWatch.TabIndex = 2;
            this.ToolTip1.SetToolTip(this.txtWatch, "Absolute or relative path (to AutoVer) to the files and folders to watch for back" +
        "up ");
            // 
            // txtBackup
            // 
            this.txtBackup.Location = new System.Drawing.Point(80, 68);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.Size = new System.Drawing.Size(211, 20);
            this.txtBackup.TabIndex = 4;
            this.ToolTip1.SetToolTip(this.txtBackup, "Absolute or relative path (to watch folder) to the backup folder. May be an FTP a" +
        "ddress");
            // 
            // lblBackFold
            // 
            this.lblBackFold.AutoSize = true;
            this.lblBackFold.Location = new System.Drawing.Point(3, 71);
            this.lblBackFold.Name = "lblBackFold";
            this.lblBackFold.Size = new System.Drawing.Size(59, 13);
            this.lblBackFold.TabIndex = 1;
            this.lblBackFold.Text = "Backup to:";
            // 
            // lblWatchFold
            // 
            this.lblWatchFold.AutoSize = true;
            this.lblWatchFold.Location = new System.Drawing.Point(3, 44);
            this.lblWatchFold.Name = "lblWatchFold";
            this.lblWatchFold.Size = new System.Drawing.Size(71, 13);
            this.lblWatchFold.TabIndex = 0;
            this.lblWatchFold.Text = "Watch folder:";
            // 
            // ToolTip1
            // 
            this.ToolTip1.AutomaticDelay = 200;
            this.ToolTip1.AutoPopDelay = 5000;
            this.ToolTip1.InitialDelay = 200;
            this.ToolTip1.ReshowDelay = 40;
            // 
            // chkFTPPassive
            // 
            this.chkFTPPassive.AutoSize = true;
            this.chkFTPPassive.Checked = true;
            this.chkFTPPassive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFTPPassive.Location = new System.Drawing.Point(10, 117);
            this.chkFTPPassive.Name = "chkFTPPassive";
            this.chkFTPPassive.Size = new System.Drawing.Size(63, 17);
            this.chkFTPPassive.TabIndex = 4;
            this.chkFTPPassive.Text = "Passive";
            this.ToolTip1.SetToolTip(this.chkFTPPassive, "Passive or Active connection");
            this.chkFTPPassive.UseVisualStyleBackColor = true;
            // 
            // txtFTPPassword
            // 
            this.txtFTPPassword.Location = new System.Drawing.Point(76, 82);
            this.txtFTPPassword.Name = "txtFTPPassword";
            this.txtFTPPassword.PasswordChar = '*';
            this.txtFTPPassword.Size = new System.Drawing.Size(100, 20);
            this.txtFTPPassword.TabIndex = 3;
            this.ToolTip1.SetToolTip(this.txtFTPPassword, "Password or email for anonymous");
            this.txtFTPPassword.UseSystemPasswordChar = true;
            // 
            // txtFTPLogin
            // 
            this.txtFTPLogin.Location = new System.Drawing.Point(76, 56);
            this.txtFTPLogin.Name = "txtFTPLogin";
            this.txtFTPLogin.Size = new System.Drawing.Size(100, 20);
            this.txtFTPLogin.TabIndex = 2;
            this.ToolTip1.SetToolTip(this.txtFTPLogin, "Login or User ID. Blank for anonymous");
            // 
            // txtFTPHost
            // 
            this.txtFTPHost.Location = new System.Drawing.Point(76, 30);
            this.txtFTPHost.Name = "txtFTPHost";
            this.txtFTPHost.Size = new System.Drawing.Size(178, 20);
            this.txtFTPHost.TabIndex = 1;
            this.ToolTip1.SetToolTip(this.txtFTPHost, "FTP URL");
            // 
            // txtDateTimeStamp
            // 
            this.txtDateTimeStamp.Location = new System.Drawing.Point(105, 102);
            this.txtDateTimeStamp.MaxLength = 50;
            this.txtDateTimeStamp.Name = "txtDateTimeStamp";
            this.txtDateTimeStamp.Size = new System.Drawing.Size(116, 20);
            this.txtDateTimeStamp.TabIndex = 2;
            this.txtDateTimeStamp.Text = "yyMMddHHmmss";
            this.ToolTip1.SetToolTip(this.txtDateTimeStamp, "Timestamp format. No colons or backslashes (:\\)");
            // 
            // chkCompareBeforeCopy
            // 
            this.chkCompareBeforeCopy.AutoSize = true;
            this.chkCompareBeforeCopy.Location = new System.Drawing.Point(6, 173);
            this.chkCompareBeforeCopy.Name = "chkCompareBeforeCopy";
            this.chkCompareBeforeCopy.Size = new System.Drawing.Size(165, 17);
            this.chkCompareBeforeCopy.TabIndex = 37;
            this.chkCompareBeforeCopy.Text = "Only copy if content changed";
            this.ToolTip1.SetToolTip(this.chkCompareBeforeCopy, "If not checked, AutoVer will copy the file every time it is saved - even if the f" +
        "ile content did not change. Checking for changes slows performance.");
            this.chkCompareBeforeCopy.UseVisualStyleBackColor = true;
            // 
            // txtSettleDelay
            // 
            this.txtSettleDelay.Location = new System.Drawing.Point(87, 124);
            this.txtSettleDelay.MaxLength = 4;
            this.txtSettleDelay.Name = "txtSettleDelay";
            this.txtSettleDelay.Size = new System.Drawing.Size(40, 20);
            this.txtSettleDelay.TabIndex = 29;
            this.txtSettleDelay.Text = "1";
            this.ToolTip1.SetToolTip(this.txtSettleDelay, "Time in seconds after a change to a file before the copy/rename etc is done. (0.0" +
        "1 to 300s) ");
            // 
            // chkRunCopyFirst
            // 
            this.chkRunCopyFirst.AutoSize = true;
            this.chkRunCopyFirst.Checked = true;
            this.chkRunCopyFirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRunCopyFirst.Location = new System.Drawing.Point(280, 104);
            this.chkRunCopyFirst.Name = "chkRunCopyFirst";
            this.chkRunCopyFirst.Size = new System.Drawing.Size(85, 17);
            this.chkRunCopyFirst.TabIndex = 27;
            this.chkRunCopyFirst.Text = "Copy file first";
            this.ToolTip1.SetToolTip(this.chkRunCopyFirst, "Copy the file before running the specified app. Unticked = no copying done (your " +
        "app to do)");
            this.chkRunCopyFirst.UseVisualStyleBackColor = true;
            // 
            // txtRunCopy
            // 
            this.txtRunCopy.Location = new System.Drawing.Point(87, 102);
            this.txtRunCopy.Name = "txtRunCopy";
            this.txtRunCopy.Size = new System.Drawing.Size(187, 20);
            this.txtRunCopy.TabIndex = 25;
            this.ToolTip1.SetToolTip(this.txtRunCopy, "Run this app on each file change/copy. {0} = original file, {1} = Backup file");
            // 
            // txtEnsureTime
            // 
            this.txtEnsureTime.Location = new System.Drawing.Point(247, 195);
            this.txtEnsureTime.MaxLength = 5;
            this.txtEnsureTime.Name = "txtEnsureTime";
            this.txtEnsureTime.Size = new System.Drawing.Size(40, 20);
            this.txtEnsureTime.TabIndex = 24;
            this.ToolTip1.SetToolTip(this.txtEnsureTime, "Specifiy the time of day in 24 hour format (ie 23:00) or leave blank for auto.");
            // 
            // txtMaxFileSize
            // 
            this.txtMaxFileSize.Location = new System.Drawing.Point(87, 80);
            this.txtMaxFileSize.Name = "txtMaxFileSize";
            this.txtMaxFileSize.Size = new System.Drawing.Size(92, 20);
            this.txtMaxFileSize.TabIndex = 4;
            this.txtMaxFileSize.Text = "1G";
            this.ToolTip1.SetToolTip(this.txtMaxFileSize, "Maximum file size in bytes to include in backup");
            // 
            // txtExcludeFiles
            // 
            this.txtExcludeFiles.Location = new System.Drawing.Point(87, 36);
            this.txtExcludeFiles.Name = "txtExcludeFiles";
            this.txtExcludeFiles.Size = new System.Drawing.Size(187, 20);
            this.txtExcludeFiles.TabIndex = 2;
            this.txtExcludeFiles.Text = "*.tmp;~$*.doc";
            this.ToolTip1.SetToolTip(this.txtExcludeFiles, "File masks to exclude. \";\" separates multiple items");
            // 
            // txtExcludeFolders
            // 
            this.txtExcludeFolders.Location = new System.Drawing.Point(87, 58);
            this.txtExcludeFolders.Name = "txtExcludeFolders";
            this.txtExcludeFolders.Size = new System.Drawing.Size(187, 20);
            this.txtExcludeFolders.TabIndex = 3;
            this.ToolTip1.SetToolTip(this.txtExcludeFolders, "Folders (or masks) to exclude. \";\" separates multiple items. ");
            // 
            // txtIncludeFiles
            // 
            this.txtIncludeFiles.Location = new System.Drawing.Point(87, 14);
            this.txtIncludeFiles.Name = "txtIncludeFiles";
            this.txtIncludeFiles.Size = new System.Drawing.Size(187, 20);
            this.txtIncludeFiles.TabIndex = 1;
            this.txtIncludeFiles.Text = "*.*";
            this.ToolTip1.SetToolTip(this.txtIncludeFiles, "File masks to include. \";\" separates multiple items");
            // 
            // HelpProvider1
            // 
            this.HelpProvider1.HelpNamespace = "AutoVer.chm";
            // 
            // btnHelp
            // 
            this.HelpProvider1.SetHelpKeyword(this.btnHelp, "ApplicationSettings");
            this.HelpProvider1.SetHelpString(this.btnHelp, "Help me###");
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(15, 324);
            this.btnHelp.Name = "btnHelp";
            this.HelpProvider1.SetShowHelp(this.btnHelp, true);
            this.btnHelp.Size = new System.Drawing.Size(100, 23);
            this.btnHelp.TabIndex = 14;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // lblFtpAnon
            // 
            this.lblFtpAnon.AutoSize = true;
            this.lblFtpAnon.Location = new System.Drawing.Point(182, 59);
            this.lblFtpAnon.Name = "lblFtpAnon";
            this.lblFtpAnon.Size = new System.Drawing.Size(100, 13);
            this.lblFtpAnon.TabIndex = 7;
            this.lblFtpAnon.Text = "Blank = anonymous";
            // 
            // lblFtpPass
            // 
            this.lblFtpPass.AutoSize = true;
            this.lblFtpPass.Location = new System.Drawing.Point(7, 89);
            this.lblFtpPass.Name = "lblFtpPass";
            this.lblFtpPass.Size = new System.Drawing.Size(56, 13);
            this.lblFtpPass.TabIndex = 6;
            this.lblFtpPass.Text = "Password:";
            // 
            // lblFtpUser
            // 
            this.lblFtpUser.AutoSize = true;
            this.lblFtpUser.Location = new System.Drawing.Point(7, 59);
            this.lblFtpUser.Name = "lblFtpUser";
            this.lblFtpUser.Size = new System.Drawing.Size(63, 13);
            this.lblFtpUser.TabIndex = 4;
            this.lblFtpUser.Text = "User Name:";
            // 
            // butOK
            // 
            this.butOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butOK.Location = new System.Drawing.Point(184, 324);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(100, 23);
            this.butOK.TabIndex = 12;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            // 
            // lblFtpHost
            // 
            this.lblFtpHost.AutoSize = true;
            this.lblFtpHost.Location = new System.Drawing.Point(7, 33);
            this.lblFtpHost.Name = "lblFtpHost";
            this.lblFtpHost.Size = new System.Drawing.Size(32, 13);
            this.lblFtpHost.TabIndex = 2;
            this.lblFtpHost.Text = "Host:";
            // 
            // lblFtpIf
            // 
            this.lblFtpIf.AutoSize = true;
            this.lblFtpIf.Location = new System.Drawing.Point(7, 7);
            this.lblFtpIf.Name = "lblFtpIf";
            this.lblFtpIf.Size = new System.Drawing.Size(150, 13);
            this.lblFtpIf.TabIndex = 0;
            this.lblFtpIf.Text = "If FTP Backup folder is used...";
            // 
            // lblTimeStamp
            // 
            this.lblTimeStamp.AutoSize = true;
            this.lblTimeStamp.Location = new System.Drawing.Point(7, 105);
            this.lblTimeStamp.Name = "lblTimeStamp";
            this.lblTimeStamp.Size = new System.Drawing.Size(92, 13);
            this.lblTimeStamp.TabIndex = 31;
            this.lblTimeStamp.Text = "Date/Time stamp:";
            // 
            // butCancel
            // 
            this.butCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCancel.Location = new System.Drawing.Point(290, 324);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(100, 23);
            this.butCancel.TabIndex = 13;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // tabAdv
            // 
            this.tabAdv.Controls.Add(this.chkCompareBeforeCopy);
            this.tabAdv.Controls.Add(this.txtSettleDelay);
            this.tabAdv.Controls.Add(this.lblSettle);
            this.tabAdv.Controls.Add(this.chkRunCopyFirst);
            this.tabAdv.Controls.Add(this.lblRunCopy);
            this.tabAdv.Controls.Add(this.txtRunCopy);
            this.tabAdv.Controls.Add(this.txtEnsureTime);
            this.tabAdv.Controls.Add(this.rbEnsureHourly);
            this.tabAdv.Controls.Add(this.rbEnsureDaily);
            this.tabAdv.Controls.Add(this.rbEnsureNever);
            this.tabAdv.Controls.Add(this.lblSync);
            this.tabAdv.Controls.Add(this.lblFoldSep);
            this.tabAdv.Controls.Add(this.lblFileSep);
            this.tabAdv.Controls.Add(this.txtMaxFileSize);
            this.tabAdv.Controls.Add(this.lblMaxFileSize);
            this.tabAdv.Controls.Add(this.txtExcludeFiles);
            this.tabAdv.Controls.Add(this.lblExclFiles);
            this.tabAdv.Controls.Add(this.txtExcludeFolders);
            this.tabAdv.Controls.Add(this.lblExclFold);
            this.tabAdv.Controls.Add(this.txtIncludeFiles);
            this.tabAdv.Controls.Add(this.lblIncFiles);
            this.tabAdv.Controls.Add(this.chkDelete);
            this.tabAdv.Location = new System.Drawing.Point(4, 22);
            this.tabAdv.Name = "tabAdv";
            this.tabAdv.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdv.Size = new System.Drawing.Size(373, 282);
            this.tabAdv.TabIndex = 1;
            this.tabAdv.Text = "Advanced";
            this.tabAdv.UseVisualStyleBackColor = true;
            // 
            // lblSettle
            // 
            this.lblSettle.AutoSize = true;
            this.lblSettle.Location = new System.Drawing.Point(4, 127);
            this.lblSettle.Name = "lblSettle";
            this.lblSettle.Size = new System.Drawing.Size(71, 13);
            this.lblSettle.TabIndex = 28;
            this.lblSettle.Text = "Settling Time:";
            // 
            // lblRunCopy
            // 
            this.lblRunCopy.AutoSize = true;
            this.lblRunCopy.Location = new System.Drawing.Point(4, 105);
            this.lblRunCopy.Name = "lblRunCopy";
            this.lblRunCopy.Size = new System.Drawing.Size(71, 13);
            this.lblRunCopy.TabIndex = 26;
            this.lblRunCopy.Text = "Run on copy:";
            // 
            // rbEnsureHourly
            // 
            this.rbEnsureHourly.AutoSize = true;
            this.rbEnsureHourly.Location = new System.Drawing.Point(303, 196);
            this.rbEnsureHourly.Name = "rbEnsureHourly";
            this.rbEnsureHourly.Size = new System.Drawing.Size(55, 17);
            this.rbEnsureHourly.TabIndex = 23;
            this.rbEnsureHourly.Text = "Hourly";
            this.rbEnsureHourly.UseVisualStyleBackColor = true;
            // 
            // rbEnsureDaily
            // 
            this.rbEnsureDaily.AutoSize = true;
            this.rbEnsureDaily.Checked = true;
            this.rbEnsureDaily.Location = new System.Drawing.Point(200, 196);
            this.rbEnsureDaily.Name = "rbEnsureDaily";
            this.rbEnsureDaily.Size = new System.Drawing.Size(51, 17);
            this.rbEnsureDaily.TabIndex = 22;
            this.rbEnsureDaily.TabStop = true;
            this.rbEnsureDaily.Text = "Daily:";
            this.rbEnsureDaily.UseVisualStyleBackColor = true;
            // 
            // rbEnsureNever
            // 
            this.rbEnsureNever.AutoSize = true;
            this.rbEnsureNever.Location = new System.Drawing.Point(139, 196);
            this.rbEnsureNever.Name = "rbEnsureNever";
            this.rbEnsureNever.Size = new System.Drawing.Size(54, 17);
            this.rbEnsureNever.TabIndex = 21;
            this.rbEnsureNever.Text = "Never";
            this.rbEnsureNever.UseVisualStyleBackColor = true;
            // 
            // lblSync
            // 
            this.lblSync.AutoSize = true;
            this.lblSync.Location = new System.Drawing.Point(5, 198);
            this.lblSync.Name = "lblSync";
            this.lblSync.Size = new System.Drawing.Size(107, 13);
            this.lblSync.TabIndex = 20;
            this.lblSync.Text = "Synchronise backup:";
            // 
            // lblFoldSep
            // 
            this.lblFoldSep.AutoSize = true;
            this.lblFoldSep.Location = new System.Drawing.Point(295, 61);
            this.lblFoldSep.Name = "lblFoldSep";
            this.lblFoldSep.Size = new System.Drawing.Size(65, 13);
            this.lblFoldSep.TabIndex = 19;
            this.lblFoldSep.Text = "(; separates)";
            // 
            // lblFileSep
            // 
            this.lblFileSep.AutoSize = true;
            this.lblFileSep.Location = new System.Drawing.Point(295, 39);
            this.lblFileSep.Name = "lblFileSep";
            this.lblFileSep.Size = new System.Drawing.Size(65, 13);
            this.lblFileSep.TabIndex = 18;
            this.lblFileSep.Text = "(; separates)";
            // 
            // lblMaxFileSize
            // 
            this.lblMaxFileSize.AutoSize = true;
            this.lblMaxFileSize.Location = new System.Drawing.Point(3, 83);
            this.lblMaxFileSize.Name = "lblMaxFileSize";
            this.lblMaxFileSize.Size = new System.Drawing.Size(72, 13);
            this.lblMaxFileSize.TabIndex = 15;
            this.lblMaxFileSize.Text = "Max File Size:";
            // 
            // lblExclFiles
            // 
            this.lblExclFiles.AutoSize = true;
            this.lblExclFiles.Location = new System.Drawing.Point(3, 39);
            this.lblExclFiles.Name = "lblExclFiles";
            this.lblExclFiles.Size = new System.Drawing.Size(72, 13);
            this.lblExclFiles.TabIndex = 11;
            this.lblExclFiles.Text = "Exclude Files:";
            // 
            // lblExclFold
            // 
            this.lblExclFold.AutoSize = true;
            this.lblExclFold.Location = new System.Drawing.Point(3, 61);
            this.lblExclFold.Name = "lblExclFold";
            this.lblExclFold.Size = new System.Drawing.Size(85, 13);
            this.lblExclFold.TabIndex = 9;
            this.lblExclFold.Text = "Exclude Folders:";
            // 
            // lblIncFiles
            // 
            this.lblIncFiles.AutoSize = true;
            this.lblIncFiles.Location = new System.Drawing.Point(3, 17);
            this.lblIncFiles.Name = "lblIncFiles";
            this.lblIncFiles.Size = new System.Drawing.Size(69, 13);
            this.lblIncFiles.TabIndex = 7;
            this.lblIncFiles.Text = "Include Files:";
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(6, 150);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(230, 17);
            this.chkDelete.TabIndex = 6;
            this.chkDelete.Text = "Delete backup files when original is deleted";
            this.chkDelete.UseVisualStyleBackColor = true;
            // 
            // tabVer
            // 
            this.tabVer.Controls.Add(this.grpArc);
            this.tabVer.Controls.Add(this.grpArcTo);
            this.tabVer.Controls.Add(this.grpVerMax);
            this.tabVer.Controls.Add(this.grpVerMode);
            this.tabVer.Controls.Add(this.lblTimeStamp);
            this.tabVer.Controls.Add(this.txtDateTimeStamp);
            this.tabVer.Location = new System.Drawing.Point(4, 22);
            this.tabVer.Name = "tabVer";
            this.tabVer.Padding = new System.Windows.Forms.Padding(3);
            this.tabVer.Size = new System.Drawing.Size(373, 282);
            this.tabVer.TabIndex = 2;
            this.tabVer.Text = "Versioning";
            this.tabVer.UseVisualStyleBackColor = true;
            // 
            // tmrEnsureSyncUpdates
            // 
            this.tmrEnsureSyncUpdates.Interval = 1000;
            // 
            // tabFTP
            // 
            this.tabFTP.Controls.Add(this.chkFTPPassive);
            this.tabFTP.Controls.Add(this.lblFtpAnon);
            this.tabFTP.Controls.Add(this.lblFtpPass);
            this.tabFTP.Controls.Add(this.txtFTPPassword);
            this.tabFTP.Controls.Add(this.lblFtpUser);
            this.tabFTP.Controls.Add(this.txtFTPLogin);
            this.tabFTP.Controls.Add(this.lblFtpHost);
            this.tabFTP.Controls.Add(this.txtFTPHost);
            this.tabFTP.Controls.Add(this.lblFtpIf);
            this.tabFTP.Location = new System.Drawing.Point(4, 22);
            this.tabFTP.Name = "tabFTP";
            this.tabFTP.Padding = new System.Windows.Forms.Padding(3);
            this.tabFTP.Size = new System.Drawing.Size(373, 282);
            this.tabFTP.TabIndex = 3;
            this.tabFTP.Text = "FTP";
            this.tabFTP.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGen);
            this.tabControl.Controls.Add(this.tabAdv);
            this.tabControl.Controls.Add(this.tabVer);
            this.tabControl.Controls.Add(this.tabFTP);
            this.tabControl.Location = new System.Drawing.Point(12, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(381, 308);
            this.tabControl.TabIndex = 11;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 357);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpProvider1.SetHelpKeyword(this, "3");
            this.HelpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.HelpProvider1.SetHelpString(this, "3");
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.HelpProvider1.SetShowHelp(this, true);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.grpVerMax.ResumeLayout(false);
            this.grpVerMax.PerformLayout();
            this.grpArcTo.ResumeLayout(false);
            this.grpArcTo.PerformLayout();
            this.grpArc.ResumeLayout(false);
            this.grpArc.PerformLayout();
            this.grpVerMode.ResumeLayout(false);
            this.grpVerMode.PerformLayout();
            this.tabGen.ResumeLayout(false);
            this.tabGen.PerformLayout();
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.tabAdv.ResumeLayout(false);
            this.tabAdv.PerformLayout();
            this.tabVer.ResumeLayout(false);
            this.tabVer.PerformLayout();
            this.tabFTP.ResumeLayout(false);
            this.tabFTP.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RadioButton rbVersionPrev;
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal System.Windows.Forms.TextBox txtVerRateS;
        internal System.Windows.Forms.Label lblHourMinSec;
        internal System.Windows.Forms.TextBox txtVerRateM;
        internal System.Windows.Forms.TextBox txtVerRateH;
        internal System.Windows.Forms.RadioButton rbVerRate;
        internal System.Windows.Forms.RadioButton rbVerAll;
        internal System.Windows.Forms.GroupBox grpVerMax;
        internal System.Windows.Forms.RadioButton rbZipModeF;
        internal System.Windows.Forms.RadioButton rbZipModeD;
        internal System.Windows.Forms.RadioButton rbZipModeW;
        internal System.Windows.Forms.Label lblZip1;
        internal System.Windows.Forms.GroupBox grpArcTo;
        internal System.Windows.Forms.TextBox txtMaxVersionAge;
        internal System.Windows.Forms.Label lblVerDays;
        internal System.Windows.Forms.RadioButton radNothing;
        internal System.Windows.Forms.RadioButton radDelete;
        internal System.Windows.Forms.RadioButton radZip;
        internal System.Windows.Forms.RadioButton rad7Zip;
        internal System.Windows.Forms.GroupBox grpArc;
        internal System.Windows.Forms.Label lblVersOlder;
        internal System.Windows.Forms.GroupBox grpVerMode;
        internal System.Windows.Forms.RadioButton rbVersionAll;
        internal System.Windows.Forms.RadioButton rbNone;
        internal System.ComponentModel.BackgroundWorker bwBackupRestore;
        internal System.Windows.Forms.TabPage tabGen;
        internal System.Windows.Forms.CheckBox chkShowEvents;
        internal System.Windows.Forms.CheckBox chkSubFolders;
        internal System.Windows.Forms.CheckBox chkShowErrors;
        internal System.Windows.Forms.Label lblStats;
        internal System.Windows.Forms.Label lblCounts;
        internal System.Windows.Forms.CheckBox chkEnabled;
        internal System.Windows.Forms.GroupBox grpType;
        internal System.Windows.Forms.RadioButton rbFolder;
        internal System.Windows.Forms.RadioButton rbFTP;
        internal System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.CheckBox chkBackup;
        internal System.Windows.Forms.Button butBackupFolder;
        internal System.Windows.Forms.Button btnWatchFolder;
        internal System.Windows.Forms.TextBox txtWatch;
        internal System.Windows.Forms.TextBox txtBackup;
        internal System.Windows.Forms.Label lblBackFold;
        internal System.Windows.Forms.Label lblWatchFold;
        internal System.Windows.Forms.CheckBox chkFTPPassive;
        internal System.Windows.Forms.TextBox txtFTPPassword;
        internal System.Windows.Forms.TextBox txtFTPLogin;
        internal System.Windows.Forms.TextBox txtFTPHost;
        internal System.Windows.Forms.TextBox txtDateTimeStamp;
        internal System.Windows.Forms.CheckBox chkCompareBeforeCopy;
        internal System.Windows.Forms.TextBox txtSettleDelay;
        internal System.Windows.Forms.CheckBox chkRunCopyFirst;
        internal System.Windows.Forms.TextBox txtRunCopy;
        internal System.Windows.Forms.TextBox txtEnsureTime;
        internal System.Windows.Forms.TextBox txtMaxFileSize;
        internal System.Windows.Forms.TextBox txtExcludeFiles;
        internal System.Windows.Forms.TextBox txtExcludeFolders;
        internal System.Windows.Forms.TextBox txtIncludeFiles;
        internal System.Windows.Forms.HelpProvider HelpProvider1;
        internal System.Windows.Forms.Button btnHelp;
        internal System.Windows.Forms.Label lblFtpAnon;
        internal System.Windows.Forms.Label lblFtpPass;
        internal System.Windows.Forms.Label lblFtpUser;
        internal System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog1;
        internal System.Windows.Forms.Button butOK;
        internal System.Windows.Forms.Label lblFtpHost;
        internal System.Windows.Forms.Label lblFtpIf;
        internal System.Windows.Forms.Label lblTimeStamp;
        internal System.Windows.Forms.Button butCancel;
        internal System.Windows.Forms.TabPage tabAdv;
        internal System.Windows.Forms.Label lblSettle;
        internal System.Windows.Forms.Label lblRunCopy;
        internal System.Windows.Forms.RadioButton rbEnsureHourly;
        internal System.Windows.Forms.RadioButton rbEnsureDaily;
        internal System.Windows.Forms.RadioButton rbEnsureNever;
        internal System.Windows.Forms.Label lblSync;
        internal System.Windows.Forms.Label lblFoldSep;
        internal System.Windows.Forms.Label lblFileSep;
        internal System.Windows.Forms.Label lblMaxFileSize;
        internal System.Windows.Forms.Label lblExclFiles;
        internal System.Windows.Forms.Label lblExclFold;
        internal System.Windows.Forms.Label lblIncFiles;
        internal System.Windows.Forms.CheckBox chkDelete;
        internal System.Windows.Forms.TabPage tabVer;
        internal System.Windows.Forms.Timer tmrEnsureSyncUpdates;
        internal System.Windows.Forms.TabPage tabFTP;
        internal System.Windows.Forms.TabControl tabControl;
    }
}