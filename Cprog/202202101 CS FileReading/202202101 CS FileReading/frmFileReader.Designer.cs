namespace _202202101_CS_FileReading
{
    partial class frmFileReader
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
            this.txtFileReader = new System.Windows.Forms.RichTextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFileReader
            // 
            this.txtFileReader.Location = new System.Drawing.Point(30, 36);
            this.txtFileReader.Name = "txtFileReader";
            this.txtFileReader.Size = new System.Drawing.Size(744, 218);
            this.txtFileReader.TabIndex = 0;
            this.txtFileReader.Text = "";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(312, 298);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(131, 71);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // frmFileReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtFileReader);
            this.Name = "frmFileReader";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmFileReader_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtFileReader;
        private System.Windows.Forms.Button btnRead;
    }
}

