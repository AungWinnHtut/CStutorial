namespace _2022021402_Fortune_Teller
{
    partial class frmFortuneTeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFortuneTeller));
            this.picOne = new System.Windows.Forms.PictureBox();
            this.picTwo = new System.Windows.Forms.PictureBox();
            this.picThree = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThree)).BeginInit();
            this.SuspendLayout();
            // 
            // picOne
            // 
            this.picOne.Image = ((System.Drawing.Image)(resources.GetObject("picOne.Image")));
            this.picOne.Location = new System.Drawing.Point(26, 22);
            this.picOne.Name = "picOne";
            this.picOne.Size = new System.Drawing.Size(232, 332);
            this.picOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOne.TabIndex = 0;
            this.picOne.TabStop = false;
            this.picOne.Click += new System.EventHandler(this.picOne_Click);
            // 
            // picTwo
            // 
            this.picTwo.Location = new System.Drawing.Point(297, 21);
            this.picTwo.Name = "picTwo";
            this.picTwo.Size = new System.Drawing.Size(232, 332);
            this.picTwo.TabIndex = 1;
            this.picTwo.TabStop = false;
            this.picTwo.Click += new System.EventHandler(this.picTwo_Click);
            // 
            // picThree
            // 
            this.picThree.Location = new System.Drawing.Point(568, 22);
            this.picThree.Name = "picThree";
            this.picThree.Size = new System.Drawing.Size(232, 332);
            this.picThree.TabIndex = 2;
            this.picThree.TabStop = false;
            this.picThree.Click += new System.EventHandler(this.picThree_Click);
            // 
            // frmFortuneTeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 491);
            this.Controls.Add(this.picThree);
            this.Controls.Add(this.picTwo);
            this.Controls.Add(this.picOne);
            this.Name = "frmFortuneTeller";
            this.Load += new System.EventHandler(this.frmFortuneTeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picOne;
        private System.Windows.Forms.PictureBox picTwo;
        private System.Windows.Forms.PictureBox picThree;
    }
}

