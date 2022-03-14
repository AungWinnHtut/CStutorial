namespace _2022030201_CS_Array_Tutorial
{
    partial class frmUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUI));
            this.picPaint = new System.Windows.Forms.PictureBox();
            this.picDigital = new System.Windows.Forms.PictureBox();
            this.picNote = new System.Windows.Forms.PictureBox();
            this.picCommand = new System.Windows.Forms.PictureBox();
            this.lstFileList = new System.Windows.Forms.ListBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDigital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCommand)).BeginInit();
            this.SuspendLayout();
            // 
            // picPaint
            // 
            this.picPaint.Image = ((System.Drawing.Image)(resources.GetObject("picPaint.Image")));
            this.picPaint.Location = new System.Drawing.Point(11, 11);
            this.picPaint.Name = "picPaint";
            this.picPaint.Size = new System.Drawing.Size(158, 131);
            this.picPaint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPaint.TabIndex = 0;
            this.picPaint.TabStop = false;
            this.picPaint.Click += new System.EventHandler(this.picPaint_Click);
            // 
            // picDigital
            // 
            this.picDigital.Image = ((System.Drawing.Image)(resources.GetObject("picDigital.Image")));
            this.picDigital.Location = new System.Drawing.Point(195, 11);
            this.picDigital.Name = "picDigital";
            this.picDigital.Size = new System.Drawing.Size(158, 131);
            this.picDigital.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDigital.TabIndex = 1;
            this.picDigital.TabStop = false;
            this.picDigital.Click += new System.EventHandler(this.picDigital_Click);
            // 
            // picNote
            // 
            this.picNote.Image = ((System.Drawing.Image)(resources.GetObject("picNote.Image")));
            this.picNote.Location = new System.Drawing.Point(379, 11);
            this.picNote.Name = "picNote";
            this.picNote.Size = new System.Drawing.Size(158, 131);
            this.picNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNote.TabIndex = 2;
            this.picNote.TabStop = false;
            this.picNote.Click += new System.EventHandler(this.picNote_Click);
            // 
            // picCommand
            // 
            this.picCommand.Image = ((System.Drawing.Image)(resources.GetObject("picCommand.Image")));
            this.picCommand.Location = new System.Drawing.Point(563, 11);
            this.picCommand.Name = "picCommand";
            this.picCommand.Size = new System.Drawing.Size(158, 131);
            this.picCommand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCommand.TabIndex = 3;
            this.picCommand.TabStop = false;
            this.picCommand.Click += new System.EventHandler(this.picCommand_Click);
            // 
            // lstFileList
            // 
            this.lstFileList.FormattingEnabled = true;
            this.lstFileList.ItemHeight = 20;
            this.lstFileList.Location = new System.Drawing.Point(16, 234);
            this.lstFileList.Name = "lstFileList";
            this.lstFileList.Size = new System.Drawing.Size(704, 204);
            this.lstFileList.TabIndex = 4;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(16, 184);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(264, 26);
            this.txtPath.TabIndex = 5;
            this.txtPath.Text = "D:\\CStutorial\\Python";
            // 
            // frmUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 462);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lstFileList);
            this.Controls.Add(this.picCommand);
            this.Controls.Add(this.picNote);
            this.Controls.Add(this.picDigital);
            this.Controls.Add(this.picPaint);
            this.Name = "frmUI";
            this.Text = "Application Launcher";
            this.Load += new System.EventHandler(this.frmUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDigital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCommand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPaint;
        private System.Windows.Forms.PictureBox picDigital;
        private System.Windows.Forms.PictureBox picNote;
        private System.Windows.Forms.PictureBox picCommand;
        private System.Windows.Forms.ListBox lstFileList;
        private System.Windows.Forms.TextBox txtPath;
    }
}