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
        char[] caPass = new char[20];
        int iCounter = 0;
        bool isEnter = false;
        bool isControl = false;

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
           if(isControl )
            {
                MessageBox.Show("control+a");
                isControl= false;   
            }
            else if (e.KeyData == Keys.Enter) 
            {
                isEnter = true;
                btn3_Click(sender,e);
            }
            else if (e.KeyData == Keys.Back)
            {
                iCounter = iCounter - 1; //iCounter--;
                caPass[iCounter] = '\0';
               
            }
            else if (e.KeyData == Keys.Delete)
            {
                for(int j=0;j<iCounter;j++)
                {
                    caPass[j] = '\0';
                }
                iCounter = 0; //iCounter--;
                txtPassword.Text = "";
            }
            else
            {
                string sBuffer;
                char cTemp;
                string sStar = "";
            
                sBuffer = txtPassword.Text;
                cTemp = sBuffer.ElementAt(iCounter);
                caPass[iCounter] = cTemp;                                                           //aPass[iCounter] =sBuffer.ElementAt(iCounter);
                for (int i = 0; i <= iCounter; i++) //iCounter=0;
                {
                    sStar = sStar + "*";// sStar += "*";
                }
                iCounter = iCounter + 1; // iCounter++;
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

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Modifiers == Keys.Control)
            {
                isControl = true;                  
            }
        }
    }
}
