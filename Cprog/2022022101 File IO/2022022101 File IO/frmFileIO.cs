using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022022101_File_IO
{
    public partial class frmFileIO : Form
    {
        public frmFileIO()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // int.Parse(int ပုံစံ စာသား) int format ပုံစံ စာသားကို integer ပြောင်းတာ
            int iTimes = int.Parse(txtTimes.Text);
            int iCount = int.Parse(txtCount.Text);
            int iAns = 0;
           //  ture of false = int.TryParse(int ပုံစံ စာသား, out အဖြေထည့်မယ့် int variable);
           bool result = int.TryParse(txtAns .Text , out iAns);
            
            if(result == true)
            {
                int iResult = iTimes * iCount;

                if (iResult == iAns)
                {
                    MessageBox.Show("Correct!");
                }
                else
                {
                    MessageBox.Show("Wrong Answer!");
                }
            }
            else
            {
                MessageBox.Show("Wrong Format! Pls Try Again");
            }

           

        }

        private void frmFileIO_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int iTimes = rnd.Next(0, 13);
            int iCount = rnd.Next(0,13);
            txtTimes.Text = iTimes .ToString();
            txtCount .Text = iCount .ToString();
            txtTimes.Enabled = false; 
            txtCount .Enabled = false;
        }
    }
}
