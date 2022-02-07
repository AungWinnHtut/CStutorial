using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022020701HelloWorld
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            //to hide phto
            //visible prop = false
            picMyFamilyPhoto.Visible = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            picMyFamilyPhoto.Visible = true;
        }

        private void showPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picMyFamilyPhoto.Visible = true;
        }

        private void hidePhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picMyFamilyPhoto.Visible = false;
        }
    }
}
