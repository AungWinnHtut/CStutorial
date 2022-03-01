namespace _2022022401_CS_Login_Exam_2
{
    partial class frmPhysics
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
            this.txtPhysicsQuestion = new System.Windows.Forms.RichTextBox();
            this.lblAns1 = new System.Windows.Forms.Label();
            this.lblAns2 = new System.Windows.Forms.Label();
            this.lblAns3 = new System.Windows.Forms.Label();
            this.txtMultipleChoice = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPhysicsTotalMarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNextPhysicsQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPhysicsQuestion
            // 
            this.txtPhysicsQuestion.Enabled = false;
            this.txtPhysicsQuestion.Location = new System.Drawing.Point(18, 55);
            this.txtPhysicsQuestion.Name = "txtPhysicsQuestion";
            this.txtPhysicsQuestion.Size = new System.Drawing.Size(958, 86);
            this.txtPhysicsQuestion.TabIndex = 0;
            this.txtPhysicsQuestion.Text = "";
            // 
            // lblAns1
            // 
            this.lblAns1.AutoSize = true;
            this.lblAns1.Location = new System.Drawing.Point(23, 171);
            this.lblAns1.Name = "lblAns1";
            this.lblAns1.Size = new System.Drawing.Size(51, 20);
            this.lblAns1.TabIndex = 1;
            this.lblAns1.Text = "label1";
            // 
            // lblAns2
            // 
            this.lblAns2.AutoSize = true;
            this.lblAns2.Location = new System.Drawing.Point(344, 171);
            this.lblAns2.Name = "lblAns2";
            this.lblAns2.Size = new System.Drawing.Size(51, 20);
            this.lblAns2.TabIndex = 2;
            this.lblAns2.Text = "label2";
            // 
            // lblAns3
            // 
            this.lblAns3.AutoSize = true;
            this.lblAns3.Location = new System.Drawing.Point(694, 171);
            this.lblAns3.Name = "lblAns3";
            this.lblAns3.Size = new System.Drawing.Size(51, 20);
            this.lblAns3.TabIndex = 3;
            this.lblAns3.Text = "label3";
            // 
            // txtMultipleChoice
            // 
            this.txtMultipleChoice.Location = new System.Drawing.Point(27, 224);
            this.txtMultipleChoice.Name = "txtMultipleChoice";
            this.txtMultipleChoice.Size = new System.Drawing.Size(103, 26);
            this.txtMultipleChoice.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(169, 224);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(807, 41);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPhysicsTotalMarks
            // 
            this.txtPhysicsTotalMarks.Location = new System.Drawing.Point(855, 13);
            this.txtPhysicsTotalMarks.Name = "txtPhysicsTotalMarks";
            this.txtPhysicsTotalMarks.Size = new System.Drawing.Size(120, 26);
            this.txtPhysicsTotalMarks.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total Marks";
            // 
            // btnNextPhysicsQuestion
            // 
            this.btnNextPhysicsQuestion.Location = new System.Drawing.Point(829, 271);
            this.btnNextPhysicsQuestion.Name = "btnNextPhysicsQuestion";
            this.btnNextPhysicsQuestion.Size = new System.Drawing.Size(146, 30);
            this.btnNextPhysicsQuestion.TabIndex = 8;
            this.btnNextPhysicsQuestion.Text = ">>>>>";
            this.btnNextPhysicsQuestion.UseVisualStyleBackColor = true;
            this.btnNextPhysicsQuestion.Click += new System.EventHandler(this.btnNextPhysicsQuestion_Click);
            // 
            // frmPhysics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 313);
            this.Controls.Add(this.btnNextPhysicsQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhysicsTotalMarks);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtMultipleChoice);
            this.Controls.Add(this.lblAns3);
            this.Controls.Add(this.lblAns2);
            this.Controls.Add(this.lblAns1);
            this.Controls.Add(this.txtPhysicsQuestion);
            this.Name = "frmPhysics";
            this.Text = "frmPhysics";
            this.Load += new System.EventHandler(this.frmPhysics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtPhysicsQuestion;
        private System.Windows.Forms.Label lblAns1;
        private System.Windows.Forms.Label lblAns2;
        private System.Windows.Forms.Label lblAns3;
        private System.Windows.Forms.TextBox txtMultipleChoice;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPhysicsTotalMarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNextPhysicsQuestion;
    }
}