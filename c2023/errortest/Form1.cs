using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace errortest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(pic1.Visible ==true)
            {
                pic1.Visible = false;
            }
            if (pic1.Visible == false)
            {
                pic1.Visible = true;
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            pic1.Visible=false;
        }
    }
}
