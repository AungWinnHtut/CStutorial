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

namespace Exam_System
{
    public partial class frmQdesign : Form
    {
        string sFname;
        public frmQdesign()
        {
            InitializeComponent();
        }

        private void frmQdesign_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtFname .Text == String.Empty || txtQ .Text == String.Empty|| txtA1 .Text ==String .Empty ||txtA2 .Text ==string.Empty ||txtA3.Text == string.Empty || txtA4.Text ==string.Empty || txtCA .Text ==string.Empty )
            {
                MessageBox.Show("Please Fill All data before adding ");
                return;
            }

            
            string sQ = txtQ.Text;
            string sA1 = txtA1.Text;
            string sA2 = txtA2.Text;
            string sA3 = txtA3.Text;
            string sA4 = txtA4.Text;
            string sCA = txtCA.Text;

            string sQuestion = "N#" + sQ + "#" + sA1 + "#" + sA2 + "#" + sA3 + "#" + sA4 + "#" + sCA;

            string sPath = Path.GetDirectoryName(sFname);
            if(!Directory.Exists(sPath))
            {
                MessageBox.Show("Invalid Directory!");
                txtFname .SelectAll ();
                txtFname.Focus();
            }
            else
            {
                if (!File.Exists(sFname))
                {
                    File.Create(sFname).Dispose();
                }

                using (StreamWriter sw = new StreamWriter(sFname, true))
                {
                    sw.WriteLine(sQuestion);
                }
                MessageBox.Show("Adding New Question into the file " + sFname);
                txtQ.Clear();
                txtA1.Clear();
                txtA2.Clear();
                txtA3.Clear();
                txtA4.Clear();
                txtCA.Clear();
                txtQ.Focus();

            }





        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if(sfdFname .ShowDialog() == DialogResult.OK)
            {
                sFname = sfdFname .FileName;
                txtFname.Text = sFname;
            }
        }
    }
}
