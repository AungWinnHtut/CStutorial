using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022020702HelloWorldRevision
{
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            //which obj, which prop 
            //picAlbum.Visible = false;
            picAlbum.Visible = false;
        }

        private void btnShowPhoto_Click(object sender, EventArgs e)
        {
            picAlbum.Visible = true;
        }
    }
}
