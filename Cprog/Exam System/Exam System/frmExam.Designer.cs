namespace Exam_System
{
    partial class frmExam
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
            this.txtQuestion = new System.Windows.Forms.RichTextBox();
            this.rdo1 = new System.Windows.Forms.RadioButton();
            this.rdo2 = new System.Windows.Forms.RadioButton();
            this.rdo3 = new System.Windows.Forms.RadioButton();
            this.lblQno = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtScores = new System.Windows.Forms.TextBox();
            this.rdo4 = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.ofdFname = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(30, 60);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(930, 136);
            this.txtQuestion.TabIndex = 0;
            this.txtQuestion.Text = "";
            // 
            // rdo1
            // 
            this.rdo1.AutoSize = true;
            this.rdo1.Location = new System.Drawing.Point(30, 218);
            this.rdo1.Name = "rdo1";
            this.rdo1.Size = new System.Drawing.Size(126, 24);
            this.rdo1.TabIndex = 1;
            this.rdo1.TabStop = true;
            this.rdo1.Text = "radioButton1";
            this.rdo1.UseVisualStyleBackColor = true;
            // 
            // rdo2
            // 
            this.rdo2.AutoSize = true;
            this.rdo2.Location = new System.Drawing.Point(30, 249);
            this.rdo2.Name = "rdo2";
            this.rdo2.Size = new System.Drawing.Size(126, 24);
            this.rdo2.TabIndex = 2;
            this.rdo2.TabStop = true;
            this.rdo2.Text = "radioButton2";
            this.rdo2.UseVisualStyleBackColor = true;
            // 
            // rdo3
            // 
            this.rdo3.AutoSize = true;
            this.rdo3.Location = new System.Drawing.Point(30, 280);
            this.rdo3.Name = "rdo3";
            this.rdo3.Size = new System.Drawing.Size(126, 24);
            this.rdo3.TabIndex = 3;
            this.rdo3.TabStop = true;
            this.rdo3.Text = "radioButton3";
            this.rdo3.UseVisualStyleBackColor = true;
            // 
            // lblQno
            // 
            this.lblQno.AutoSize = true;
            this.lblQno.Location = new System.Drawing.Point(909, 18);
            this.lblQno.Name = "lblQno";
            this.lblQno.Size = new System.Drawing.Size(51, 20);
            this.lblQno.TabIndex = 4;
            this.lblQno.Text = "label1";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(653, 306);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(866, 306);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(96, 35);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(851, 220);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(59, 20);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Scores";
            // 
            // txtScores
            // 
            this.txtScores.Location = new System.Drawing.Point(855, 249);
            this.txtScores.Name = "txtScores";
            this.txtScores.Size = new System.Drawing.Size(107, 26);
            this.txtScores.TabIndex = 8;
            // 
            // rdo4
            // 
            this.rdo4.AutoSize = true;
            this.rdo4.Location = new System.Drawing.Point(30, 311);
            this.rdo4.Name = "rdo4";
            this.rdo4.Size = new System.Drawing.Size(126, 24);
            this.rdo4.TabIndex = 9;
            this.rdo4.TabStop = true;
            this.rdo4.Text = "radioButton2";
            this.rdo4.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(761, 306);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 35);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Question";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(196, 15);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(346, 26);
            this.txtFname.TabIndex = 12;
            this.txtFname.Text = "D:\\CStutorial\\Quiz\\\\q1.txt";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(548, 13);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(88, 28);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(642, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 28);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ofdFname
            // 
            this.ofdFname.FileName = "openFileDialog1";
            // 
            // frmExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 362);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rdo4);
            this.Controls.Add(this.txtScores);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblQno);
            this.Controls.Add(this.rdo3);
            this.Controls.Add(this.rdo2);
            this.Controls.Add(this.rdo1);
            this.Controls.Add(this.txtQuestion);
            this.Name = "frmExam";
            this.Text = "Exam System 2022";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExam_FormClosing);
            this.Load += new System.EventHandler(this.frmExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtQuestion;
        private System.Windows.Forms.RadioButton rdo1;
        private System.Windows.Forms.RadioButton rdo2;
        private System.Windows.Forms.RadioButton rdo3;
        private System.Windows.Forms.Label lblQno;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtScores;
        private System.Windows.Forms.RadioButton rdo4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.OpenFileDialog ofdFname;
    }
}

