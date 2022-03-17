namespace PlayerTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayer));
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnLoadFileList = new System.Windows.Forms.Button();
            this.lstFileList = new System.Windows.Forms.ListBox();
            this.wmpPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.ofdSelectFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(11, 48);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(405, 26);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "D:\\! Computer Science  igcse\\2-Microbit Lessons";
            // 
            // btnLoadFileList
            // 
            this.btnLoadFileList.Location = new System.Drawing.Point(11, 88);
            this.btnLoadFileList.Name = "btnLoadFileList";
            this.btnLoadFileList.Size = new System.Drawing.Size(405, 46);
            this.btnLoadFileList.TabIndex = 1;
            this.btnLoadFileList.Text = "Load File List";
            this.btnLoadFileList.UseVisualStyleBackColor = true;
            this.btnLoadFileList.Click += new System.EventHandler(this.btnLoadFileList_Click);
            // 
            // lstFileList
            // 
            this.lstFileList.FormattingEnabled = true;
            this.lstFileList.HorizontalScrollbar = true;
            this.lstFileList.ItemHeight = 20;
            this.lstFileList.Location = new System.Drawing.Point(13, 223);
            this.lstFileList.Name = "lstFileList";
            this.lstFileList.ScrollAlwaysVisible = true;
            this.lstFileList.Size = new System.Drawing.Size(403, 444);
            this.lstFileList.TabIndex = 2;
            this.lstFileList.SelectedIndexChanged += new System.EventHandler(this.lstFileList_SelectedIndexChanged);
            // 
            // wmpPlayer
            // 
            this.wmpPlayer.Enabled = true;
            this.wmpPlayer.Location = new System.Drawing.Point(439, 48);
            this.wmpPlayer.Name = "wmpPlayer";
            this.wmpPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpPlayer.OcxState")));
            this.wmpPlayer.Size = new System.Drawing.Size(505, 351);
            this.wmpPlayer.TabIndex = 3;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(11, 149);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(404, 51);
            this.btnBrowseFile.TabIndex = 4;
            this.btnBrowseFile.Text = "Browse File";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // ofdSelectFile
            // 
            this.ofdSelectFile.FileName = "openFileDialog1";
            // 
            // frmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 685);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.wmpPlayer);
            this.Controls.Add(this.lstFileList);
            this.Controls.Add(this.btnLoadFileList);
            this.Controls.Add(this.txtPath);
            this.Name = "frmPlayer";
            this.Text = "Player";
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnLoadFileList;
        private System.Windows.Forms.ListBox lstFileList;
        private AxWMPLib.AxWindowsMediaPlayer wmpPlayer;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.OpenFileDialog ofdSelectFile;
    }
}

