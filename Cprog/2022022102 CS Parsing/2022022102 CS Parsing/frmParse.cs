using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022022102_CS_Parsing
{
    public partial class frmParse : Form
    {
        public frmParse()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float fRadius = 0F;
            float fArea = 0F;

             bool result = float.TryParse (txtRadius .Text,out fRadius);
            if( result == true )
            {
                 fArea =  3.14F * fRadius * fRadius;
                 txtArea.Text = fArea.ToString();
            }
            else
            {
                MessageBox.Show("Incorrect Format, Pls Try again!");
                txtRadius.SelectAll();
            }
           btnCalculate .Enabled = false;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnCalculate.Enabled = true;
            timer1.Enabled = false;
        }
    }
}
