using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTools2
{
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
        }

        private void btnAddFriend_Click(object sender, EventArgs e)
        {
            funAddRriend();
        }

        public void funAddRriend()
        {
            string sFriendName = txtFriendName.Text;
            lbFriendList.Items.Add(sFriendName);
            txtFriendName .SelectAll ();
            txtFriendName .Focus ();
        }

        private void txtFriendName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                funAddRriend();
            }
        }
    }
}
