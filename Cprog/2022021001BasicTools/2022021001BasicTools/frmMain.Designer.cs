namespace _2022021001BasicTools
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cldrToday = new System.Windows.Forms.MonthCalendar();
            this.picBaydin = new System.Windows.Forms.PictureBox();
            this.txtBaydin = new System.Windows.Forms.TextBox();
            this.txtAns = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBaydin)).BeginInit();
            this.SuspendLayout();
            // 
            // cldrToday
            // 
            this.cldrToday.Location = new System.Drawing.Point(310, 18);
            this.cldrToday.Name = "cldrToday";
            this.cldrToday.TabIndex = 0;
            // 
            // picBaydin
            // 
            this.picBaydin.Image = ((System.Drawing.Image)(resources.GetObject("picBaydin.Image")));
            this.picBaydin.Location = new System.Drawing.Point(33, 18);
            this.picBaydin.Name = "picBaydin";
            this.picBaydin.Size = new System.Drawing.Size(245, 253);
            this.picBaydin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBaydin.TabIndex = 1;
            this.picBaydin.TabStop = false;
            this.picBaydin.Click += new System.EventHandler(this.picBaydin_Click);
            // 
            // txtBaydin
            // 
            this.txtBaydin.Location = new System.Drawing.Point(33, 348);
            this.txtBaydin.Multiline = true;
            this.txtBaydin.Name = "txtBaydin";
            this.txtBaydin.Size = new System.Drawing.Size(244, 75);
            this.txtBaydin.TabIndex = 2;
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(33, 292);
            this.txtAns.Multiline = true;
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(244, 41);
            this.txtAns.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.txtBaydin);
            this.Controls.Add(this.picBaydin);
            this.Controls.Add(this.cldrToday);
            this.Name = "frmMain";
            this.Text = "Basic Tools Tutorial";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBaydin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar cldrToday;
        private System.Windows.Forms.PictureBox picBaydin;
        private System.Windows.Forms.TextBox txtBaydin;
        private System.Windows.Forms.TextBox txtAns;
    }
}

