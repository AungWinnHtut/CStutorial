using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Revision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string sMsg = "Hyper Generation";
            int iAge = 45;
            float fRadius = 1.5f;
            float fArea = 0.0f;
            fArea = 3.14f * fRadius * fRadius;   
            MessageBox.Show ("Area is " + fArea .ToString () + " sq cm");
            if (fArea > 1000)
            {
                MessageBox.Show("Big Area");
            }
            else
            {
                MessageBox.Show("Small Area");
            }
         
        }
    }
}
