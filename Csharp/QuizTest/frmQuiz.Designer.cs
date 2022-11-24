namespace QuizTest
{
    partial class frmQuiz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picLeft = new System.Windows.Forms.PictureBox();
            this.picRight = new System.Windows.Forms.PictureBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).BeginInit();
            this.SuspendLayout();
            // 
            // picLeft
            // 
            this.picLeft.Location = new System.Drawing.Point(33, 119);
            this.picLeft.Name = "picLeft";
            this.picLeft.Size = new System.Drawing.Size(330, 224);
            this.picLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLeft.TabIndex = 0;
            this.picLeft.TabStop = false;
            this.picLeft.Click += new System.EventHandler(this.picLeft_Click);
            // 
            // picRight
            // 
            this.picRight.Location = new System.Drawing.Point(431, 119);
            this.picRight.Name = "picRight";
            this.picRight.Size = new System.Drawing.Size(330, 224);
            this.picRight.TabIndex = 1;
            this.picRight.TabStop = false;
            this.picRight.Click += new System.EventHandler(this.picRight_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(359, 26);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(59, 25);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "label1";
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(134, 375);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(59, 25);
            this.lblLeft.TabIndex = 3;
            this.lblLeft.Text = "label2";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(551, 375);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(59, 25);
            this.lblRight.TabIndex = 4;
            this.lblRight.Text = "label2";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarks.ForeColor = System.Drawing.Color.Red;
            this.lblMarks.Location = new System.Drawing.Point(692, 403);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(96, 38);
            this.lblMarks.TabIndex = 5;
            this.lblMarks.Text = "label1";
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.picRight);
            this.Controls.Add(this.picLeft);
            this.Name = "frmQuiz";
            this.Text = "Green Hackers Quiz App";
            this.Load += new System.EventHandler(this.frmQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picLeft;
        private PictureBox picRight;
        private Label lblQuestion;
        private Label lblLeft;
        private Label lblRight;
        private Label lblMarks;
    }
}