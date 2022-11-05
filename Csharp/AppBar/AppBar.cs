using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AppBar
{
    public partial class AppBar : Form
    {
        public AppBar()
        {
            InitializeComponent();
        }

        private void picNotePad_Click(object sender, EventArgs e)
        {
           Process.Start("notepad");    
        }

        private void picPaint_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint");
        }

        private void picCommand_Click(object sender, EventArgs e)
        {
            Process.Start("cmd");
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MAXIMIZE = 0xF030;
            const int SC_RESTORE = 0xF120;

            if (m.Msg == WM_SYSCOMMAND)
            {
                switch ((int)m.WParam)
                {
                    case SC_RESTORE:
                        // your window was restored ( double clicked on the command bar )
                        // set it's window state back to maximize or do whatever
                        MessageBox.Show("Restore");
                        break;

                    case SC_MAXIMIZE:
                        // your window was maximized .. no actions needed, just for debugging purpose
                        MessageBox.Show("Maximize");
                        break;
                }
            }
            base.WndProc(ref m);
        }

        private void AppBar_Load(object sender, EventArgs e)
        {
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }
    }
}
