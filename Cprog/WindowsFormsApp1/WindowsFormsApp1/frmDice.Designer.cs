namespace WindowsFormsApp1
{
    partial class frmDice
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
            this.btnDice = new System.Windows.Forms.Button();
            this.txtDice = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDice
            // 
            this.btnDice.Location = new System.Drawing.Point(94, 117);
            this.btnDice.Name = "btnDice";
            this.btnDice.Size = new System.Drawing.Size(183, 61);
            this.btnDice.TabIndex = 0;
            this.btnDice.Text = "Roll";
            this.btnDice.UseVisualStyleBackColor = true;
            this.btnDice.Click += new System.EventHandler(this.btnDice_Click);
            // 
            // txtDice
            // 
            this.txtDice.Location = new System.Drawing.Point(92, 24);
            this.txtDice.Name = "txtDice";
            this.txtDice.Size = new System.Drawing.Size(184, 56);
            this.txtDice.TabIndex = 1;
            this.txtDice.Text = "";
            // 
            // frmDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(405, 236);
            this.Controls.Add(this.txtDice);
            this.Controls.Add(this.btnDice);
            this.Name = "frmDice";
            this.Text = "Rolling Dice";
            this.Load += new System.EventHandler(this.frmDice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDice;
        private System.Windows.Forms.RichTextBox txtDice;
    }
}

