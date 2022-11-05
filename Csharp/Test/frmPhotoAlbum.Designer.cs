namespace Test
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
            this.picMyPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMyPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picMyPhoto
            // 
            this.picMyPhoto.Image = ((System.Drawing.Image)(resources.GetObject("picMyPhoto.Image")));
            this.picMyPhoto.Location = new System.Drawing.Point(22, 24);
            this.picMyPhoto.Name = "picMyPhoto";
            this.picMyPhoto.Size = new System.Drawing.Size(743, 397);
            this.picMyPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMyPhoto.TabIndex = 0;
            this.picMyPhoto.TabStop = false;
            // 
            // frmPhotoAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picMyPhoto);
            this.Name = "frmPhotoAlbum";
            this.Text = "frmPhotoAlbum";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhotoAlbum_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picMyPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMyPhoto;
    }
}