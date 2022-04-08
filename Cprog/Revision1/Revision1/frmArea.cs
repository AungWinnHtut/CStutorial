using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revision1
{
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            funCalArea();
            txtR.SelectAll();
            txtR.Focus();
        }

        private void txtR_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                funCalArea();
               
            }

        }

        public void funCalArea()
        {

            float fArea = 0.0f;
            float fRadius = 0.0f;

            // varname = value;
            // varname
            //fRadius = float.Parse(txtR.Text);

            // bool bStatus = float.TryParse (txtR .Text, out fRadius);
            // if(bStatus)

            if (float.TryParse(txtR.Text, out fRadius))
            {
                // data valid
                fArea = 3.14f * fRadius * fRadius;
                txtA.Text = fArea.ToString();             
            }
            else
            {
                MessageBox.Show("Invalid format, Pls enter floating value");                
                //data invalid
                //show error and ask to try again
            }

            txtR.SelectAll();
            txtR.Focus();

            // 1. User ထည့်ပေးလိုက်တဲ့ တန်ဖိုးကို စစ်မယ်
            // float ဖြစ်လား မဖြစ်လား စစ်ဖို့လိုမယ်
            // float.tryparse()
            // Validation

            // Store လုပ်ဖို့ = assignment operator

            // Hand Calculation
            // Equation 
            // fA = 3.14f * fR * fR;


            // Outpur Results into UI
            // Store Results
        }
    }
}
