namespace MyMediaPlayer
{
    partial class frmPlayer
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lstFileList = new System.Windows.Forms.ListBox();
            this.btnLoadFileList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(15, 67);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(342, 26);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "D:\\! Computer Science  igcse\\1-Kid Lessons";
            // 
            // lstFileList
            // 
            this.lstFileList.FormattingEnabled = true;
            this.lstFileList.HorizontalScrollbar = true;
            this.lstFileList.ItemHeight = 20;
            this.lstFileList.Location = new System.Drawing.Point(15, 160);
            this.lstFileList.Name = "lstFileList";
            this.lstFileList.ScrollAlwaysVisible = true;
            this.lstFileList.Size = new System.Drawing.Size(342, 324);
            this.lstFileList.TabIndex = 1;
            this.lstFileList.SelectedIndexChanged += new System.EventHandler(this.lstFileList_SelectedIndexChanged);
            // 
            // btnLoadFileList
            // 
            this.btnLoadFileList.Location = new System.Drawing.Point(15, 106);
            this.btnLoadFileList.Name = "btnLoadFileList";
            this.btnLoadFileList.Size = new System.Drawing.Size(342, 48);
            this.btnLoadFileList.TabIndex = 2;
            this.btnLoadFileList.Text = "Load Files";
            this.btnLoadFileList.UseVisualStyleBackColor = true;
            this.btnLoadFileList.Click += new System.EventHandler(this.btnLoadFileList_Click);
            // 
            // frmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 505);
            this.Controls.Add(this.btnLoadFileList);
            this.Controls.Add(this.lstFileList);
            this.Controls.Add(this.txtPath);
            this.Name = "frmPlayer";
            this.Text = "My Media Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ListBox lstFileList;
        private System.Windows.Forms.Button btnLoadFileList;
    }
}

