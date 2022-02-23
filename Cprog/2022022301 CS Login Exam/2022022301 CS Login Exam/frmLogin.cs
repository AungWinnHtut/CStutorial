using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022022301_CS_Login_Exam
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // form ပေါ်က စာသားကို ရေးတာ
            // form ကို this နဲ့ ရည်ညွှန်းရမယ်။ နာမည်ခေါ်စရာ မလိုဘူး
            this.Text = "Login to Exam System";
            this.ControlBox = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sUname;
            string sPassword;

            sUname = txtUname.Text;
            sPassword = txtPass.Text;

            //if (string.IsNullOrEmpty(sUname) || string.IsNullOrEmpty(sPassword))
            if( sUname == ""  || sPassword == "")
            {
                MessageBox.Show("Please enter username and password");
            }
            else
            {
                if (sUname == "aung" && sPassword == "1234")
                {
                    // Exam Form ကို ဖွင့်မှာ
                    frmExam frmexam = new frmExam();
                    this.Close ();
                    frmexam.Show();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
