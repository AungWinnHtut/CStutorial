namespace FileIOnew
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
            this.btnFileExist = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileNewPath = new System.Windows.Forms.TextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFileExist
            // 
            this.btnFileExist.Location = new System.Drawing.Point(37, 78);
            this.btnFileExist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFileExist.Name = "btnFileExist";
            this.btnFileExist.Size = new System.Drawing.Size(124, 41);
            this.btnFileExist.TabIndex = 0;
            this.btnFileExist.Text = "File Exists?";
            this.btnFileExist.UseVisualStyleBackColor = true;
            this.btnFileExist.Click += new System.EventHandler(this.btnFileExist_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(36, 44);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(129, 23);
            this.txtFilePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "File New Path";
            // 
            // txtFileNewPath
            // 
            this.txtFileNewPath.Location = new System.Drawing.Point(193, 44);
            this.txtFileNewPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFileNewPath.Name = "txtFileNewPath";
            this.txtFileNewPath.Size = new System.Drawing.Size(129, 23);
            this.txtFileNewPath.TabIndex = 4;
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(195, 78);
            this.btnRename.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(124, 41);
            this.btnRename.TabIndex = 3;
            this.btnRename.Text = "Rename File";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(39, 131);
            this.btnDeleteFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(124, 41);
            this.btnDeleteFile.TabIndex = 6;
            this.btnDeleteFile.Text = "Delete File";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 131);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Copy File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmFileIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFileNewPath);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnFileExist);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmFileIO";
            this.Text = "File IO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnFileExist;
        private TextBox txtFilePath;
        private Label label1;
        private Label label2;
        private TextBox txtFileNewPath;
        private Button btnRename;
        private Button btnDeleteFile;
        private Button button1;
    }
}