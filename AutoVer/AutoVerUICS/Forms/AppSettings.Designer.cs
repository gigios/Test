namespace AutoVerUICS.Forms
{
    partial class AppSettings
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
            this.ToolTip1 = new System.Windows.Forms.ToolTip();
            this.rbConfigLocal = new System.Windows.Forms.RadioButton();
            this.rbConfigUser = new System.Windows.Forms.RadioButton();
            this.rbConfigCommon = new System.Windows.Forms.RadioButton();
            this.chkAutoElevate = new System.Windows.Forms.CheckBox();
            this.chkRecycleBin = new System.Windows.Forms.CheckBox();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.chkWMI = new System.Windows.Forms.CheckBox();
            this.txtTextViewer = new System.Windows.Forms.TextBox();
            this.chkStartup = new System.Windows.Forms.CheckBox();
            this.txtImageViewer = new System.Windows.Forms.TextBox();
            this.txtApp = new System.Windows.Forms.TextBox();
            this.lblConfigLoc = new System.Windows.Forms.Label();
            this.btnConfigFolder = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnImageView = new System.Windows.Forms.Button();
            this.lblImageView = new System.Windows.Forms.Label();
            this.btnTextView = new System.Windows.Forms.Button();
            this.lblTextView = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnCompApp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblCompareApp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbConfigLocal
            // 
            this.rbConfigLocal.AutoSize = true;
            this.rbConfigLocal.Location = new System.Drawing.Point(221, 102);
            this.rbConfigLocal.Name = "rbConfigLocal";
            this.rbConfigLocal.Size = new System.Drawing.Size(95, 17);
            this.rbConfigLocal.TabIndex = 43;
            this.rbConfigLocal.Text = "Local/Portable";
            this.ToolTip1.SetToolTip(this.rbConfigLocal, "Settings are stored with the AutoVer executable program (If running as a portable" +
        " app)");
            this.rbConfigLocal.UseVisualStyleBackColor = true;
            // 
            // rbConfigUser
            // 
            this.rbConfigUser.AutoSize = true;
            this.rbConfigUser.Location = new System.Drawing.Point(169, 102);
            this.rbConfigUser.Name = "rbConfigUser";
            this.rbConfigUser.Size = new System.Drawing.Size(47, 17);
            this.rbConfigUser.TabIndex = 42;
            this.rbConfigUser.Text = "User";
            this.ToolTip1.SetToolTip(this.rbConfigUser, "Settings apply only to the current Windows user");
            this.rbConfigUser.UseVisualStyleBackColor = true;
            // 
            // rbConfigCommon
            // 
            this.rbConfigCommon.AutoSize = true;
            this.rbConfigCommon.Checked = true;
            this.rbConfigCommon.Location = new System.Drawing.Point(101, 102);
            this.rbConfigCommon.Name = "rbConfigCommon";
            this.rbConfigCommon.Size = new System.Drawing.Size(66, 17);
            this.rbConfigCommon.TabIndex = 41;
            this.rbConfigCommon.TabStop = true;
            this.rbConfigCommon.Text = "Common";
            this.ToolTip1.SetToolTip(this.rbConfigCommon, "Settings are common to all Windows users (recommended default)");
            this.rbConfigCommon.UseVisualStyleBackColor = true;
            // 
            // chkAutoElevate
            // 
            this.chkAutoElevate.AutoSize = true;
            this.chkAutoElevate.Checked = true;
            this.chkAutoElevate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoElevate.Location = new System.Drawing.Point(14, 150);
            this.chkAutoElevate.Name = "chkAutoElevate";
            this.chkAutoElevate.Size = new System.Drawing.Size(175, 17);
            this.chkAutoElevate.TabIndex = 38;
            this.chkAutoElevate.Text = "Auto-Elevate UI without service";
            this.ToolTip1.SetToolTip(this.chkAutoElevate, "If not running the service or as Admin, elevate to Admin to run (may prompt you o" +
        "n each start)");
            this.chkAutoElevate.UseVisualStyleBackColor = true;
            // 
            // chkRecycleBin
            // 
            this.chkRecycleBin.AutoSize = true;
            this.chkRecycleBin.Location = new System.Drawing.Point(14, 196);
            this.chkRecycleBin.Name = "chkRecycleBin";
            this.chkRecycleBin.Size = new System.Drawing.Size(142, 17);
            this.chkRecycleBin.TabIndex = 37;
            this.chkRecycleBin.Text = "Delete uses Recycle Bin";
            this.ToolTip1.SetToolTip(this.chkRecycleBin, "When files are deleted, use the recycle bin (slower). Otherwise permanently delet" +
        "e (default).");
            this.chkRecycleBin.UseVisualStyleBackColor = true;
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.Location = new System.Drawing.Point(14, 219);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(99, 17);
            this.chkDebug.TabIndex = 36;
            this.chkDebug.Text = "Debug Logging";
            this.ToolTip1.SetToolTip(this.chkDebug, "Increase the logging level to be more verbose (if trying to solve an issue)");
            this.chkDebug.UseVisualStyleBackColor = true;
            // 
            // chkWMI
            // 
            this.chkWMI.AutoSize = true;
            this.chkWMI.Checked = true;
            this.chkWMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWMI.Location = new System.Drawing.Point(14, 173);
            this.chkWMI.Name = "chkWMI";
            this.chkWMI.Size = new System.Drawing.Size(85, 17);
            this.chkWMI.TabIndex = 35;
            this.chkWMI.Text = "Enable WMI";
            this.ToolTip1.SetToolTip(this.chkWMI, "Use WMI for drive state detection (default). Otherwise it will poll the drives");
            this.chkWMI.UseVisualStyleBackColor = true;
            // 
            // txtTextViewer
            // 
            this.txtTextViewer.Location = new System.Drawing.Point(91, 45);
            this.txtTextViewer.Name = "txtTextViewer";
            this.txtTextViewer.Size = new System.Drawing.Size(214, 20);
            this.txtTextViewer.TabIndex = 24;
            this.ToolTip1.SetToolTip(this.txtTextViewer, "Path to the text viewer app such as: C:\\Program Files (x86)\\RJ TextEd\\TextEd.exe");
            // 
            // chkStartup
            // 
            this.chkStartup.AutoSize = true;
            this.chkStartup.Checked = true;
            this.chkStartup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStartup.Location = new System.Drawing.Point(14, 127);
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.Size = new System.Drawing.Size(161, 17);
            this.chkStartup.TabIndex = 28;
            this.chkStartup.Text = "Load UI on Windows startup";
            this.ToolTip1.SetToolTip(this.chkStartup, "Load automatically when Windows starts (default)");
            this.chkStartup.UseVisualStyleBackColor = true;
            // 
            // txtImageViewer
            // 
            this.txtImageViewer.Location = new System.Drawing.Point(91, 71);
            this.txtImageViewer.Name = "txtImageViewer";
            this.txtImageViewer.Size = new System.Drawing.Size(214, 20);
            this.txtImageViewer.TabIndex = 26;
            this.ToolTip1.SetToolTip(this.txtImageViewer, "Path to the image viewer app such as: C:\\Program Files (x86)\\IrfanView\\i_view32.e" +
        "xe");
            // 
            // txtApp
            // 
            this.txtApp.Location = new System.Drawing.Point(91, 17);
            this.txtApp.Name = "txtApp";
            this.txtApp.Size = new System.Drawing.Size(214, 20);
            this.txtApp.TabIndex = 22;
            this.ToolTip1.SetToolTip(this.txtApp, "Path to the compare app such as: C:\\Program Files\\WinMerge\\WinMergeU.exe \"{0}\" \"{" +
        "1}\"");
            // 
            // lblConfigLoc
            // 
            this.lblConfigLoc.AutoSize = true;
            this.lblConfigLoc.Location = new System.Drawing.Point(11, 104);
            this.lblConfigLoc.Name = "lblConfigLoc";
            this.lblConfigLoc.Size = new System.Drawing.Size(84, 13);
            this.lblConfigLoc.TabIndex = 40;
            this.lblConfigLoc.Text = "Config Location:";
            // 
            // btnConfigFolder
            // 
            this.btnConfigFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigFolder.Location = new System.Drawing.Point(222, 186);
            this.btnConfigFolder.Name = "btnConfigFolder";
            this.btnConfigFolder.Size = new System.Drawing.Size(100, 23);
            this.btnConfigFolder.TabIndex = 39;
            this.btnConfigFolder.Text = "Config Folder";
            this.btnConfigFolder.UseVisualStyleBackColor = true;
            // 
            // btnLog
            // 
            this.btnLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLog.Location = new System.Drawing.Point(222, 215);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(100, 23);
            this.btnLog.TabIndex = 33;
            this.btnLog.Text = "View Log";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // btnImageView
            // 
            this.btnImageView.Location = new System.Drawing.Point(311, 68);
            this.btnImageView.Name = "btnImageView";
            this.btnImageView.Size = new System.Drawing.Size(26, 23);
            this.btnImageView.TabIndex = 27;
            this.btnImageView.Text = "...";
            this.btnImageView.UseVisualStyleBackColor = true;
            // 
            // lblImageView
            // 
            this.lblImageView.AutoSize = true;
            this.lblImageView.Location = new System.Drawing.Point(11, 74);
            this.lblImageView.Name = "lblImageView";
            this.lblImageView.Size = new System.Drawing.Size(74, 13);
            this.lblImageView.TabIndex = 32;
            this.lblImageView.Text = "Image Viewer:";
            // 
            // btnTextView
            // 
            this.btnTextView.Location = new System.Drawing.Point(311, 42);
            this.btnTextView.Name = "btnTextView";
            this.btnTextView.Size = new System.Drawing.Size(26, 23);
            this.btnTextView.TabIndex = 25;
            this.btnTextView.Text = "...";
            this.btnTextView.UseVisualStyleBackColor = true;
            // 
            // lblTextView
            // 
            this.lblTextView.AutoSize = true;
            this.lblTextView.Location = new System.Drawing.Point(11, 48);
            this.lblTextView.Name = "lblTextView";
            this.lblTextView.Size = new System.Drawing.Size(66, 13);
            this.lblTextView.TabIndex = 29;
            this.lblTextView.Text = "Text Viewer:";
            // 
            // btnHelp
            // 
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(10, 256);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 23);
            this.btnHelp.TabIndex = 34;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnCompApp
            // 
            this.btnCompApp.Location = new System.Drawing.Point(311, 15);
            this.btnCompApp.Name = "btnCompApp";
            this.btnCompApp.Size = new System.Drawing.Size(26, 23);
            this.btnCompApp.TabIndex = 23;
            this.btnCompApp.Text = "...";
            this.btnCompApp.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(222, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(116, 256);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 23);
            this.btnOK.TabIndex = 30;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // lblCompareApp
            // 
            this.lblCompareApp.AutoSize = true;
            this.lblCompareApp.Location = new System.Drawing.Point(11, 20);
            this.lblCompareApp.Name = "lblCompareApp";
            this.lblCompareApp.Size = new System.Drawing.Size(74, 13);
            this.lblCompareApp.TabIndex = 21;
            this.lblCompareApp.Text = "Compare App:";
            // 
            // AppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 294);
            this.Controls.Add(this.rbConfigLocal);
            this.Controls.Add(this.rbConfigUser);
            this.Controls.Add(this.rbConfigCommon);
            this.Controls.Add(this.lblConfigLoc);
            this.Controls.Add(this.btnConfigFolder);
            this.Controls.Add(this.chkAutoElevate);
            this.Controls.Add(this.chkRecycleBin);
            this.Controls.Add(this.chkDebug);
            this.Controls.Add(this.chkWMI);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnImageView);
            this.Controls.Add(this.lblImageView);
            this.Controls.Add(this.btnTextView);
            this.Controls.Add(this.txtTextViewer);
            this.Controls.Add(this.lblTextView);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.chkStartup);
            this.Controls.Add(this.btnCompApp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtImageViewer);
            this.Controls.Add(this.txtApp);
            this.Controls.Add(this.lblCompareApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AppSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AutoVer Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolTip ToolTip1;
        internal System.Windows.Forms.RadioButton rbConfigLocal;
        internal System.Windows.Forms.RadioButton rbConfigUser;
        internal System.Windows.Forms.RadioButton rbConfigCommon;
        internal System.Windows.Forms.CheckBox chkAutoElevate;
        internal System.Windows.Forms.CheckBox chkRecycleBin;
        internal System.Windows.Forms.CheckBox chkDebug;
        internal System.Windows.Forms.CheckBox chkWMI;
        internal System.Windows.Forms.TextBox txtTextViewer;
        internal System.Windows.Forms.CheckBox chkStartup;
        internal System.Windows.Forms.TextBox txtImageViewer;
        internal System.Windows.Forms.TextBox txtApp;
        internal System.Windows.Forms.Label lblConfigLoc;
        internal System.Windows.Forms.Button btnConfigFolder;
        internal System.Windows.Forms.Button btnLog;
        internal System.Windows.Forms.Button btnImageView;
        internal System.Windows.Forms.Label lblImageView;
        internal System.Windows.Forms.Button btnTextView;
        internal System.Windows.Forms.Label lblTextView;
        internal System.Windows.Forms.Button btnHelp;
        internal System.Windows.Forms.Button btnCompApp;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.Label lblCompareApp;
    }
}