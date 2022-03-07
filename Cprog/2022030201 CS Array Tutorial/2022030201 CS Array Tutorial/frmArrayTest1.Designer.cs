namespace _2022030201_CS_Array_Tutorial
{
    partial class frmArrayTest1
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
            this.btnReadString = new System.Windows.Forms.Button();
            this.txtSinput = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.btnAddString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadString
            // 
            this.btnReadString.Location = new System.Drawing.Point(49, 93);
            this.btnReadString.Name = "btnReadString";
            this.btnReadString.Size = new System.Drawing.Size(614, 53);
            this.btnReadString.TabIndex = 0;
            this.btnReadString.Text = "Read String";
            this.btnReadString.UseVisualStyleBackColor = true;
            this.btnReadString.Click += new System.EventHandler(this.btnReadString_Click);
            // 
            // txtSinput
            // 
            this.txtSinput.Location = new System.Drawing.Point(49, 35);
            this.txtSinput.Name = "txtSinput";
            this.txtSinput.Size = new System.Drawing.Size(614, 26);
            this.txtSinput.TabIndex = 1;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(49, 204);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(122, 26);
            this.txt1.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(301, 204);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(122, 26);
            this.txt2.TabIndex = 3;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(541, 204);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(122, 26);
            this.txt3.TabIndex = 4;
            // 
            // btnAddString
            // 
            this.btnAddString.Location = new System.Drawing.Point(49, 278);
            this.btnAddString.Name = "btnAddString";
            this.btnAddString.Size = new System.Drawing.Size(614, 53);
            this.btnAddString.TabIndex = 5;
            this.btnAddString.Text = "Add String";
            this.btnAddString.UseVisualStyleBackColor = true;
            this.btnAddString.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmArrayTest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.btnAddString);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txtSinput);
            this.Controls.Add(this.btnReadString);
            this.Name = "frmArrayTest1";
            this.Text = "frmArrayTest1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadString;
        private System.Windows.Forms.TextBox txtSinput;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Button btnAddString;
    }
}