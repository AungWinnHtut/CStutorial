using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022022401_CS_Login_Exam_2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Login for Exam";
            this.ControlBox = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            this.Text = "To cancel and exit the app";
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            this.Text = "To login to the app";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sUname;
            string sPassword;

            sUname = txtUname.Text;
            sPassword = txtPassword.Text;

            if (sUname == "aung" && sPassword == "1234")
            {
                frmExam exam = new frmExam();
                this.Hide();
                exam.Show();
                
            }
            else
            {
                MessageBox.Show("Sorry Try again....");
            }
        }
    }
}
