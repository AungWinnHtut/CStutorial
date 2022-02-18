namespace CeaserCipher
{
    partial class frmFileEncrypter
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrgFname = new System.Windows.Forms.TextBox();
            this.txtOrgText = new System.Windows.Forms.TextBox();
            this.btnOrgBrowse = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnCipBrowse = new System.Windows.Forms.Button();
            this.txtCipText = new System.Windows.Forms.TextBox();
            this.txtCipFname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.btnPlnBrowse = new System.Windows.Forms.Button();
            this.txtPlnText = new System.Windows.Forms.TextBox();
            this.txtPlnFname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ofdFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Org fname";
            // 
            // txtOrgFname
            // 
            this.txtOrgFname.Location = new System.Drawing.Point(23, 43);
            this.txtOrgFname.Name = "txtOrgFname";
            this.txtOrgFname.Size = new System.Drawing.Size(246, 26);
            this.txtOrgFname.TabIndex = 1;
            // 
            // txtOrgText
            // 
            this.txtOrgText.Location = new System.Drawing.Point(23, 75);
            this.txtOrgText.Multiline = true;
            this.txtOrgText.Name = "txtOrgText";
            this.txtOrgText.Size = new System.Drawing.Size(289, 243);
            this.txtOrgText.TabIndex = 2;
            // 
            // btnOrgBrowse
            // 
            this.btnOrgBrowse.Location = new System.Drawing.Point(275, 38);
            this.btnOrgBrowse.Name = "btnOrgBrowse";
            this.btnOrgBrowse.Size = new System.Drawing.Size(37, 36);
            this.btnOrgBrowse.TabIndex = 3;
            this.btnOrgBrowse.Text = "...";
            this.btnOrgBrowse.UseVisualStyleBackColor = true;
            this.btnOrgBrowse.Click += new System.EventHandler(this.btnOrgBrowse_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(23, 335);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(289, 34);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(360, 335);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(289, 34);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            // 
            // btnCipBrowse
            // 
            this.btnCipBrowse.Location = new System.Drawing.Point(612, 33);
            this.btnCipBrowse.Name = "btnCipBrowse";
            this.btnCipBrowse.Size = new System.Drawing.Size(37, 36);
            this.btnCipBrowse.TabIndex = 8;
            this.btnCipBrowse.Text = "...";
            this.btnCipBrowse.UseVisualStyleBackColor = true;
            // 
            // txtCipText
            // 
            this.txtCipText.Location = new System.Drawing.Point(360, 75);
            this.txtCipText.Multiline = true;
            this.txtCipText.Name = "txtCipText";
            this.txtCipText.Size = new System.Drawing.Size(289, 243);
            this.txtCipText.TabIndex = 7;
            // 
            // txtCipFname
            // 
            this.txtCipFname.Location = new System.Drawing.Point(360, 43);
            this.txtCipFname.Name = "txtCipFname";
            this.txtCipFname.Size = new System.Drawing.Size(246, 26);
            this.txtCipFname.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cip fname";
            // 
            // btnAllClear
            // 
            this.btnAllClear.Location = new System.Drawing.Point(694, 335);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(289, 34);
            this.btnAllClear.TabIndex = 14;
            this.btnAllClear.Text = "All Clear";
            this.btnAllClear.UseVisualStyleBackColor = true;
            // 
            // btnPlnBrowse
            // 
            this.btnPlnBrowse.Location = new System.Drawing.Point(946, 38);
            this.btnPlnBrowse.Name = "btnPlnBrowse";
            this.btnPlnBrowse.Size = new System.Drawing.Size(37, 36);
            this.btnPlnBrowse.TabIndex = 13;
            this.btnPlnBrowse.Text = "...";
            this.btnPlnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtPlnText
            // 
            this.txtPlnText.Location = new System.Drawing.Point(694, 75);
            this.txtPlnText.Multiline = true;
            this.txtPlnText.Name = "txtPlnText";
            this.txtPlnText.Size = new System.Drawing.Size(289, 243);
            this.txtPlnText.TabIndex = 12;
            // 
            // txtPlnFname
            // 
            this.txtPlnFname.Location = new System.Drawing.Point(694, 43);
            this.txtPlnFname.Name = "txtPlnFname";
            this.txtPlnFname.Size = new System.Drawing.Size(246, 26);
            this.txtPlnFname.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(796, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pln fname";
            // 
            // ofdFileDialog
            // 
            this.ofdFileDialog.FileName = "openFileDialog1";
            // 
            // frmFileEncrypter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 403);
            this.Controls.Add(this.btnAllClear);
            this.Controls.Add(this.btnPlnBrowse);
            this.Controls.Add(this.txtPlnText);
            this.Controls.Add(this.txtPlnFname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnCipBrowse);
            this.Controls.Add(this.txtCipText);
            this.Controls.Add(this.txtCipFname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnOrgBrowse);
            this.Controls.Add(this.txtOrgText);
            this.Controls.Add(this.txtOrgFname);
            this.Controls.Add(this.label1);
            this.Name = "frmFileEncrypter";
            this.Text = "File Encryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrgFname;
        private System.Windows.Forms.TextBox txtOrgText;
        private System.Windows.Forms.Button btnOrgBrowse;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnCipBrowse;
        private System.Windows.Forms.TextBox txtCipText;
        private System.Windows.Forms.TextBox txtCipFname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAllClear;
        private System.Windows.Forms.Button btnPlnBrowse;
        private System.Windows.Forms.TextBox txtPlnText;
        private System.Windows.Forms.TextBox txtPlnFname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog ofdFileDialog;
    }
}