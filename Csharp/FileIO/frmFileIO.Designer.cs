namespace FileIO
{
    partial class frmFileIO
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
            this.btnFileCheck = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewFilePath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFileCheck
            // 
            this.btnFileCheck.Location = new System.Drawing.Point(66, 147);
            this.btnFileCheck.Name = "btnFileCheck";
            this.btnFileCheck.Size = new System.Drawing.Size(233, 75);
            this.btnFileCheck.TabIndex = 0;
            this.btnFileCheck.Text = "File Check";
            this.btnFileCheck.UseVisualStyleBackColor = true;
            this.btnFileCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(66, 86);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(231, 31);
            this.txtFilePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter File Path";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(375, 147);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(236, 73);
            this.btnRename.TabIndex = 3;
            this.btnRename.Text = "Rename File";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "New File Path";
            // 
            // txtNewFilePath
            // 
            this.txtNewFilePath.Location = new System.Drawing.Point(375, 86);
            this.txtNewFilePath.Name = "txtNewFilePath";
            this.txtNewFilePath.Size = new System.Drawing.Size(231, 31);
            this.txtNewFilePath.TabIndex = 4;
            // 
            // frmFileIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewFilePath);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnFileCheck);
            this.Name = "frmFileIO";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnFileCheck;
        private TextBox txtFilePath;
        private Label label1;
        private Button btnRename;
        private Label label2;
        private TextBox txtNewFilePath;
    }
}