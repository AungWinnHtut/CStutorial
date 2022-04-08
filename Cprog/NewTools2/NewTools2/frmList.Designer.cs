namespace NewTools2
{
    partial class frmList
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
            this.lbFriendList = new System.Windows.Forms.ListBox();
            this.txtFriendName = new System.Windows.Forms.TextBox();
            this.btnAddFriend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFriendList
            // 
            this.lbFriendList.FormattingEnabled = true;
            this.lbFriendList.ItemHeight = 20;
            this.lbFriendList.Location = new System.Drawing.Point(62, 45);
            this.lbFriendList.Name = "lbFriendList";
            this.lbFriendList.Size = new System.Drawing.Size(250, 344);
            this.lbFriendList.TabIndex = 0;
            // 
            // txtFriendName
            // 
            this.txtFriendName.Location = new System.Drawing.Point(399, 54);
            this.txtFriendName.Name = "txtFriendName";
            this.txtFriendName.Size = new System.Drawing.Size(171, 26);
            this.txtFriendName.TabIndex = 1;
            this.txtFriendName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFriendName_KeyDown);
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.Location = new System.Drawing.Point(399, 104);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.Size = new System.Drawing.Size(172, 40);
            this.btnAddFriend.TabIndex = 2;
            this.btnAddFriend.Text = "Add Friend";
            this.btnAddFriend.UseVisualStyleBackColor = true;
            this.btnAddFriend.Click += new System.EventHandler(this.btnAddFriend_Click);
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddFriend);
            this.Controls.Add(this.txtFriendName);
            this.Controls.Add(this.lbFriendList);
            this.Name = "frmList";
            this.Text = "frmList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFriendList;
        private System.Windows.Forms.TextBox txtFriendName;
        private System.Windows.Forms.Button btnAddFriend;
    }
}