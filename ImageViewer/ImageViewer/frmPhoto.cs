using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class frmPhoto : Form
    {
        string sPassword;
        char[] caPass = new char[10];
        int iCounter = 0;
        bool isEnter = false;

        public frmPhoto()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            picPhoto.Image = Image.FromFile("1.jpg");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            picPhoto.Image = Image.FromFile("2.jpg");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
           


            if(isEnter)
            {
                string sFinalPass =new string(caPass);
                sFinalPass = sFinalPass.Substring(0, iCounter );
                if (sFinalPass  == "1234")
                {
                    picPhoto.Image = Image.FromFile("3.png");
                }
            }
            else
            {
                picPhoto.Image = Image.FromFile("1.jpg");
            }
            
        }

     

       

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                isEnter = true;
                btn3_Click(sender,e);
            }
            else
            {
                string sBuffer;
                char cTemp;
                string sStar = "";
                iCounter = iCounter + 1; // iCounter++;
                sBuffer = txtPassword.Text;
                cTemp = sBuffer.ElementAt(iCounter - 1);
                caPass[iCounter - 1] = cTemp;
                for (int i = 0; i < iCounter; i++)
                {
                    sStar = sStar + "*";// sStar += "*";
                }
                txtPassword.Text = sStar;
                txtPassword.Select(iCounter, 0);
            }

        }

        private void frmPhoto_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtPassword;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
