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
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFileReader
            // 
            this.txtFileReader.Location = new System.Drawing.Point(22, 105);
            this.txtFileReader.Name = "txtFileReader";
            this.txtFileReader.Size = new System.Drawing.Size(744, 218);
            this.txtFileReader.TabIndex = 0;
            this.txtFileReader.Text = "";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(145, 358);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(131, 71);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.Location = new System.Drawing.Point(330, 358);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(131, 71);
            this.btnWriteFile.TabIndex = 2;
            this.btnWriteFile.Text = "Save File";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            this.btnWriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(523, 358);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 71);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(22, 55);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(743, 26);
            this.txtFname.TabIndex = 4;
            // 
            // frmFileReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnWriteFile);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtFileReader);
            this.Name = "frmFileReader";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmFileReader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtFileReader;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtFname;
    }
}

