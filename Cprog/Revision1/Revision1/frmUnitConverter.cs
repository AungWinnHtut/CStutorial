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
    public partial class frmUnitConverter : Form
    {
        public frmUnitConverter()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            funConvertM2Km();
        }

        public void funConvertM2Km()
        {
            //DATA 
            //variable creation
            float fKm = 0.0f; 
            float fM = 0.0f;
            //read input and verify
           if( float.TryParse(txtM.Text ,out fM))
            {
                //calculate  km = m * 0.001;
                fKm = fM * 0.001f;
                //output km to UI
                txtKm .Text = fKm.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input");
                
            }
            txtM.SelectAll();
            txtM.Focus();
        }

        private void txtM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                funConvertM2Km();
            }
            
        }

        private void txtM_TextChanged(object sender, EventArgs e)
        {
            funConvertM2Km();
        }
    }
}
