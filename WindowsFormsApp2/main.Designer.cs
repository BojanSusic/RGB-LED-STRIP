namespace WindowsFormsApp2
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profiles = new System.Windows.Forms.TabPage();
            this.pnlProfiles = new System.Windows.Forms.Panel();
            this.btnProf20 = new System.Windows.Forms.Button();
            this.btnProf10 = new System.Windows.Forms.Button();
            this.btnProf19 = new System.Windows.Forms.Button();
            this.btnProf9 = new System.Windows.Forms.Button();
            this.btnProf18 = new System.Windows.Forms.Button();
            this.btnProf8 = new System.Windows.Forms.Button();
            this.btnProf17 = new System.Windows.Forms.Button();
            this.btnProf7 = new System.Windows.Forms.Button();
            this.btnProf16 = new System.Windows.Forms.Button();
            this.btnProf6 = new System.Windows.Forms.Button();
            this.btnProf15 = new System.Windows.Forms.Button();
            this.btnProf14 = new System.Windows.Forms.Button();
            this.btnProf5 = new System.Windows.Forms.Button();
            this.btnProf13 = new System.Windows.Forms.Button();
            this.btnProf4 = new System.Windows.Forms.Button();
            this.btnProf12 = new System.Windows.Forms.Button();
            this.btnProf3 = new System.Windows.Forms.Button();
            this.btnProf11 = new System.Windows.Forms.Button();
            this.btnProf2 = new System.Windows.Forms.Button();
            this.btnProf1 = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.TabPage();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.tbBlue = new WindowsFormsApp2.CTrackBar();
            this.tbGreen = new WindowsFormsApp2.CTrackBar();
            this.tbRed = new WindowsFormsApp2.CTrackBar();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblFX = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.cbEffects = new System.Windows.Forms.ComboBox();
            this.tbColorCode = new System.Windows.Forms.TextBox();
            this.btnSaveProf = new System.Windows.Forms.Button();
            this.background = new System.Windows.Forms.PictureBox();
            this.cTab1 = new WindowsFormsApp2.CTab();
            this.btnClose = new WindowsFormsApp2.CButton();
            this.btnMinimize = new WindowsFormsApp2.CButton();
            this.contextMenuStrip1.SuspendLayout();
            this.profiles.SuspendLayout();
            this.pnlProfiles.SuspendLayout();
            this.home.SuspendLayout();
            this.pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.cTab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Your app is here!";
            this.notifyIcon1.BalloonTipTitle = "RGB LED STRIP";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "RGB LED STRIP";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(79, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // profiles
            // 
            this.profiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.profiles.Controls.Add(this.pnlProfiles);
            this.profiles.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profiles.ForeColor = System.Drawing.Color.Lime;
            this.profiles.Location = new System.Drawing.Point(4, 39);
            this.profiles.Name = "profiles";
            this.profiles.Padding = new System.Windows.Forms.Padding(3);
            this.profiles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.profiles.Size = new System.Drawing.Size(643, 472);
            this.profiles.TabIndex = 1;
            this.profiles.Text = "PROFILES";
            // 
            // pnlProfiles
            // 
            this.pnlProfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlProfiles.Controls.Add(this.btnProf20);
            this.pnlProfiles.Controls.Add(this.btnProf10);
            this.pnlProfiles.Controls.Add(this.btnProf19);
            this.pnlProfiles.Controls.Add(this.btnProf9);
            this.pnlProfiles.Controls.Add(this.btnProf18);
            this.pnlProfiles.Controls.Add(this.btnProf8);
            this.pnlProfiles.Controls.Add(this.btnProf17);
            this.pnlProfiles.Controls.Add(this.btnProf7);
            this.pnlProfiles.Controls.Add(this.btnProf16);
            this.pnlProfiles.Controls.Add(this.btnProf6);
            this.pnlProfiles.Controls.Add(this.btnProf15);
            this.pnlProfiles.Controls.Add(this.btnProf14);
            this.pnlProfiles.Controls.Add(this.btnProf5);
            this.pnlProfiles.Controls.Add(this.btnProf13);
            this.pnlProfiles.Controls.Add(this.btnProf4);
            this.pnlProfiles.Controls.Add(this.btnProf12);
            this.pnlProfiles.Controls.Add(this.btnProf3);
            this.pnlProfiles.Controls.Add(this.btnProf11);
            this.pnlProfiles.Controls.Add(this.btnProf2);
            this.pnlProfiles.Controls.Add(this.btnProf1);
            this.pnlProfiles.Location = new System.Drawing.Point(6, 40);
            this.pnlProfiles.Name = "pnlProfiles";
            this.pnlProfiles.Size = new System.Drawing.Size(596, 428);
            this.pnlProfiles.TabIndex = 14;
            // 
            // btnProf20
            // 
            this.btnProf20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProf20.BackgroundImage")));
            this.btnProf20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf20.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf20.ForeColor = System.Drawing.Color.Lime;
            this.btnProf20.Location = new System.Drawing.Point(334, 379);
            this.btnProf20.Name = "btnProf20";
            this.btnProf20.Size = new System.Drawing.Size(254, 35);
            this.btnProf20.TabIndex = 0;
            this.btnProf20.Text = "button20";
            this.btnProf20.UseVisualStyleBackColor = true;
            this.btnProf20.Click += new System.EventHandler(this.button00_Click);
            // 
            // btnProf10
            // 
            this.btnProf10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProf10.BackgroundImage")));
            this.btnProf10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf10.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf10.ForeColor = System.Drawing.Color.Lime;
            this.btnProf10.Location = new System.Drawing.Point(25, 379);
            this.btnProf10.Name = "btnProf10";
            this.btnProf10.Size = new System.Drawing.Size(254, 35);
            this.btnProf10.TabIndex = 0;
            this.btnProf10.Text = "button10";
            this.btnProf10.UseVisualStyleBackColor = true;
            this.btnProf10.Click += new System.EventHandler(this.button00_Click);
            // 
            // btnProf19
            // 
            this.btnProf19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProf19.BackgroundImage")));
            this.btnProf19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf19.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf19.ForeColor = System.Drawing.Color.Lime;
            this.btnProf19.Location = new System.Drawing.Point(334, 338);
            this.btnProf19.Name = "btnProf19";
            this.btnProf19.Size = new System.Drawing.Size(254, 35);
            this.btnProf19.TabIndex = 0;
            this.btnProf19.Text = "button19";
            this.btnProf19.UseVisualStyleBackColor = true;
            this.btnProf19.Click += new System.EventHandler(this.button00_Click);
            // 
            // btnProf9
            // 
            this.btnProf9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProf9.BackgroundImage")));
            this.btnProf9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf9.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf9.ForeColor = System.Drawing.Color.Lime;
            this.btnProf9.Location = new System.Drawing.Point(25, 338);
            this.btnProf9.Name = "btnProf9";
            this.btnProf9.Size = new System.Drawing.Size(254, 35);
            this.btnProf9.TabIndex = 0;
            this.btnProf9.Text = "button9";
            this.btnProf9.UseVisualStyleBackColor = true;
            this.btnProf9.Click += new System.EventHandler(this.button00_Click);
            // 
            // btnProf18
            // 
            this.btnProf18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProf18.BackgroundImage")));
            this.btnProf18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf18.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf18.ForeColor = System.Drawing.Color.Lime;
            this.btnProf18.Location = new System.Drawing.Point(334, 297);
            this.btnProf18.Name = "btnProf18";
            this.btnProf18.Size = new System.Drawing.Size(254, 35);
            this.btnProf18.TabIndex = 0;
            this.btnProf18.Text = "button18";
            this.btnProf18.UseVisualStyleBackColor = true;
            this.btnProf18.Click += new System.EventHandler(this.button00_Click);
            // 
            // btnProf8
            // 
            this.btnProf8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProf8.BackgroundImage")));
            this.btnProf8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf8.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf8.ForeColor = System.Drawing.Color.Lime;
            this.btnProf8.Location = new System.Drawing.Point(25, 297);
            this.btnProf8.Name = "btnProf8";
            this.btnProf8.Size = new System.Drawing.Size(254, 35);
            this.btnProf8.TabIndex = 0;
            this.btnProf8.Text = "button8";
            this.btnProf8.UseVisualStyleBackColor = true;
            this.btnProf8.Click += new System.EventHandler(this.button00_Click);
            // 
            // btnProf17
            // 
            this.btnProf17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProf17.BackgroundImage")));
            this.btnProf17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf17.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf17.ForeColor = System.Drawing.Color.Lime;
            this.btnProf17.Location = new System.Drawing.Point(334, 256);
            this.btnProf17.Name = "btnProf17";
            this.btnProf17.Size = new System.Drawing.Size(254, 35);
            this.btnProf17.TabIndex = 0;
            this.btnProf17.Text = "button17";
            this.btnProf17.UseVisualStyleBackColor = true;
            this.btnProf17.Click += new System.EventHandler(this.button00_Click);
            // 
            // btnProf7
            // 
            this.btnProf7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProf7.BackgroundImage")));
            this.btnProf7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf7.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf7.ForeColor = System.Drawing.Color.Lime;
            this.btnProf7.Location = new System.Drawing.Point(25, 256);
            this.btnProf7.Name = "btnProf7";
            this.btnProf7.Size = new System.Drawing.Size(254, 35);
            this.btnProf7.TabIndex = 0;
            this.btnProf7.Text = "button7";
            this.btnProf7.UseVisualStyleBackColor = true;
            this.btnProf7.Click += new System.EventHandler(this.button00_Click);
            // 
            // btnProf16
            // 
            this.btnProf16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProf16.BackgroundImage")));
            this.btnProf16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf16.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf16.ForeColor = System.Drawing.Color.Lime;
            this.btnProf16.Location = new System.Drawing.Point(334, 215);
            this.btnProf16.Name = "btnProf16";
            this.btnProf16.Size = new System.Drawing.Size(254, 35);
            this.btnProf16.TabIndex = 0;
            this.btnProf16.Text = "button16";
            this.btnProf16.UseVisualStyleBackColor = true;
            this.btnProf16.Click += new System.EventHandler(this.button00_Click);
            // 
            // btnProf6
            // 
            this.btnProf6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProf6.BackgroundImage")));
            this.btnProf6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf6.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf6.ForeColor = System.Drawing.Color.Lime;
            this.btnProf6.Location = new System.Drawing.Point(25, 215);
            this.btnProf6.Name = "btnProf6";
            this.btnProf6.Size = new System.Drawing.Size(254, 35);
            this.btnProf6.TabIndex = 0;
            this.btnProf6.Text = "button6";
            this.btnProf6.UseVisualStyleBackColor = true;
            this.btnProf6.Click += new System.EventHandler(this.button00_Click);
            // 
            // btnProf15
            // 
            this.btnProf15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProf15.BackgroundImage")));
            this.btnProf15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf15.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf15.ForeColor = System.Drawing.Color.Lime;
            this.btnProf15.Location = new System.Drawing.Point(334, 174);
            this.btnProf15.Name = "btnProf15";
            this.btnProf15.Size = new System.Drawing.Size(254, 35);
            this.btnProf15.TabIndex = 0;
            this.btnProf15.Text = "button15";
            this.btnProf15.UseVisualStyleBackColor = true;
            this.btnProf15.Click += new System.EventHandler(this.button00_Click);
            // 
            // btnProf14
            // 
            this.btnProf14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProf14.BackgroundImage")));
            this.btnProf14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf14.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf14.ForeColor = System.Drawing.Color.Lime;
            this.btnProf14.Location = new System.Drawing.Point(334, 133);
            this.btnProf14.Name = "btnProf14";
            this.btnProf14.Size = new System.Drawing.Size(254, 35);
            this.btnProf14.TabIndex = 0;
            this.btnProf14.Text = "button14";
            this.btnProf14.UseVisualStyleBackColor = true;
            this.btnProf14.Click += new System.EventHandler(this.button00_Click);
            // 
            // btnProf5
            // 
            this.btnProf5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProf5.BackgroundImage")));
            this.btnProf5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf5.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf5.ForeColor = System.Drawing.Color.Lime;
            this.btnProf5.Location = new System.Drawing.Point(25, 174);
            this.btnProf5.Name = "btnProf5";
            this.btnProf5.Size = new System.Drawing.Size(254, 35);
            this.btnProf5.TabIndex = 0;
            this.btnProf5.Text = "button5";
            this.btnProf5.UseVisualStyleBackColor = true;
            this.btnProf5.Click += new System.EventHandler(this.button00_Click);
            // 
            // btnProf13
            // 
            this.btnProf13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProf13.BackgroundImage")));
            this.btnProf13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf13.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf13.ForeColor = System.Drawing.Color.Lime;
            this.btnProf13.Location = new System.Drawing.Point(334, 92);
            this.btnProf13.Name = "btnProf13";
            this.btnProf13.Size = new System.Drawing.Size(254, 35);
            this.btnProf13.TabIndex = 0;
            this.btnProf13.Text = "button13";
            this.btnProf13.UseVisualStyleBackColor = true;
            this.btnProf13.Click += new System.EventHandler(this.button00_Click);
            // 
            // btnProf4
            // 
            this.btnProf4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProf4.BackgroundImage")));
            this.btnProf4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf4.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf4.ForeColor = System.Drawing.Color.Lime;
            this.btnProf4.Location = new System.Drawing.Point(25, 133);
            this.btnProf4.Name = "btnProf4";
            this.btnProf4.Size = new System.Drawing.Size(254, 35);
            this.btnProf4.TabIndex = 0;
            this.btnProf4.Text = "button4";
            this.btnProf4.UseVisualStyleBackColor = true;
            this.btnProf4.Click += new System.EventHandler(this.button00_Click);
            // 
            // btnProf12
            // 
            this.btnProf12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProf12.BackgroundImage")));
            this.btnProf12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf12.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf12.ForeColor = System.Drawing.Color.Lime;
            this.btnProf12.Location = new System.Drawing.Point(334, 51);
            this.btnProf12.Name = "btnProf12";
            this.btnProf12.Size = new System.Drawing.Size(254, 35);
            this.btnProf12.TabIndex = 0;
            this.btnProf12.Text = "button12";
            this.btnProf12.UseVisualStyleBackColor = true;
            this.btnProf12.Click += new System.EventHandler(this.button00_Click);
            // 
            // btnProf3
            // 
            this.btnProf3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProf3.BackgroundImage")));
            this.btnProf3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf3.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf3.ForeColor = System.Drawing.Color.Lime;
            this.btnProf3.Location = new System.Drawing.Point(25, 92);
            this.btnProf3.Name = "btnProf3";
            this.btnProf3.Size = new System.Drawing.Size(254, 35);
            this.btnProf3.TabIndex = 0;
            this.btnProf3.Text = "button3";
            this.btnProf3.UseVisualStyleBackColor = true;
            this.btnProf3.Click += new System.EventHandler(this.button00_Click);
            // 
            // btnProf11
            // 
            this.btnProf11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProf11.BackgroundImage")));
            this.btnProf11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf11.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf11.ForeColor = System.Drawing.Color.Lime;
            this.btnProf11.Location = new System.Drawing.Point(334, 10);
            this.btnProf11.Name = "btnProf11";
            this.btnProf11.Size = new System.Drawing.Size(254, 35);
            this.btnProf11.TabIndex = 0;
            this.btnProf11.Text = "button11";
            this.btnProf11.UseVisualStyleBackColor = true;
            this.btnProf11.Click += new System.EventHandler(this.button00_Click);
            // 
            // btnProf2
            // 
            this.btnProf2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProf2.BackgroundImage")));
            this.btnProf2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf2.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf2.ForeColor = System.Drawing.Color.Lime;
            this.btnProf2.Location = new System.Drawing.Point(25, 51);
            this.btnProf2.Name = "btnProf2";
            this.btnProf2.Size = new System.Drawing.Size(254, 35);
            this.btnProf2.TabIndex = 0;
            this.btnProf2.Text = "button2";
            this.btnProf2.UseVisualStyleBackColor = true;
            this.btnProf2.Click += new System.EventHandler(this.button00_Click);
            // 
            // btnProf1
            // 
            this.btnProf1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProf1.BackgroundImage")));
            this.btnProf1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf1.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf1.ForeColor = System.Drawing.Color.Lime;
            this.btnProf1.Location = new System.Drawing.Point(25, 10);
            this.btnProf1.Name = "btnProf1";
            this.btnProf1.Size = new System.Drawing.Size(254, 35);
            this.btnProf1.TabIndex = 0;
            this.btnProf1.Tag = "";
            this.btnProf1.Text = "button1";
            this.btnProf1.UseVisualStyleBackColor = true;
            this.btnProf1.Click += new System.EventHandler(this.button00_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.home.Controls.Add(this.pnlHome);
            this.home.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.Lime;
            this.home.Location = new System.Drawing.Point(4, 39);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(3);
            this.home.Size = new System.Drawing.Size(643, 472);
            this.home.TabIndex = 0;
            this.home.Text = "HOME";
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlHome.Controls.Add(this.tbBlue);
            this.pnlHome.Controls.Add(this.tbGreen);
            this.pnlHome.Controls.Add(this.tbRed);
            this.pnlHome.Controls.Add(this.pictureBox8);
            this.pnlHome.Controls.Add(this.lblFX);
            this.pnlHome.Controls.Add(this.lblB);
            this.pnlHome.Controls.Add(this.lblG);
            this.pnlHome.Controls.Add(this.lblR);
            this.pnlHome.Controls.Add(this.cbEffects);
            this.pnlHome.Controls.Add(this.tbColorCode);
            this.pnlHome.Controls.Add(this.btnSaveProf);
            this.pnlHome.Location = new System.Drawing.Point(0, 33);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(646, 432);
            this.pnlHome.TabIndex = 10;
            // 
            // tbBlue
            // 
            this.tbBlue.Boja = System.Drawing.Color.Blue;
            this.tbBlue.ForeColor = System.Drawing.Color.Blue;
            this.tbBlue.Location = new System.Drawing.Point(69, 190);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(261, 28);
            this.tbBlue.TabIndex = 10;
            this.tbBlue.Text = "cTrackBar1";
            this.tbBlue.Value = 100;
            this.tbBlue.ValueChanged += new System.EventHandler(this.tbBlue_ValueChanged);
            // 
            // tbGreen
            // 
            this.tbGreen.Boja = System.Drawing.Color.Lime;
            this.tbGreen.ForeColor = System.Drawing.Color.LightGreen;
            this.tbGreen.Location = new System.Drawing.Point(69, 98);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(261, 28);
            this.tbGreen.TabIndex = 10;
            this.tbGreen.Text = "cTrackBar1";
            this.tbGreen.Value = 100;
            this.tbGreen.ValueChanged += new System.EventHandler(this.tbGreen_ValueChanged);
            // 
            // tbRed
            // 
            this.tbRed.Boja = System.Drawing.Color.Red;
            this.tbRed.ForeColor = System.Drawing.Color.LightGreen;
            this.tbRed.Location = new System.Drawing.Point(69, 13);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(261, 28);
            this.tbRed.TabIndex = 10;
            this.tbRed.Text = "cTrackBar1";
            this.tbRed.Value = 100;
            this.tbRed.ValueChanged += new System.EventHandler(this.tbRed_ValueChanged);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(412, 17);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(187, 195);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox8_MouseClick);
            this.pictureBox8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox8_MouseMove);
            this.pictureBox8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox8_MouseUp);
            // 
            // lblFX
            // 
            this.lblFX.AutoSize = true;
            this.lblFX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblFX.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFX.Location = new System.Drawing.Point(4, 279);
            this.lblFX.Name = "lblFX";
            this.lblFX.Size = new System.Drawing.Size(56, 39);
            this.lblFX.TabIndex = 8;
            this.lblFX.Text = "FX";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblB.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.ForeColor = System.Drawing.Color.Blue;
            this.lblB.Location = new System.Drawing.Point(13, 184);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(36, 39);
            this.lblB.TabIndex = 8;
            this.lblB.Text = "B";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblG.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG.Location = new System.Drawing.Point(13, 91);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(38, 39);
            this.lblG.TabIndex = 8;
            this.lblG.Text = "G";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblR.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.ForeColor = System.Drawing.Color.Red;
            this.lblR.Location = new System.Drawing.Point(13, 5);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(38, 39);
            this.lblR.TabIndex = 8;
            this.lblR.Text = "R";
            // 
            // cbEffects
            // 
            this.cbEffects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbEffects.Font = new System.Drawing.Font("MV Boli", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEffects.FormattingEnabled = true;
            this.cbEffects.Items.AddRange(new object[] {
            "NONE",
            "FADE",
            "RAINBOW",
            "BLINK"});
            this.cbEffects.Location = new System.Drawing.Point(69, 288);
            this.cbEffects.Name = "cbEffects";
            this.cbEffects.Size = new System.Drawing.Size(262, 25);
            this.cbEffects.TabIndex = 5;
            this.cbEffects.Text = "NONE";
            this.cbEffects.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbColorCode
            // 
            this.tbColorCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.tbColorCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbColorCode.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColorCode.Location = new System.Drawing.Point(437, 287);
            this.tbColorCode.Name = "tbColorCode";
            this.tbColorCode.Size = new System.Drawing.Size(135, 26);
            this.tbColorCode.TabIndex = 4;
            this.tbColorCode.TextChanged += new System.EventHandler(this.tbColorCode_TextChanged);
            this.tbColorCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbColorCode_KeyDown);
            // 
            // btnSaveProf
            // 
            this.btnSaveProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnSaveProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProf.Font = new System.Drawing.Font("MV Boli", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProf.ForeColor = System.Drawing.Color.Lime;
            this.btnSaveProf.Location = new System.Drawing.Point(260, 365);
            this.btnSaveProf.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveProf.Name = "btnSaveProf";
            this.btnSaveProf.Size = new System.Drawing.Size(140, 32);
            this.btnSaveProf.TabIndex = 1;
            this.btnSaveProf.Text = "SAVE PROFILE";
            this.btnSaveProf.UseVisualStyleBackColor = false;
            this.btnSaveProf.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // background
            // 
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(675, 550);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.background.TabIndex = 16;
            this.background.TabStop = false;
            this.background.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // cTab1
            // 
            this.cTab1.Controls.Add(this.home);
            this.cTab1.Controls.Add(this.profiles);
            this.cTab1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.cTab1.Location = new System.Drawing.Point(12, 23);
            this.cTab1.Name = "cTab1";
            this.cTab1.Padding = new System.Drawing.Point(28, 10);
            this.cTab1.PathColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.cTab1.SelectedIndex = 0;
            this.cTab1.Size = new System.Drawing.Size(651, 515);
            this.cTab1.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnClose.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(591, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Side = WindowsFormsApp2.Side.LEFT;
            this.btnClose.Size = new System.Drawing.Size(57, 31);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnMinimize.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnMinimize.Location = new System.Drawing.Point(548, 25);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Side = WindowsFormsApp2.Side.RIGHT;
            this.btnMinimize.Size = new System.Drawing.Size(57, 31);
            this.btnMinimize.TabIndex = 18;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(675, 550);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cTab1);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "LED STRIP CONTROL";
            this.contextMenuStrip1.ResumeLayout(false);
            this.profiles.ResumeLayout(false);
            this.pnlProfiles.ResumeLayout(false);
            this.home.ResumeLayout(false);
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.cTab1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TabPage profiles;
        private System.Windows.Forms.Panel pnlProfiles;
        private System.Windows.Forms.Button btnProf20;
        private System.Windows.Forms.Button btnProf10;
        private System.Windows.Forms.Button btnProf19;
        private System.Windows.Forms.Button btnProf9;
        private System.Windows.Forms.Button btnProf18;
        private System.Windows.Forms.Button btnProf8;
        private System.Windows.Forms.Button btnProf17;
        private System.Windows.Forms.Button btnProf7;
        private System.Windows.Forms.Button btnProf16;
        private System.Windows.Forms.Button btnProf6;
        private System.Windows.Forms.Button btnProf15;
        private System.Windows.Forms.Button btnProf14;
        private System.Windows.Forms.Button btnProf5;
        private System.Windows.Forms.Button btnProf13;
        private System.Windows.Forms.Button btnProf4;
        private System.Windows.Forms.Button btnProf12;
        private System.Windows.Forms.Button btnProf3;
        private System.Windows.Forms.Button btnProf11;
        private System.Windows.Forms.Button btnProf2;
        private System.Windows.Forms.Button btnProf1;
        private System.Windows.Forms.TabPage home;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblFX;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.ComboBox cbEffects;
        private System.Windows.Forms.TextBox tbColorCode;
        private System.Windows.Forms.Button btnSaveProf;
        private CTab cTab1;
        private System.Windows.Forms.PictureBox background;
        private CButton btnClose;
        private CButton btnMinimize;
        private CTrackBar tbRed;
        private CTrackBar tbGreen;
        private CTrackBar tbBlue;
    }
}