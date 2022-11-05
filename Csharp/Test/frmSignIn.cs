using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string sUname = txtUsername.Text;
            string sPassword = txtPassword.Text;
            if( (sPassword == "1234") && (sUname =="aung") )
            {
                MessageBox.Show("Password correct!", "Log In");
                frmPhotoAlbum frmPA = new frmPhotoAlbum();
                frmPA.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password incorrect!", "Log In");
            }
        }
    }
}
