namespace _2022021601_CS_3CardGame_Random
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
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtBaydin = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(29, 27);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(228, 311);
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(282, 27);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(228, 311);
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            this.pic2.Click += new System.EventHandler(this.pic2_Click);
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(535, 27);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(228, 311);
            this.pic3.TabIndex = 2;
            this.pic3.TabStop = false;
            this.pic3.Click += new System.EventHandler(this.pic3_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(29, 458);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(733, 66);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtBaydin
            // 
            this.txtBaydin.Location = new System.Drawing.Point(33, 360);
            this.txtBaydin.Name = "txtBaydin";
            this.txtBaydin.Size = new System.Drawing.Size(729, 73);
            this.txtBaydin.TabIndex = 4;
            this.txtBaydin.Text = "";
            // 
            // frmThreeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.txtBaydin);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Name = "frmThreeCard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmThreeCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RichTextBox txtBaydin;
    }
}

