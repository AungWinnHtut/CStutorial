namespace AppBar
{
    partial class AppBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppBar));
            this.picNotePad = new System.Windows.Forms.PictureBox();
            this.picPaint = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picCommand = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNotePad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCommand)).BeginInit();
            this.SuspendLayout();
            // 
            // picNotePad
            // 
            this.picNotePad.Image = ((System.Drawing.Image)(resources.GetObject("picNotePad.Image")));
            this.picNotePad.Location = new System.Drawing.Point(19, 7);
            this.picNotePad.Name = "picNotePad";
            this.picNotePad.Size = new System.Drawing.Size(137, 95);
            this.picNotePad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNotePad.TabIndex = 0;
            this.picNotePad.TabStop = false;
            this.picNotePad.Click += new System.EventHandler(this.picNotePad_Click);
            // 
            // picPaint
            // 
            this.picPaint.Image = ((System.Drawing.Image)(resources.GetObject("picPaint.Image")));
            this.picPaint.Location = new System.Drawing.Point(19, 111);
            this.picPaint.Name = "picPaint";
            this.picPaint.Size = new System.Drawing.Size(137, 95);
            this.picPaint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPaint.TabIndex = 1;
            this.picPaint.TabStop = false;
            this.picPaint.Click += new System.EventHandler(this.picPaint_Click);
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(19, 319);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(137, 95);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 3;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // picCommand
            // 
            this.picCommand.Image = ((System.Drawing.Image)(resources.GetObject("picCommand.Image")));
            this.picCommand.Location = new System.Drawing.Point(19, 215);
            this.picCommand.Name = "picCommand";
            this.picCommand.Size = new System.Drawing.Size(137, 95);
            this.picCommand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCommand.TabIndex = 2;
            this.picCommand.TabStop = false;
            this.picCommand.Click += new System.EventHandler(this.picCommand_Click);
            // 
            // AppBar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(176, 417);
            this.ControlBox = false;
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picCommand);
            this.Controls.Add(this.picPaint);
            this.Controls.Add(this.picNotePad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppBar";
            this.Text = "App Bar by Green Hackers";
            this.Load += new System.EventHandler(this.AppBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNotePad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCommand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picNotePad;
        private System.Windows.Forms.PictureBox picPaint;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox picCommand;
    }
}

