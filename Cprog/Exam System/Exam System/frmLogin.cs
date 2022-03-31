using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string sUname = txtUname.Text;
            string sPass = txtPass.Text;
            // ==, !=, >, < ,>=,<=,!
            if( sUname == "admin" && sPass =="1234")
            {
                //load Qdesigner
                frmQdesign frmqdesign = new frmQdesign();
                frmqdesign.Show();
                this.Hide();
            }
            else if (sUname == "student" && sPass == "4567")
            {
                //load Exam system
                frmExam  frmexam = new frmExam();
                frmexam.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Pls Try Again!");
                txtUname.SelectAll();
                txtUname.Focus();
            }

        }
    }
}
