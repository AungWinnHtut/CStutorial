using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Function_Test2
{
    public partial class frmFunTest2 : Form
    {
        public frmFunTest2()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
           string sResult = funSayHello(txtUname .Text );
            this.Text = sResult;
        }

        public string funSayHello(string sName)
        {
           return ("Hello " + sName );
        }

        public float funSquare(float fN)
        {
            float fSquare = 0f;
            fSquare = fN * fN;
            return fSquare;
        }

        // A = 3.14 * R * R;
        public float funAreaCircle(float fR)
        {
            float fA = 3.14f * fR * fR;
            return fA;
        }

        // At = 0.5f * fB * fH;
        public float funAreaTriange(float fB, float fH)
        {
            float fAT = 0.5f * fB * fH;
            return fAT; 
        }

        // fCm = 100 * fMeter;
        public float funMeter2Cm(float fMeter)
        {
            float fCm = 100f * fMeter;
            return fCm;
        }
        public float funMiles2Yards(float fMiles)
        {
            float fYards = 1760f * fMiles ;
            return fYards;
        }

        public float funUnitConverter(float fUnit1, float K)
        {
            return K * fUnit1;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            float fN = float.Parse(txtN.Text);
            float fSquare = funSquare(fN);
            txtSquare.Text = fSquare.ToString();
        }

        private void btnCalAreaCircle_Click(object sender, EventArgs e)
        {
            float fR = float.Parse(txtRadius.Text);
            float fAC  = funAreaCircle(fR);
            txtAreaCircle .Text = fAC .ToString ();
        }

        private void btnCalAreaTriange_Click(object sender, EventArgs e)
        {
            float fB = float.Parse(txtB.Text);
            float fH = float.Parse(txtH.Text);
            float fAT = funAreaTriange (fB, fH);
            txtAT .Text = fAT .ToString ();

        }

        private void btnCalMeter2Cm_Click(object sender, EventArgs e)
        {
            float fM = float.Parse(txtMeter.Text);
            float fCm = funMeter2Cm (fM);
            txtCm.Text = fCm .ToString ();
        }

        private void btnCalMiles2Yards_Click(object sender, EventArgs e)
        {
            float fMiles =float.Parse (txtMiles.Text);
            float fYards = funMiles2Yards (fMiles);
            txtYards  .Text = fYards .ToString ();
        }

        private void btnUnit1ToUnit2_Click(object sender, EventArgs e)
        {
            float fUnit1 = float.Parse(txtUnit1.Text);
            float fK = float.Parse(txtK.Text);
            float fUnit2 = funUnitConverter (fUnit1 ,fK);
            txtUnit2.Text = fUnit2 .ToString ();
        }
    }
}
