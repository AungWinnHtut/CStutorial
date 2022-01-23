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

namespace CeaserCipher
{
    public partial class frmFileEncrypter : Form
    {
        public frmFileEncrypter()
        {
            InitializeComponent();
        }

        private void btnOrgBrowse_Click(object sender, EventArgs e)
        {
           OpenFileDialog ofd = new OpenFileDialog ();
            ofd.Filter = "*.txt|*.txt";
            string sFname = "";
            string sData="";

           if( ofd .ShowDialog() == DialogResult.OK )
            {
                sFname  = ofd .FileName;
                txtOrgFname.Text = sFname;
                StreamReader sr = new StreamReader(sFname);
               sData = sr.ReadToEnd();
                txtOrgText .Text = sData;
                sr.Close();

            }
        }
    }
}
