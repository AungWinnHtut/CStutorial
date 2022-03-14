using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace _2022030201_CS_Array_Tutorial
{
    public partial class frmUItest : Form
    {
        public frmUItest()
        {
            InitializeComponent();
        }

        private void frmUItest_Load(object sender, EventArgs e)
        {
            lblLeft.Text = "km";
            lblRight.Text = "miles";


            cboCities.Text = "km to miles";         
            
            //combo box ထဲကို item အသစ်တစ်ခု ထည့်တာ
            cboCities.Items.Add("km to miles"); //index = 0
            cboCities.Items.Add("cm to inches"); //index = 1
            cboCities.Items.Add("meter to miles"); //index = 2
            cboCities.Items.Add("yard to meter"); //index = 2

            cboCities.SelectedIndex = 0; //km to miles

        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            string sCity = txtCity .Text;
            cboCities .Items.Add(sCity);
        }

        private void cboCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCities.SelectedIndex == 0)
            {
                lblLeft.Text = "km";
                lblRight.Text = "miles";                
            }
            else if(cboCities.SelectedIndex == 1)
            {
                lblLeft.Text = "cm";
                lblRight.Text = "inches";              
            }
            else if (cboCities.SelectedIndex == 2)
            {
                lblLeft.Text = "meter";
                lblRight.Text = "miles";
            }
            else if (cboCities.SelectedIndex == 3)
            {
                lblLeft.Text = "yard";
                lblRight.Text = "meter";
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            float fConst = 0.0f ; //f for float variable
            float fLeft = float.Parse(txtLeft.Text);
            if (cboCities.SelectedIndex == 0)
            {
                fConst = 0.621371f;
            }
            else if (cboCities.SelectedIndex == 1)
            {
                fConst = 0.393701f;
            }
            else if (cboCities.SelectedIndex == 2)
            {
                fConst = 0.000621371f;
            }
            else if (cboCities.SelectedIndex == 3)
            {
                fConst = 0.9144f;
            }
            float fAns = fConst * fLeft;
            txtRight.Text = fAns.ToString();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application .Exit ();
        }

        private void btnMedicalTest_Click(object sender, EventArgs e)
        {
            int iScore = 100;
            if(chkDrink .Checked)
            {
                // iScore = iScore - 20;
                iScore -= 20;
            }
            if (chkSmoking.Checked)
            {
                // iScore = iScore - 20;
                iScore -= 20;
            }
            if(rdoFemale .Checked )
            {
                MessageBox.Show("Female");
            }
           else if (rdoMale .Checked)
            {
                MessageBox.Show("Male");
            }
           else if (rdoUndefine .Checked)
            {
                MessageBox.Show("Undefine");
            }
            txtMedicalResult .Text = iScore.ToString();

        }

        private void btnLoadFileList_Click(object sender, EventArgs e)
        {
            string[] saFileList = Directory.GetFiles("D:\\CStutorial\\Python");
            foreach(string sFile in saFileList)
            {
                lstFile .Items .Add (sFile);
            }
            
        }

        private void cmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad");
        }

        private void mspaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint");
        }

        private void digitalLogicSimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\aungw\Downloads\Compressed\Digital Logic Sim (windows)\Digital Logic Sim (windows)\Digital Logic Sim\Digital Logic Sim.exe");
        }
    }
}
