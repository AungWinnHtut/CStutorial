using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022022401_CS_Login_Exam_2
{
    public partial class frmMaths : Form
    {

        // external variables တွေ ကြေငြာမယ်။ ဘယ်နေရာကမဆို ခေါ်သုံးချင်လို့
        int iTimes = 0;
        int iCount = 0;
        int iResult = 0;
        int iTotal = 0;

        public frmMaths()
        {
            InitializeComponent();
        }

        private void frmMaths_Load(object sender, EventArgs e)
        {
            txtTimes .Enabled = false;
            txtCount .Enabled = false;
            txtTotal  .Enabled = false;

            randomTest();

            txtTotal .Text  = iTotal .ToString ();


        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int iAns = int.Parse(txtResult.Text); //tryParse
            if (iAns == iResult)
            {
                MessageBox.Show("Correct!");
                iTotal = iTotal + 10;
                txtTotal.Text = iTotal.ToString ();

                randomTest();
            }
            else
            {
                MessageBox.Show("Wrong Answer!");
            }
        }

        private void randomTest()
        {
            Random rnd = new Random();
            iTimes = rnd.Next(1, 17);
            iCount = rnd.Next(1, 13);
            iResult = iTimes * iCount;

            txtTimes.Text = iTimes.ToString();
            txtCount.Text = iCount.ToString();
            txtResult.Clear();
        }

        private void btnToMiles_Click(object sender, EventArgs e)
        {
            //float fKm = float.Parse(txtKm1 .Text );
            bool bInput = float.TryParse(txtKm1.Text, out float fKm);
            if (bInput)
            {
                float fMiles = fKm * 0.62f;
                txtMiles1 .Text = fMiles .ToString ();
            }
            else
            {
                MessageBox.Show("Error! Please Enter Correct Values for Km!");
                txtKm1.Focus();
                txtKm1 .SelectAll ();
            }
          
        }

        private void btnToKm_Click(object sender, EventArgs e)
        {
            //float fKm = float.Parse(txtKm1 .Text );
            bool bInput = float.TryParse(txtMiles2.Text, out float fMiles2);
            if (bInput)
            {
                float fKm2 = fMiles2  * 1.6f;
                txtKm2.Text = fKm2 .ToString();
            }
            else
            {
                MessageBox.Show("Error! Please Enter Correct Values for Miles!");
                txtMiles2.Focus();
                txtMiles2.SelectAll();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculateGP_Click(object sender, EventArgs e)
        {
            float fGPPK = 0.0f;
            float fKyat = 0.0f;
            float fPae = 0.0f;
            float fYway = 0.0f;

            bool bGPPK = float.TryParse (txtGppk .Text , out fGPPK);
            bool bKyat = float.TryParse (txtKyat .Text , out fKyat);
            bool bPae = float.TryParse (txtPae .Text , out fPae);
            bool bYway = float.TryParse (txtYway .Text , out fYway);

            // if( (bGPPK == true) && (bKyat == true) && (bPae == true) && (bYway == true) )
            if (bGPPK && bKyat && bPae && bYway )
            {
                float fTotalGW = fKyat +(fPae / 16) + (fYway / 128);
                float fTotalGP = fTotalGW * fGPPK;
                txtGoldPrice.Text = fTotalGP.ToString();
            }
            else
            {
                MessageBox.Show("Wrong Inputs, Pls Try Again");
                txtGppk.Clear();
                txtKyat .Clear ();
                txtPae .Clear ();
                txtYway .Clear ();
                txtGppk.Focus();
            }

        }
    }
}
