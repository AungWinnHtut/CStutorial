using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeaserCipher
{
    public partial class frmCipher : Form
    {

        char[] plain =   {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        char[] cipher = {'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' , 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'};
        int found = 27;

        public frmCipher()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string sInput = txtOriginal.Text;
            char cOrig = sInput .ElementAt(0);
            for(int i=0;i<26;i++)
            {
                if(cOrig ==plain[i])
                {
                    found = i;
                    break;
                }
            }
            txtCipher .Text = cipher [found].ToString();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string sInput = txtCipher.Text;
            char cOrig = sInput.ElementAt(0);
            for (int i = 0; i < 26; i++)
            {
                if (cOrig == cipher[i])
                {
                    found = i;
                    break;
                }
            }
            txtPlain .Text = plain[found].ToString();
        }
    }
    
}
