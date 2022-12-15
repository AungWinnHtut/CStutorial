namespace QuizApp3
{
    partial class frmQuiz1
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
            this.lblQ1_1 = new System.Windows.Forms.Label();
            this.rdoAns1_1 = new System.Windows.Forms.RadioButton();
            this.rdoAns2_1 = new System.Windows.Forms.RadioButton();
            this.rdoAns3_1 = new System.Windows.Forms.RadioButton();
            this.btnSend_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQ1_1
            // 
            this.lblQ1_1.AutoSize = true;
            this.lblQ1_1.Location = new System.Drawing.Point(226, 26);
            this.lblQ1_1.Name = "lblQ1_1";
            this.lblQ1_1.Size = new System.Drawing.Size(86, 20);
            this.lblQ1_1.TabIndex = 0;
            this.lblQ1_1.Text = "Question 1";
            // 
            // rdoAns1_1
            // 
            this.rdoAns1_1.AutoSize = true;
            this.rdoAns1_1.Location = new System.Drawing.Point(52, 94);
            this.rdoAns1_1.Name = "rdoAns1_1";
            this.rdoAns1_1.Size = new System.Drawing.Size(71, 24);
            this.rdoAns1_1.TabIndex = 1;
            this.rdoAns1_1.TabStop = true;
            this.rdoAns1_1.Text = "Ans1";
            this.rdoAns1_1.UseVisualStyleBackColor = true;
            // 
            // rdoAns2_1
            // 
            this.rdoAns2_1.AutoSize = true;
            this.rdoAns2_1.Location = new System.Drawing.Point(230, 94);
            this.rdoAns2_1.Name = "rdoAns2_1";
            this.rdoAns2_1.Size = new System.Drawing.Size(71, 24);
            this.rdoAns2_1.TabIndex = 2;
            this.rdoAns2_1.TabStop = true;
            this.rdoAns2_1.Text = "Ans2";
            this.rdoAns2_1.UseVisualStyleBackColor = true;
            // 
            // rdoAns3_1
            // 
            this.rdoAns3_1.AutoSize = true;
            this.rdoAns3_1.Location = new System.Drawing.Point(408, 94);
            this.rdoAns3_1.Name = "rdoAns3_1";
            this.rdoAns3_1.Size = new System.Drawing.Size(71, 24);
            this.rdoAns3_1.TabIndex = 3;
            this.rdoAns3_1.TabStop = true;
            this.rdoAns3_1.Text = "Ans3";
            this.rdoAns3_1.UseVisualStyleBackColor = true;
            // 
            // btnSend_1
            // 
            this.btnSend_1.Location = new System.Drawing.Point(442, 141);
            this.btnSend_1.Name = "btnSend_1";
            this.btnSend_1.Size = new System.Drawing.Size(118, 54);
            this.btnSend_1.TabIndex = 4;
            this.btnSend_1.Text = "Send";
            this.btnSend_1.UseVisualStyleBackColor = true;
            this.btnSend_1.Click += new System.EventHandler(this.btnSend_1_Click);
            // 
            // frmQuiz1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 216);
            this.Controls.Add(this.btnSend_1);
            this.Controls.Add(this.rdoAns3_1);
            this.Controls.Add(this.rdoAns2_1);
            this.Controls.Add(this.rdoAns1_1);
            this.Controls.Add(this.lblQ1_1);
            this.Name = "frmQuiz1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmQuiz1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQ1_1;
        private System.Windows.Forms.RadioButton rdoAns1_1;
        private System.Windows.Forms.RadioButton rdoAns2_1;
        private System.Windows.Forms.RadioButton rdoAns3_1;
        private System.Windows.Forms.Button btnSend_1;
    }
}

