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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            this.Text = "About Exam System";
            this.ControlBox = false;
            txtAbout.Text = "This software is licenced to Green Hackers @1995-2022. All right reserved.";  
            txtAbout .Enabled = false;
            txtAbout.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
