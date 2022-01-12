using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maths
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int A, B, C, D;
            A = int.Parse(txtA.Text);
            B = int.Parse(txtB.Text);

            C = A / B;
            D = A % B;

            txtC.Text = C.ToString();
            txtD.Text = D.ToString();

        }
    }
}
