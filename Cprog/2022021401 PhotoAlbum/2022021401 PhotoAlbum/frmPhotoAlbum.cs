using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022021401_PhotoAlbum
{
    public partial class frmPhotoAlbum : Form
    {
        public frmPhotoAlbum()
        {
            InitializeComponent();
        }

        private void frmPhotoAlbum_Load(object sender, EventArgs e)
        {
            this.Text = "PhotoAlbum";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
