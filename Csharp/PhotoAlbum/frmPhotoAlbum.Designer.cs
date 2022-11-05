namespace PhotoAlbum
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
            this.btnExit = new System.Windows.Forms.Button();
            this.picOne = new System.Windows.Forms.PictureBox();
            this.picTwo = new System.Windows.Forms.PictureBox();
            this.btnHideOne = new System.Windows.Forms.Button();
            this.btnHideTwo = new System.Windows.Forms.Button();
            this.btnShowTwo = new System.Windows.Forms.Button();
            this.btnShowOne = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(614, 31);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 47);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picOne
            // 
            this.picOne.Image = ((System.Drawing.Image)(resources.GetObject("picOne.Image")));
            this.picOne.Location = new System.Drawing.Point(12, 22);
            this.picOne.Name = "picOne";
            this.picOne.Size = new System.Drawing.Size(281, 172);
            this.picOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOne.TabIndex = 1;
            this.picOne.TabStop = false;
            // 
            // picTwo
            // 
            this.picTwo.Image = ((System.Drawing.Image)(resources.GetObject("picTwo.Image")));
            this.picTwo.Location = new System.Drawing.Point(323, 25);
            this.picTwo.Name = "picTwo";
            this.picTwo.Size = new System.Drawing.Size(281, 172);
            this.picTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTwo.TabIndex = 2;
            this.picTwo.TabStop = false;
            // 
            // btnHideOne
            // 
            this.btnHideOne.Location = new System.Drawing.Point(12, 215);
            this.btnHideOne.Name = "btnHideOne";
            this.btnHideOne.Size = new System.Drawing.Size(280, 44);
            this.btnHideOne.TabIndex = 3;
            this.btnHideOne.Text = "Hide";
            this.btnHideOne.UseVisualStyleBackColor = true;
            this.btnHideOne.Click += new System.EventHandler(this.btnHideOne_Click);
            // 
            // btnHideTwo
            // 
            this.btnHideTwo.Location = new System.Drawing.Point(326, 214);
            this.btnHideTwo.Name = "btnHideTwo";
            this.btnHideTwo.Size = new System.Drawing.Size(280, 44);
            this.btnHideTwo.TabIndex = 4;
            this.btnHideTwo.Text = "Hide";
            this.btnHideTwo.UseVisualStyleBackColor = true;
            this.btnHideTwo.Click += new System.EventHandler(this.btnHideTwo_Click);
            // 
            // btnShowTwo
            // 
            this.btnShowTwo.Location = new System.Drawing.Point(327, 278);
            this.btnShowTwo.Name = "btnShowTwo";
            this.btnShowTwo.Size = new System.Drawing.Size(280, 44);
            this.btnShowTwo.TabIndex = 6;
            this.btnShowTwo.Text = "Show";
            this.btnShowTwo.UseVisualStyleBackColor = true;
            this.btnShowTwo.Click += new System.EventHandler(this.btnShowTwo_Click);
            // 
            // btnShowOne
            // 
            this.btnShowOne.Location = new System.Drawing.Point(13, 279);
            this.btnShowOne.Name = "btnShowOne";
            this.btnShowOne.Size = new System.Drawing.Size(280, 44);
            this.btnShowOne.TabIndex = 5;
            this.btnShowOne.Text = "Show";
            this.btnShowOne.UseVisualStyleBackColor = true;
            this.btnShowOne.Click += new System.EventHandler(this.btnShowOne_Click);
            // 
            // frmPhotoAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowTwo);
            this.Controls.Add(this.btnShowOne);
            this.Controls.Add(this.btnHideTwo);
            this.Controls.Add(this.btnHideOne);
            this.Controls.Add(this.picTwo);
            this.Controls.Add(this.picOne);
            this.Controls.Add(this.btnExit);
            this.Name = "frmPhotoAlbum";
            this.Text = "Photo Album";
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picOne;
        private System.Windows.Forms.PictureBox picTwo;
        private System.Windows.Forms.Button btnHideOne;
        private System.Windows.Forms.Button btnHideTwo;
        private System.Windows.Forms.Button btnShowTwo;
        private System.Windows.Forms.Button btnShowOne;
    }
}

