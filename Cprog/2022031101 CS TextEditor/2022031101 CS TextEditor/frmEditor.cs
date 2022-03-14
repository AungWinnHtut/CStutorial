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


namespace _2022031101_CS_TextEditor
{
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
           if( Directory.Exists(txtPath.Text))
            {
                lstFileList .Items.Clear();
                string[] saFileList = Directory.GetFiles(txtPath.Text);
                foreach (string sFile in saFileList)
                {
                    lstFileList.Items.Add(sFile);
                }
            }
            else
            {
                MessageBox.Show("Error!, Invalid path! Pls try again");
                txtPath.SelectAll();
                txtPath.Focus();

            }

            

        }

        private void lstFileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader (lstFileList .SelectedItem .ToString ());
            string sData = sr.ReadToEnd ();
            txtEditor .Text = sData;
            sr.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Are you sure you want to override file","Confirm",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string sData = txtEditor.Text;
                StreamWriter sw = new StreamWriter(lstFileList.SelectedItem.ToString());
                sw.Write(sData);
                sw.Close();
            }

           
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string sData = txtEditor.Text;
            StreamWriter sw = new StreamWriter("d:\\temp.py");
            sw.Write(sData);
            sw.Close();
            Process.Start("python","d:\\temp.py");
        }
    }
}
