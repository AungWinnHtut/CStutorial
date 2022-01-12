using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            float fArea = 0.0F;
            float fRadius = 0.0F;

            if (txtRadius .Text != "")
            {
              
                float.TryParse(txtRadius .Text ,out fRadius);
                if (fRadius > 0)
                {
                    fArea = 3.14F * fRadius * fRadius;
                    txtArea.Text = fArea.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter Radius with correct float format!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Radius", "Error!", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }

          

        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
          
        }

       
    }
}
