namespace HelloWorld
{
    partial class frmLogin
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
            this.btnMainForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMainForm
            // 
            this.btnMainForm.Location = new System.Drawing.Point(450, 119);
            this.btnMainForm.Name = "btnMainForm";
            this.btnMainForm.Size = new System.Drawing.Size(295, 86);
            this.btnMainForm.TabIndex = 0;
            this.btnMainForm.Text = "Main Form";
            this.btnMainForm.UseVisualStyleBackColor = true;
            this.btnMainForm.Click += new System.EventHandler(this.btnMainForm_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 361);
            this.Controls.Add(this.btnMainForm);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMainForm;
    }
}