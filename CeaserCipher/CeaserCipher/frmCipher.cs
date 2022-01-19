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

        char[] plain =   {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z','*'};
        char[] cipher = {'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' , 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j','*'};
        int found = 26;

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
            if(txtOriginal .Text !="")
            {
                txtCipher.Text = funStringEncrypt(txtOriginal.Text);
            }
            else
            {
                MessageBox.Show("Please Enter Text to Encrypt", "No Data!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (txtOriginal.Text != "")
            {
                txtPlain.Text = funStringDecrypt(txtCipher.Text);
            }
            else
            {
                MessageBox.Show("Please Enter Text to Decrypt", "No Data!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPlain .Text = Multiply(10).ToString ();  
        }
        public static int Multiply(int number)
        {
            int digit = 1;
            int ans = 1;
            int num = number;
            if (number < 10)
            {
                //do nothing
            }
            else
            {
                while (num >= 10)
                {
                    num = num / 10;
                    digit++;
                }
            }
            for (int i = 0; i < digit; i++)
            {
                ans *= 5;
            }
            return ans * number;
        }

        //output-datatype   fun-name(datatpye1 data1, .....){  return outputdata;}
        public char funCharEncrypt(char cPlain)
        {
            found = 26; //important to reset to *
            char cEncrypted = '\0';
            for (int i = 0; i < 26; i++)
            {
                if (cPlain == plain[i])
                {
                    found = i;
                    break;
                }
            }
           cEncrypted = cipher[found];
            return cEncrypted;
        }

        char funCharDecrypt(char cEncrypted)
        {
            found = 26; //important to reset to *
            char cPlain = '\0';
            for (int i = 0; i < 26; i++)
            {
                if (cEncrypted == cipher[i])
                {
                    found = i;
                    break;
                }
            }
            cPlain = plain[found];
            return cPlain;
        }

        string funStringEncrypt(string sInput)
        {       
            char[] caOrig;
            char[] caEncrypted;
            caOrig = sInput.ToLower().ToCharArray();                
            caEncrypted = new char[caOrig.Length];

            for (int i = 0; i < caOrig.Length; i++)
            {
                caEncrypted[i] = funCharEncrypt(caOrig[i]);
            }
           return new string(caEncrypted);
        }

        string funStringDecrypt(string sInput)
        {
            char[] caEncrypted;
            char[] caDecrypted;
            caEncrypted = sInput.ToLower().ToCharArray();
            caDecrypted = new char[caEncrypted.Length];

            for (int i = 0; i < caEncrypted.Length; i++)
            {
                caDecrypted[i] = funCharDecrypt(caEncrypted[i]);
            }
            return new string(caDecrypted);
        }


    }
    
}
