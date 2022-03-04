namespace _2022030201_CS_Array_Tutorial
{
    partial class frmArray
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
            this.btnTest = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.RichTextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtAns2 = new System.Windows.Forms.TextBox();
            this.txtAns1 = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtAns3 = new System.Windows.Forms.TextBox();
            this.txtCorrectAnswer = new System.Windows.Forms.TextBox();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(60, 320);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(169, 36);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Next Question";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(44, 32);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(561, 268);
            this.txtAnswer.TabIndex = 1;
            this.txtAnswer.Text = "";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(657, 110);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(173, 26);
            this.txtNumber.TabIndex = 2;
            // 
            // txtAns2
            // 
            this.txtAns2.Location = new System.Drawing.Point(657, 206);
            this.txtAns2.Name = "txtAns2";
            this.txtAns2.Size = new System.Drawing.Size(173, 26);
            this.txtAns2.TabIndex = 3;
            // 
            // txtAns1
            // 
            this.txtAns1.Location = new System.Drawing.Point(657, 174);
            this.txtAns1.Name = "txtAns1";
            this.txtAns1.Size = new System.Drawing.Size(173, 26);
            this.txtAns1.TabIndex = 4;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(657, 142);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(173, 26);
            this.txtQuestion.TabIndex = 5;
            // 
            // txtAns3
            // 
            this.txtAns3.Location = new System.Drawing.Point(657, 238);
            this.txtAns3.Name = "txtAns3";
            this.txtAns3.Size = new System.Drawing.Size(173, 26);
            this.txtAns3.TabIndex = 7;
            // 
            // txtCorrectAnswer
            // 
            this.txtCorrectAnswer.Location = new System.Drawing.Point(657, 270);
            this.txtCorrectAnswer.Name = "txtCorrectAnswer";
            this.txtCorrectAnswer.Size = new System.Drawing.Size(173, 26);
            this.txtCorrectAnswer.TabIndex = 6;
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Location = new System.Drawing.Point(771, 7);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.Size = new System.Drawing.Size(58, 26);
            this.txtTotalMarks.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTotalMarks);
            this.Controls.Add(this.txtAns3);
            this.Controls.Add(this.txtCorrectAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.txtAns1);
            this.Controls.Add(this.txtAns2);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnTest);
            this.Name = "frmArray";
            this.Text = "Array Tutorials";
            this.Load += new System.EventHandler(this.frmArray_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.RichTextBox txtAnswer;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtAns2;
        private System.Windows.Forms.TextBox txtAns1;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtAns3;
        private System.Windows.Forms.TextBox txtCorrectAnswer;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.Button button1;
    }
}

