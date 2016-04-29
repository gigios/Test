namespace AutoVerUICS.Forms
{
    partial class ViewFile
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
            this.txtApp = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbAssoc = new System.Windows.Forms.RadioButton();
            this.btnHelp = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtApp
            // 
            this.txtApp.Location = new System.Drawing.Point(93, 64);
            this.txtApp.Name = "txtApp";
            this.txtApp.Size = new System.Drawing.Size(214, 20);
            this.txtApp.TabIndex = 10;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 13);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Open with:";
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(75, 41);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(109, 17);
            this.rbOther.TabIndex = 16;
            this.rbOther.Text = "Other Application:";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbAssoc
            // 
            this.rbAssoc.AutoSize = true;
            this.rbAssoc.Checked = true;
            this.rbAssoc.Location = new System.Drawing.Point(75, 18);
            this.rbAssoc.Name = "rbAssoc";
            this.rbAssoc.Size = new System.Drawing.Size(132, 17);
            this.rbAssoc.TabIndex = 15;
            this.rbAssoc.TabStop = true;
            this.rbAssoc.Text = "Associated Application";
            this.rbAssoc.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(12, 114);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 23);
            this.btnHelp.TabIndex = 14;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(313, 62);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(26, 23);
            this.Button3.TabIndex = 13;
            this.Button3.Text = "...";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button2.Location = new System.Drawing.Point(290, 114);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(100, 23);
            this.Button2.TabIndex = 12;
            this.Button2.Text = "Cancel";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(184, 114);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // ViewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 154);
            this.Controls.Add(this.txtApp);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbAssoc);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ViewFile";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoVer Open/View File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtApp;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.RadioButton rbOther;
        internal System.Windows.Forms.RadioButton rbAssoc;
        internal System.Windows.Forms.Button btnHelp;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button btnOK;
    }
}