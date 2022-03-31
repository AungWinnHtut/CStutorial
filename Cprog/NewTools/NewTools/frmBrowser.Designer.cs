namespace NewTools
{
    partial class frmBrowser
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
            this.brsHomepage = new System.Windows.Forms.WebBrowser();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brsHomepage
            // 
            this.brsHomepage.Location = new System.Drawing.Point(12, 76);
            this.brsHomepage.MinimumSize = new System.Drawing.Size(20, 20);
            this.brsHomepage.Name = "brsHomepage";
            this.brsHomepage.ScriptErrorsSuppressed = true;
            this.brsHomepage.Size = new System.Drawing.Size(1495, 751);
            this.brsHomepage.TabIndex = 0;
            this.brsHomepage.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            this.brsHomepage.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.brsHomepage_DocumentCompleted);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(13, 21);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(647, 26);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(683, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(165, 50);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 854);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.brsHomepage);
            this.Name = "frmBrowser";
            this.Text = "MyBrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser brsHomepage;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSearch;
    }
}

