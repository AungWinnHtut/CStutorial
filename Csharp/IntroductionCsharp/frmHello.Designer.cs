namespace IntroductionCsharp
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
            this.picNature = new System.Windows.Forms.PictureBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picNature)).BeginInit();
            this.SuspendLayout();
            // 
            // picNature
            // 
            this.picNature.Image = ((System.Drawing.Image)(resources.GetObject("picNature.Image")));
            this.picNature.Location = new System.Drawing.Point(25, 12);
            this.picNature.Name = "picNature";
            this.picNature.Size = new System.Drawing.Size(684, 380);
            this.picNature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNature.TabIndex = 0;
            this.picNature.TabStop = false;
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(25, 436);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(215, 61);
            this.btnHide.TabIndex = 1;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(494, 436);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(215, 61);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 525);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.picNature);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHello";
            this.Text = "Hello";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHello_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picNature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picNature;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShow;
    }
}

