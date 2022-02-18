using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeaserCipher
{
    public partial class frmMyanCrypt : Form
    {
        public frmMyanCrypt()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ceaserCipherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCipher frmcipher , frmcipher2 ;
            frmcipher = new frmCipher("Green Hackers");
            frmcipher2 = new frmCipher();
            frmcipher2.Show();
        }
    }
}
