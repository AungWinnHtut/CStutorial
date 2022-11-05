using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class frmHello : Form
    {
        public frmHello() //constructor
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
             string sRadius = txtRadius.Text;
            float fRadius = float.Parse(txtRadius.Text);
            float fArea = 3.1415f * multiply(fRadius, fRadius);
            txtArea.Text = fArea .ToString ();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            picMyPhoto.Visible = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            picMyPhoto .Visible = true;
        }

        public float multiply(float x , float y)
        {
            return x + y;
        }



    }
}
