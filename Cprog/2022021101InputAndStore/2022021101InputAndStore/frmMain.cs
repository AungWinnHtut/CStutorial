using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022021101InputAndStore
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGreeting_Click(object sender, EventArgs e)
        {
            //1- string sUname = "Mg Mg";
            string sUname ;
            string sUage="22";
            int iUage = 22;
            //sUname = "Mg Mg";
            sUname = txtUname.Text;
            sUage = txtUage.Text;
            iUage = int.Parse(sUage);
            iUage = iUage + 5;
            MessageBox.Show(iUage.ToString());

        }
    }
}
