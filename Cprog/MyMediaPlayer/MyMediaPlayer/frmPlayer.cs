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

namespace MyMediaPlayer
{
    public partial class frmPlayer : Form
    {
        string sPath;
        public frmPlayer()
        {
            InitializeComponent();
        }

        private void btnLoadFileList_Click(object sender, EventArgs e)
        {
            sPath = txtPath .Text;
            string[] saSplited;
            int iSize = 0;
            if (Directory .Exists(sPath))
            {
                string[] saFileList = Directory.GetFiles(sPath);
                foreach (string sFile in saFileList)
                {
                    //D: \ ! Computer Science  igcse \ 2-Microbit Lessons \ 1-Lesson.mp4
                    //4 - 0 1 2 3
                    saSplited = sFile .Split ('\\');
                    iSize = saSplited .Length;
                    lstFileList.Items.Add(saSplited [iSize -1]);
                }
            }
            else
            {
                MessageBox.Show("Error!, Invalid path, try again!");
                txtPath .SelectAll();
                txtPath .Focus ();
            }
           
        }

        private void lstFileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pathVLC = @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe";
            //wmpPlayer .URL = sPath + "\\" + lstFileList .SelectedItem .ToString ();
            // Process.Start(@"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe", @"D:\Kid Lesson 1 - Hello World.mp4");
            //Process VLC = new Process();
            //VLC.StartInfo.FileName = pathVLC;
            //VLC.StartInfo.Arguments =  "\"" + sPath + "\\" + lstFileList.SelectedItem.ToString() + "\"";
            //VLC.Start();

            Process.Start(@"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe", "\"" + sPath + "\\" + lstFileList.SelectedItem.ToString() + "\"");
        }
    }
}
