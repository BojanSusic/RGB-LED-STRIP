namespace WindowsFormsApp2
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.lblAbout = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.llMail = new System.Windows.Forms.LinkLabel();
            this.lblGit = new System.Windows.Forms.Label();
            this.pbGitHub = new System.Windows.Forms.PictureBox();
            this.lblNotif = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHub)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.Lime;
            this.lblAbout.Location = new System.Drawing.Point(149, 61);
            this.lblAbout.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(65, 20);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = "ABOUT";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Lime;
            this.btnClose.Location = new System.Drawing.Point(150, 481);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.Lime;
            this.lblText.Location = new System.Drawing.Point(23, 126);
            this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(319, 119);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "This program was made by Bojan Susic,\r\nstudent of Electrotechnical University in\r" +
    "\nEast Sarajevo (Bosnia and Herzegovina)\r\n\r\nThis is version 1_0 finished at 06/02" +
    "/2020\r\n\r\nmy email:";
            // 
            // llMail
            // 
            this.llMail.AutoSize = true;
            this.llMail.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llMail.LinkColor = System.Drawing.Color.SkyBlue;
            this.llMail.Location = new System.Drawing.Point(112, 228);
            this.llMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llMail.Name = "llMail";
            this.llMail.Size = new System.Drawing.Size(164, 17);
            this.llMail.TabIndex = 3;
            this.llMail.TabStop = true;
            this.llMail.Text = "bojansusic8@gmail.com";
            this.llMail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llMail_LinkClicked);
            // 
            // lblGit
            // 
            this.lblGit.AutoSize = true;
            this.lblGit.ForeColor = System.Drawing.Color.Lime;
            this.lblGit.Location = new System.Drawing.Point(41, 308);
            this.lblGit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGit.Name = "lblGit";
            this.lblGit.Size = new System.Drawing.Size(278, 21);
            this.lblGit.TabIndex = 4;
            this.lblGit.Text = "You can find this project here:";
            // 
            // pbGitHub
            // 
            this.pbGitHub.Image = ((System.Drawing.Image)(resources.GetObject("pbGitHub.Image")));
            this.pbGitHub.Location = new System.Drawing.Point(45, 332);
            this.pbGitHub.Name = "pbGitHub";
            this.pbGitHub.Size = new System.Drawing.Size(274, 100);
            this.pbGitHub.TabIndex = 5;
            this.pbGitHub.TabStop = false;
            this.pbGitHub.Click += new System.EventHandler(this.pbGitHub_Click);
            // 
            // lblNotif
            // 
            this.lblNotif.AutoSize = true;
            this.lblNotif.Font = new System.Drawing.Font("MV Boli", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotif.ForeColor = System.Drawing.Color.Lime;
            this.lblNotif.Location = new System.Drawing.Point(126, 245);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(125, 16);
            this.lblNotif.TabIndex = 6;
            this.lblNotif.Text = "copied to clipboard";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(375, 558);
            this.Controls.Add(this.lblNotif);
            this.Controls.Add(this.pbGitHub);
            this.Controls.Add(this.lblGit);
            this.Controls.Add(this.llMail);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAbout);
            this.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Info";
            this.Text = "Info";
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.LinkLabel llMail;
        private System.Windows.Forms.Label lblGit;
        private System.Windows.Forms.PictureBox pbGitHub;
        private System.Windows.Forms.Label lblNotif;
    }
}