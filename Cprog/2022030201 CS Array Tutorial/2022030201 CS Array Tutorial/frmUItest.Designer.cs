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
            this.SuspendLayout();
            // 
            // cboCities
            // 
            this.cboCities.FormattingEnabled = true;
            this.cboCities.Items.AddRange(new object[] {
            "Yangon",
            "Mandalay",
            "PyinOoLwin"});
            this.cboCities.Location = new System.Drawing.Point(66, 45);
            this.cboCities.Name = "cboCities";
            this.cboCities.Size = new System.Drawing.Size(219, 28);
            this.cboCities.TabIndex = 0;
            this.cboCities.Text = "Choose Your Location....";
            this.cboCities.SelectedIndexChanged += new System.EventHandler(this.cboCities_SelectedIndexChanged);
            // 
            // btnAddCity
            // 
            this.btnAddCity.Location = new System.Drawing.Point(332, 84);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(157, 38);
            this.btnAddCity.TabIndex = 1;
            this.btnAddCity.Text = "Add City";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(332, 44);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(156, 26);
            this.txtCity.TabIndex = 2;
            // 
            // frmUItest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 552);
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
    }
}