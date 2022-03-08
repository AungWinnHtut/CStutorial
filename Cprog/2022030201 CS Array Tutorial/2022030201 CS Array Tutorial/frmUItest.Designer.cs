namespace _2022030201_CS_Array_Tutorial
{
    partial class frmUItest
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
            this.cboCities = new System.Windows.Forms.ComboBox();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboCities
            // 
            this.cboCities.FormattingEnabled = true;
            this.cboCities.Location = new System.Drawing.Point(66, 45);
            this.cboCities.Name = "cboCities";
            this.cboCities.Size = new System.Drawing.Size(219, 28);
            this.cboCities.TabIndex = 0;
            this.cboCities.SelectedIndexChanged += new System.EventHandler(this.cboCities_SelectedIndexChanged);
            // 
            // btnAddCity
            // 
            this.btnAddCity.Location = new System.Drawing.Point(727, 87);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(157, 38);
            this.btnAddCity.TabIndex = 1;
            this.btnAddCity.Text = "Add City";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(727, 47);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(156, 26);
            this.txtCity.TabIndex = 2;
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(66, 123);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(99, 26);
            this.txtLeft.TabIndex = 3;
            // 
            // txtRight
            // 
            this.txtRight.Location = new System.Drawing.Point(186, 123);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(99, 26);
            this.txtRight.TabIndex = 4;
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(70, 95);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(51, 20);
            this.lblLeft.TabIndex = 5;
            this.lblLeft.Text = "label1";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(182, 95);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(51, 20);
            this.lblRight.TabIndex = 6;
            this.lblRight.Text = "label2";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(66, 174);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(218, 35);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmUItest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 552);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.btnAddCity);
            this.Controls.Add(this.cboCities);
            this.Name = "frmUItest";
            this.Text = "frmUItest";
            this.Load += new System.EventHandler(this.frmUItest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCities;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Button btnCalculate;
    }
}