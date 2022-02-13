namespace _2022021101InputAndStore
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
            this.lblUname = new System.Windows.Forms.Label();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.txtUage = new System.Windows.Forms.TextBox();
            this.lblUage = new System.Windows.Forms.Label();
            this.btnGreeting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Location = new System.Drawing.Point(29, 25);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(83, 20);
            this.lblUname.TabIndex = 0;
            this.lblUname.Text = "Username";
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(135, 18);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(209, 26);
            this.txtUname.TabIndex = 1;
            // 
            // txtUage
            // 
            this.txtUage.Location = new System.Drawing.Point(135, 50);
            this.txtUage.Name = "txtUage";
            this.txtUage.Size = new System.Drawing.Size(209, 26);
            this.txtUage.TabIndex = 3;
            // 
            // lblUage
            // 
            this.lblUage.AutoSize = true;
            this.lblUage.Location = new System.Drawing.Point(29, 57);
            this.lblUage.Name = "lblUage";
            this.lblUage.Size = new System.Drawing.Size(38, 20);
            this.lblUage.TabIndex = 2;
            this.lblUage.Text = "Age";
            // 
            // btnGreeting
            // 
            this.btnGreeting.Location = new System.Drawing.Point(29, 97);
            this.btnGreeting.Name = "btnGreeting";
            this.btnGreeting.Size = new System.Drawing.Size(314, 69);
            this.btnGreeting.TabIndex = 4;
            this.btnGreeting.Text = "Greeting";
            this.btnGreeting.UseVisualStyleBackColor = true;
            this.btnGreeting.Click += new System.EventHandler(this.btnGreeting_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 175);
            this.Controls.Add(this.btnGreeting);
            this.Controls.Add(this.txtUage);
            this.Controls.Add(this.lblUage);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.lblUname);
            this.Name = "frmMain";
            this.Text = "Input Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.TextBox txtUage;
        private System.Windows.Forms.Label lblUage;
        private System.Windows.Forms.Button btnGreeting;
    }
}

