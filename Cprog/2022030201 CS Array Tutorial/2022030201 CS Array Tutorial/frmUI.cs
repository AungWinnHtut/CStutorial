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
using System.IO;


namespace _2022030201_CS_Array_Tutorial
{
    public partial class frmUI : Form
    {
        public frmUI()
        {
            InitializeComponent();
        }

        private void picDigital_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\aungw\Downloads\Compressed\Digital Logic Sim (windows)\Digital Logic Sim (windows)\Digital Logic Sim\Digital Logic Sim.exe");
        }

        private void picPaint_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint");
        }

        private void picNote_Click(object sender, EventArgs e)
        {
            //Process.Start("notepad", @"D:\CStutorial\Python\robot.py");
            Process.Start("notepad", lstFileList .SelectedItem .ToString ());
        }

        private void picCommand_Click(object sender, EventArgs e)
        {
            Process.Start("cmd");
        }

        private void frmUI_Load(object sender, EventArgs e)
        {
            string[] saFileList = Directory.GetFiles(txtPath.Text);
            foreach (string sFile in saFileList)
            {
                lstFileList .Items.Add (sFile);
            }
            lstFileList.SelectedIndex = 0;
        }
    }
}
