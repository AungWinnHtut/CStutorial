namespace HelloWorld
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.picMyPhoto = new System.Windows.Forms.PictureBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMyPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalculate.Location = new System.Drawing.Point(376, 25);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(203, 76);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(162, 25);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(177, 26);
            this.txtRadius.TabIndex = 1;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(161, 66);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(178, 26);
            this.txtArea.TabIndex = 2;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRadius.Location = new System.Drawing.Point(48, 29);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(59, 20);
            this.lblRadius.TabIndex = 3;
            this.lblRadius.Text = "Radius";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(48, 69);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(43, 20);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Area";
            // 
            // picMyPhoto
            // 
            this.picMyPhoto.Image = ((System.Drawing.Image)(resources.GetObject("picMyPhoto.Image")));
            this.picMyPhoto.Location = new System.Drawing.Point(35, 124);
            this.picMyPhoto.Name = "picMyPhoto";
            this.picMyPhoto.Size = new System.Drawing.Size(543, 236);
            this.picMyPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMyPhoto.TabIndex = 5;
            this.picMyPhoto.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(596, 124);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(122, 54);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(596, 194);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(121, 54);
            this.btnHide.TabIndex = 7;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // frmHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 387);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.picMyPhoto);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.btnCalculate);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmHello";
            this.Text = "Hello World";
            ((System.ComponentModel.ISupportInitialize)(this.picMyPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.PictureBox picMyPhoto;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;
    }
}

