using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Function_Test
{
    public partial class frmFunctionTest : Form
    {
        public frmFunctionTest()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float fR = float.Parse(txtX.Text);
            float fA = funCircleArea (fR);
            float fA2 = funRectArea(3.22f, 54.2f);


        }

        public int funY(int iX)
        {
            int iY = 2 * iX;
            return iY;
        }
        public int funYY(int iX)
        {
            int iY = 3 * iX;
            return iY;
        }

        public int funYYY(int iX)
        {
            int iY = 4 * iX;
            return iY;
        }

        public float funCircleArea(float fRadius)
        {
            float fArea = 3.1415f *  fRadius * fRadius;
            return fArea;
        }

        public float funRectArea(float fWidth, float fLength)
        {
            float fArea = fWidth * fLength;
            return fArea;
        }

        public void funHello()
        {
            this.Text = "Hello";
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            funHello ();
        }
    }
}
