using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022030201_CS_Array_Tutorial
{
    public partial class frmUItest : Form
    {
        public frmUItest()
        {
            InitializeComponent();
        }

        private void frmUItest_Load(object sender, EventArgs e)
        {
            cboCities.Text = "km to miles";
            lblLeft.Text = "km";
            lblRight.Text = "miles";
            

            cboCities.Items.Add("km to miles");
            cboCities.Items.Add("cm to inches");

        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            string sCity = txtCity .Text;
            cboCities .Items.Add(sCity);
        }

        private void cboCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCities.SelectedIndex == 0)
            {
                lblLeft.Text = "km";
                lblRight.Text = "miles";
                
            }
            else if(cboCities.SelectedIndex == 1)
            {
                lblLeft.Text = "cm";
                lblRight.Text = "inches";
              
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            float fConst = 0.0f;
            float fLeft = float.Parse(txtLeft.Text);
            if (cboCities.SelectedIndex == 0)
            {
                fConst = 0.62f;
            }
            else if (cboCities.SelectedIndex == 1)
            {
                fConst = 0.39f;
            }
            float fAns = fConst * fLeft;
            txtRight.Text = fAns.ToString();

        }
    }
}
