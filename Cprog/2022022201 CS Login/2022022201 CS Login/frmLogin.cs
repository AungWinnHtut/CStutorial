using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022022201_CS_Login
{
    public partial class frmLogin : Form
    {

        //external variable
        //global variable
        int errCount = 0;


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sUname = txtUname.Text;
            string sPass = txtPass.Text;

            // Username က aung ဖြစ်ရမယ်။ Password က 1234 ဖြစ်ရမယ်
            // နှစ်ခုလုံးမှန်မှ လုပ်မှာဖြစ်လို့ AND && သင်္ကေတကို သုံးရမယ်
            if (sUname == "aung" && sPass == "1234")
            {
                MessageBox.Show("You have successfully login to system!");
                txtSecret.Visible = true;
                txtSecret.Text = "This is Secret message!";
            }
            else
            {
                errCount = errCount + 1;
                if (errCount == 3)
                {
                    MessageBox.Show("Login Failed 3 times!, Sorry... Bye!");
                    timer1.Enabled = true;
                    this.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Login Failed!, Pls try again!");
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
