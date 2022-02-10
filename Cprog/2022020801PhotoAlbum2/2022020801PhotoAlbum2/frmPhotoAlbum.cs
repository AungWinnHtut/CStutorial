using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022020801PhotoAlbum2
{
    public partial class frmPhotoAlbum : Form
    {
        public frmPhotoAlbum()
        {
            InitializeComponent();
        }

        private void btnHidePhoto_Click(object sender, EventArgs e)
        {
            picAlbum.Visible = false;
        }

        private void btnShowPhoto_Click(object sender, EventArgs e)
        {
            picAlbum.Visible=true;
        }

        private void hidePhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picAlbum.Visible = false;
        }

        private void showPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picAlbum.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
            picAlbum.Image = Image.FromFile("D:\\microbit.png");
        }

        private void btnChangePhoto2_Click(object sender, EventArgs e)
        {
            picAlbum.Image = Image.FromFile("D:\\kid.jpg");
        }

        private void cboFileName_SelectedIndexChanged(object sender, EventArgs e)
        {
           picAlbum .Image = Image.FromFile ( cboFileName.SelectedItem.ToString());
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Hello World");
            // MessageBox.Show("Hello World","Greeting from GH");
            MessageBox.Show("Hello World", "Greeting from GH",MessageBoxButtons.YesNo);
        }

        private void btnSayNameHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello "+ txtUname .Text );
        }
    }
}
