using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTools2
{
    public partial class frmNewTools2 : Form
    {
        public frmNewTools2()
        {
            InitializeComponent();
        }

        private void btnShowDate_Click(object sender, EventArgs e)
        {
            DateTime dtBirthday = dtpDate.Value;
            MessageBox.Show("Your Birthday is " + dtBirthday.Day.ToString() + "\\" + dtBirthday.Month.ToString() + "\\" + dtBirthday.Year.ToString());
            int iLuck = dtBirthday.Day + dtBirthday.Month + dtBirthday.Year;
            iLuck = iLuck % 7;
            string sLuck = "unknown";
            switch(iLuck )
            {
                case 0: sLuck = "ok";break;
                case 1: sLuck = "not ok";break;
                case 2: sLuck = "happy";break;
                case 3: sLuck = "hungry"; break;
                case 4: sLuck = "angry"; break;
                case 5: sLuck = "slippy"; break;
                case 6: sLuck = "sleepy"; break;              
            }
            txtLuck.Text = sLuck;
            

        }
    }
}
