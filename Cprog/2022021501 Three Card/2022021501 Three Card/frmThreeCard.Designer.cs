namespace _2022021501_Three_Card
{
    partial class frmThreeCard
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
            this.picOne = new System.Windows.Forms.PictureBox();
            this.picTwo = new System.Windows.Forms.PictureBox();
            this.picThree = new System.Windows.Forms.PictureBox();
            this.txtBaydin = new System.Windows.Forms.RichTextBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThree)).BeginInit();
            this.SuspendLayout();
            // 
            // picOne
            // 
            this.picOne.Location = new System.Drawing.Point(42, 48);
            this.picOne.Name = "picOne";
            this.picOne.Size = new System.Drawing.Size(205, 314);
            this.picOne.TabIndex = 0;
            this.picOne.TabStop = false;
            this.picOne.Click += new System.EventHandler(this.picOne_Click);
            // 
            // picTwo
            // 
            this.picTwo.Location = new System.Drawing.Point(274, 48);
            this.picTwo.Name = "picTwo";
            this.picTwo.Size = new System.Drawing.Size(205, 314);
            this.picTwo.TabIndex = 1;
            this.picTwo.TabStop = false;
            this.picTwo.Click += new System.EventHandler(this.picTwo_Click);
            // 
            // picThree
            // 
            this.picThree.Location = new System.Drawing.Point(506, 48);
            this.picThree.Name = "picThree";
            this.picThree.Size = new System.Drawing.Size(205, 314);
            this.picThree.TabIndex = 2;
            this.picThree.TabStop = false;
            this.picThree.Click += new System.EventHandler(this.picThree_Click);
            // 
            // txtBaydin
            // 
            this.txtBaydin.Location = new System.Drawing.Point(43, 383);
            this.txtBaydin.Name = "txtBaydin";
            this.txtBaydin.Size = new System.Drawing.Size(667, 103);
            this.txtBaydin.TabIndex = 3;
            this.txtBaydin.Text = "";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(41, 511);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(668, 35);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmThreeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 566);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtBaydin);
            this.Controls.Add(this.picThree);
            this.Controls.Add(this.picTwo);
            this.Controls.Add(this.picOne);
            this.Name = "frmThreeCard";
            this.Load += new System.EventHandler(this.frmThreeCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picOne;
        private System.Windows.Forms.PictureBox picTwo;
        private System.Windows.Forms.PictureBox picThree;
        private System.Windows.Forms.RichTextBox txtBaydin;
        private System.Windows.Forms.Button btnReset;
    }
}

