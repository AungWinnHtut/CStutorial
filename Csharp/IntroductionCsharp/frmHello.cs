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
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            picNature.Visible = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            picNature.Visible = true;
        }

        private void frmHello_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
