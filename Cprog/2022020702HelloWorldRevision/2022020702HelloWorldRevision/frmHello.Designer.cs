namespace _2022020702HelloWorldRevision
{
    partial class frmHello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHello));
            this.picAlbum = new System.Windows.Forms.PictureBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnShowPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // picAlbum
            // 
            this.picAlbum.Image = ((System.Drawing.Image)(resources.GetObject("picAlbum.Image")));
            this.picAlbum.Location = new System.Drawing.Point(12, 33);
            this.picAlbum.Name = "picAlbum";
            this.picAlbum.Size = new System.Drawing.Size(340, 208);
            this.picAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAlbum.TabIndex = 0;
            this.picAlbum.TabStop = false;
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(374, 33);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(177, 65);
            this.btnHide.TabIndex = 1;
            this.btnHide.Text = "Hide Photo";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnShowPhoto
            // 
            this.btnShowPhoto.Location = new System.Drawing.Point(375, 104);
            this.btnShowPhoto.Name = "btnShowPhoto";
            this.btnShowPhoto.Size = new System.Drawing.Size(176, 137);
            this.btnShowPhoto.TabIndex = 2;
            this.btnShowPhoto.Text = "Show Photo";
            this.btnShowPhoto.UseVisualStyleBackColor = true;
            this.btnShowPhoto.Click += new System.EventHandler(this.btnShowPhoto_Click);
            // 
            // frmHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 267);
            this.Controls.Add(this.btnShowPhoto);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.picAlbum);
            this.Name = "frmHello";
            this.Text = "Hello World";
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAlbum;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShowPhoto;
    }
}

