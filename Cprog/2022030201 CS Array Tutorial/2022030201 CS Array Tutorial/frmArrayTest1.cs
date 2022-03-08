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
    public partial class frmArrayTest1 : Form
    {
        public frmArrayTest1()
        {
            InitializeComponent();
        }

        private void btnReadString_Click(object sender, EventArgs e)
        {
            string sInput;
            string[] saData = new string[100];
            sInput = txtSinput .Text;

            saData = sInput.Split('*');

            txt1.Text = saData[0];
            txt2.Text = saData[1];
            txt3.Text = saData[2];  


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1=txt1 .Text ;
            string s2=txt2.Text ;
            string s3=txt3.Text ;
            string sFinal = s1 +"*"+ s2 + "*" + s3;
            txtSinput .Text = sFinal ;
        }

        private void frmArrayTest1_Load(object sender, EventArgs e)
        {

        }
    }
}
