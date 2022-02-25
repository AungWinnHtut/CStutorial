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

    }
}
