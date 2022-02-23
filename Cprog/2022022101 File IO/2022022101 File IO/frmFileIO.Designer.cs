namespace _2022022101_File_IO
{
    partial class frmFileIO
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
            this.txtTimes = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTimes
            // 
            this.txtTimes.Location = new System.Drawing.Point(52, 58);
            this.txtTimes.Name = "txtTimes";
            this.txtTimes.Size = new System.Drawing.Size(50, 26);
            this.txtTimes.TabIndex = 0;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(156, 58);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(50, 26);
            this.txtCount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "ˣ";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(52, 107);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(314, 82);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "=";
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(279, 58);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(87, 26);
            this.txtAns.TabIndex = 5;
            // 
            // frmFileIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 238);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtTimes);
            this.Name = "frmFileIO";
            this.Text = "Maths Quiz";
            this.Load += new System.EventHandler(this.frmFileIO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimes;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAns;
    }
}

