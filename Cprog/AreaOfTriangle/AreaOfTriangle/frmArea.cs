using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaOfTriangle
{
    public partial class frmAreaOfTriangle : Form
    {
        public frmAreaOfTriangle()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // read b and h
            // convert to float
            float fBase;
            float fHeight;
            float fArea;
            fBase = float.Parse(txtBase.Text);
            fHeight = float.Parse(txtHeight.Text);

            // Area calculation
            fArea = 0.5f * fBase * fHeight;
            // Output Area
            txtArea.Text = fArea.ToString();

        }
    }
}
