using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoAlbum
{
    public partial class frmPhotoAlbum : Form
    {
        public frmPhotoAlbum()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application .Exit ();
        }

        private void btnHideOne_Click(object sender, EventArgs e)
        {
            picOne.Visible = false;
        }

        private void btnHideTwo_Click(object sender, EventArgs e)
        {
            picTwo.Visible = false;
        }

        private void btnShowOne_Click(object sender, EventArgs e)
        {
            picOne .Visible = true;
        }

        private void btnShowTwo_Click(object sender, EventArgs e)
        {
            picTwo .Visible = true;
        }
    }
}
