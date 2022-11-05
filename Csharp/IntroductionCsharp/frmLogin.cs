using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroductionCsharp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string sUname = txtUname.Text;
            string sPassword = txtPass .Text;
           // MessageBox.Show("Username is" + sUname);
           // MessageBox .Show ("Password is"+sPassword);
            if( (sUname  == "aung") && (sPassword == "1234") )
            {
                MessageBox.Show("Correct Password");
                // to do
                frmHello frmHello = new frmHello();
                frmHello.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }
        }
    }
}
