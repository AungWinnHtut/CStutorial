namespace _2022020801PhotoAlbum2
{
    partial class frmPhotoAlbum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhotoAlbum));
            this.picAlbum = new System.Windows.Forms.PictureBox();
            this.btnHidePhoto = new System.Windows.Forms.Button();
            this.btnShowPhoto = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hidePhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangePhoto = new System.Windows.Forms.Button();
            this.btnChangePhoto2 = new System.Windows.Forms.Button();
            this.cboFileName = new System.Windows.Forms.ComboBox();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSayNameHello = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picAlbum
            // 
            this.picAlbum.Image = ((System.Drawing.Image)(resources.GetObject("picAlbum.Image")));
            this.picAlbum.Location = new System.Drawing.Point(12, 70);
            this.picAlbum.Name = "picAlbum";
            this.picAlbum.Size = new System.Drawing.Size(406, 257);
            this.picAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAlbum.TabIndex = 0;
            this.picAlbum.TabStop = false;
            // 
            // btnHidePhoto
            // 
            this.btnHidePhoto.Location = new System.Drawing.Point(438, 263);
            this.btnHidePhoto.Name = "btnHidePhoto";
            this.btnHidePhoto.Size = new System.Drawing.Size(130, 60);
            this.btnHidePhoto.TabIndex = 1;
            this.btnHidePhoto.Text = "Hide Photo";
            this.btnHidePhoto.UseVisualStyleBackColor = true;
            this.btnHidePhoto.Click += new System.EventHandler(this.btnHidePhoto_Click);
            // 
            // btnShowPhoto
            // 
            this.btnShowPhoto.Location = new System.Drawing.Point(574, 263);
            this.btnShowPhoto.Name = "btnShowPhoto";
            this.btnShowPhoto.Size = new System.Drawing.Size(130, 60);
            this.btnShowPhoto.TabIndex = 2;
            this.btnShowPhoto.Text = "Show Photo";
            this.btnShowPhoto.UseVisualStyleBackColor = true;
            this.btnShowPhoto.Click += new System.EventHandler(this.btnShowPhoto_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hidePhotoToolStripMenuItem,
            this.showPhotoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // hidePhotoToolStripMenuItem
            // 
            this.hidePhotoToolStripMenuItem.Name = "hidePhotoToolStripMenuItem";
            this.hidePhotoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.hidePhotoToolStripMenuItem.Text = "Hide Photo";
            this.hidePhotoToolStripMenuItem.Click += new System.EventHandler(this.hidePhotoToolStripMenuItem_Click);
            // 
            // showPhotoToolStripMenuItem
            // 
            this.showPhotoToolStripMenuItem.Name = "showPhotoToolStripMenuItem";
            this.showPhotoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.showPhotoToolStripMenuItem.Text = "Show Photo";
            this.showPhotoToolStripMenuItem.Click += new System.EventHandler(this.showPhotoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnChangePhoto
            // 
            this.btnChangePhoto.Location = new System.Drawing.Point(438, 197);
            this.btnChangePhoto.Name = "btnChangePhoto";
            this.btnChangePhoto.Size = new System.Drawing.Size(130, 60);
            this.btnChangePhoto.TabIndex = 4;
            this.btnChangePhoto.Text = "Change Photo";
            this.btnChangePhoto.UseVisualStyleBackColor = true;
            this.btnChangePhoto.Click += new System.EventHandler(this.btnChangePhoto_Click);
            // 
            // btnChangePhoto2
            // 
            this.btnChangePhoto2.Location = new System.Drawing.Point(574, 197);
            this.btnChangePhoto2.Name = "btnChangePhoto2";
            this.btnChangePhoto2.Size = new System.Drawing.Size(130, 60);
            this.btnChangePhoto2.TabIndex = 5;
            this.btnChangePhoto2.Text = "Change Photo 2";
            this.btnChangePhoto2.UseVisualStyleBackColor = true;
            this.btnChangePhoto2.Click += new System.EventHandler(this.btnChangePhoto2_Click);
            // 
            // cboFileName
            // 
            this.cboFileName.FormattingEnabled = true;
            this.cboFileName.Items.AddRange(new object[] {
            "D:\\\\microbit.png",
            "D:\\\\kid.jpg"});
            this.cboFileName.Location = new System.Drawing.Point(438, 97);
            this.cboFileName.Name = "cboFileName";
            this.cboFileName.Size = new System.Drawing.Size(257, 28);
            this.cboFileName.TabIndex = 6;
            this.cboFileName.Text = "D:\\\\microbit.png";
            this.cboFileName.SelectedIndexChanged += new System.EventHandler(this.cboFileName_SelectedIndexChanged);
            // 
            // btnSayHello
            // 
            this.btnSayHello.Location = new System.Drawing.Point(438, 131);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(130, 60);
            this.btnSayHello.TabIndex = 7;
            this.btnSayHello.Text = "Say Hello";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 375);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(285, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Today";
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(534, 348);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(154, 26);
            this.txtUname.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Username";
            // 
            // btnSayNameHello
            // 
            this.btnSayNameHello.Location = new System.Drawing.Point(450, 395);
            this.btnSayNameHello.Name = "btnSayNameHello";
            this.btnSayNameHello.Size = new System.Drawing.Size(244, 39);
            this.btnSayNameHello.TabIndex = 12;
            this.btnSayNameHello.Text = "Greeting";
            this.btnSayNameHello.UseVisualStyleBackColor = true;
            this.btnSayNameHello.Click += new System.EventHandler(this.btnSayNameHello_Click);
            // 
            // frmPhotoAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 458);
            this.Controls.Add(this.btnSayNameHello);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.cboFileName);
            this.Controls.Add(this.btnChangePhoto2);
            this.Controls.Add(this.btnChangePhoto);
            this.Controls.Add(this.btnShowPhoto);
            this.Controls.Add(this.btnHidePhoto);
            this.Controls.Add(this.picAlbum);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPhotoAlbum";
            this.Text = "Photo Album 2022";
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAlbum;
        private System.Windows.Forms.Button btnHidePhoto;
        private System.Windows.Forms.Button btnShowPhoto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hidePhotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPhotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnChangePhoto;
        private System.Windows.Forms.Button btnChangePhoto2;
        private System.Windows.Forms.ComboBox cboFileName;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSayNameHello;
    }
}

