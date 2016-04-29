namespace AutoVerUICS.Forms
{
    partial class About
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
            this.lnkUpdates = new System.Windows.Forms.LinkLabel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnkDonate = new System.Windows.Forms.LinkLabel();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblWebLink = new System.Windows.Forms.LinkLabel();
            this.lblBy = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.butOK = new System.Windows.Forms.Button();
            this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkUpdates
            // 
            this.lnkUpdates.Location = new System.Drawing.Point(178, 84);
            this.lnkUpdates.Name = "lnkUpdates";
            this.lnkUpdates.Size = new System.Drawing.Size(218, 22);
            this.lnkUpdates.TabIndex = 23;
            this.lnkUpdates.TabStop = true;
            this.lnkUpdates.Text = "Checking for updates...";
            this.lnkUpdates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox1
            // 
            this.PictureBox1.InitialImage = null;
            this.PictureBox1.Location = new System.Drawing.Point(9, 11);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(160, 285);
            this.PictureBox1.TabIndex = 22;
            this.PictureBox1.TabStop = false;
            // 
            // lnkDonate
            // 
            this.lnkDonate.Location = new System.Drawing.Point(178, 146);
            this.lnkDonate.Name = "lnkDonate";
            this.lnkDonate.Size = new System.Drawing.Size(218, 22);
            this.lnkDonate.TabIndex = 21;
            this.lnkDonate.TabStop = true;
            this.lnkDonate.Text = "Donate";
            this.lnkDonate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(178, 132);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(218, 14);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Freeware";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWebLink
            // 
            this.lblWebLink.Location = new System.Drawing.Point(178, 230);
            this.lblWebLink.Name = "lblWebLink";
            this.lblWebLink.Size = new System.Drawing.Size(218, 22);
            this.lblWebLink.TabIndex = 19;
            this.lblWebLink.TabStop = true;
            this.lblWebLink.Text = "www.beanland.net.au/AutoVer";
            this.lblWebLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBy
            // 
            this.lblBy.Location = new System.Drawing.Point(180, 200);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(215, 19);
            this.lblBy.TabIndex = 18;
            this.lblBy.Text = "Written by Hunter Beanland";
            this.lblBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Location = new System.Drawing.Point(180, 186);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(215, 14);
            this.lblCopyright.TabIndex = 17;
            this.lblCopyright.Text = "Copyright 2007";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(180, 66);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(215, 18);
            this.lblVersion.TabIndex = 16;
            this.lblVersion.Text = "ver 1.0.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(180, 36);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(215, 17);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Auto Versioning";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProduct
            // 
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(181, 11);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(212, 25);
            this.lblProduct.TabIndex = 14;
            this.lblProduct.Text = "AutoVer";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butOK
            // 
            this.butOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butOK.Location = new System.Drawing.Point(236, 273);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(100, 23);
            this.butOK.TabIndex = 13;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 306);
            this.Controls.Add(this.lnkUpdates);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.lnkDonate);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblWebLink);
            this.Controls.Add(this.lblBy);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.butOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.LinkLabel lnkUpdates;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.LinkLabel lnkDonate;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.LinkLabel lblWebLink;
        internal System.Windows.Forms.Label lblBy;
        internal System.Windows.Forms.Label lblCopyright;
        internal System.Windows.Forms.Label lblVersion;
        internal System.Windows.Forms.Label lblDescription;
        internal System.Windows.Forms.Label lblProduct;
        internal System.Windows.Forms.Button butOK;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
    }
}