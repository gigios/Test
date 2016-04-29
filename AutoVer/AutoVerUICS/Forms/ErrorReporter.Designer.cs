namespace AutoVerUICS.Forms
{
    partial class ErrorReporter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorReporter));
            this.txtRecreate = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtNameEmail = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtErrorText = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lklErrorReport = new System.Windows.Forms.LinkLabel();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRecreate
            // 
            this.txtRecreate.Location = new System.Drawing.Point(39, 187);
            this.txtRecreate.Name = "txtRecreate";
            this.txtRecreate.Size = new System.Drawing.Size(465, 20);
            this.txtRecreate.TabIndex = 24;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(36, 171);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(335, 13);
            this.Label5.TabIndex = 23;
            this.Label5.Text = "What you did just before this error occured (how to recreate the error):";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(36, 132);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(90, 13);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "Your name/email:";
            // 
            // txtNameEmail
            // 
            this.txtNameEmail.Location = new System.Drawing.Point(39, 148);
            this.txtNameEmail.Name = "txtNameEmail";
            this.txtNameEmail.Size = new System.Drawing.Size(465, 20);
            this.txtNameEmail.TabIndex = 21;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(10, 115);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(129, 13);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "Optional extra information:";
            // 
            // txtErrorText
            // 
            this.txtErrorText.BackColor = System.Drawing.SystemColors.Control;
            this.txtErrorText.Location = new System.Drawing.Point(13, 25);
            this.txtErrorText.Multiline = true;
            this.txtErrorText.Name = "txtErrorText";
            this.txtErrorText.Size = new System.Drawing.Size(491, 52);
            this.txtErrorText.TabIndex = 19;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 264);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "{status}";
            // 
            // btnNo
            // 
            this.btnNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNo.Location = new System.Drawing.Point(258, 233);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(123, 23);
            this.btnNo.TabIndex = 17;
            this.btnNo.Text = "No, don\'t send";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(129, 233);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(123, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK, send";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // lklErrorReport
            // 
            this.lklErrorReport.AutoSize = true;
            this.lklErrorReport.Location = new System.Drawing.Point(420, 264);
            this.lklErrorReport.Name = "lklErrorReport";
            this.lklErrorReport.Size = new System.Drawing.Size(84, 13);
            this.lklErrorReport.TabIndex = 15;
            this.lklErrorReport.TabStop = true;
            this.lklErrorReport.Text = "View error report";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(10, 93);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(292, 13);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Details about this error can be sent to the author for analysis.";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(182, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(152, 13);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "A fatal error has occured.";
            // 
            // ErrorReporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 286);
            this.Controls.Add(this.txtRecreate);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtNameEmail);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtErrorText);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lklErrorReport);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ErrorReporter";
            this.Text = "Application Error";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtRecreate;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtNameEmail;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtErrorText;
        internal System.Windows.Forms.Label lblStatus;
        internal System.Windows.Forms.Button btnNo;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.LinkLabel lklErrorReport;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}