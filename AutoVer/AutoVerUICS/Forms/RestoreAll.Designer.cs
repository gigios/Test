namespace AutoVerUICS.Forms
{
    partial class RestoreAll
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.dtpRestore = new System.Windows.Forms.DateTimePicker();
            this.rbDtp = new System.Windows.Forms.RadioButton();
            this.rbNow = new System.Windows.Forms.RadioButton();
            this.Button2 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(13, 105);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(52, 13);
            this.lblMessage.TabIndex = 26;
            this.lblMessage.Text = "Waiting...";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(162, 70);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(10, 13);
            this.Label2.TabIndex = 25;
            this.Label2.Text = ":";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(173, 67);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(26, 20);
            this.txtMin.TabIndex = 24;
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(134, 67);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(26, 20);
            this.txtHour.TabIndex = 23;
            // 
            // dtpRestore
            // 
            this.dtpRestore.Location = new System.Drawing.Point(134, 41);
            this.dtpRestore.Name = "dtpRestore";
            this.dtpRestore.Size = new System.Drawing.Size(200, 20);
            this.dtpRestore.TabIndex = 22;
            // 
            // rbDtp
            // 
            this.rbDtp.AutoSize = true;
            this.rbDtp.Location = new System.Drawing.Point(113, 40);
            this.rbDtp.Name = "rbDtp";
            this.rbDtp.Size = new System.Drawing.Size(14, 13);
            this.rbDtp.TabIndex = 21;
            this.rbDtp.UseVisualStyleBackColor = true;
            // 
            // rbNow
            // 
            this.rbNow.AutoSize = true;
            this.rbNow.Checked = true;
            this.rbNow.Location = new System.Drawing.Point(113, 17);
            this.rbNow.Name = "rbNow";
            this.rbNow.Size = new System.Drawing.Size(47, 17);
            this.rbNow.TabIndex = 20;
            this.rbNow.TabStop = true;
            this.rbNow.Text = "Now";
            this.rbNow.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button2.Location = new System.Drawing.Point(290, 100);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(100, 23);
            this.Button2.TabIndex = 19;
            this.Button2.Text = "Cancel";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(184, 100);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 23);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(93, 13);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "Restore all files to:";
            // 
            // RestoreAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 141);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.dtpRestore);
            this.Controls.Add(this.rbDtp);
            this.Controls.Add(this.rbNow);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RestoreAll";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoVer Restore All";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblMessage;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtMin;
        internal System.Windows.Forms.TextBox txtHour;
        internal System.Windows.Forms.DateTimePicker dtpRestore;
        internal System.Windows.Forms.RadioButton rbDtp;
        internal System.Windows.Forms.RadioButton rbNow;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.Label Label1;
    }
}