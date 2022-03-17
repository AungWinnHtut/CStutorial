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

namespace PlayerTest
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
            if(Directory.Exists(sPath))
            {
                string[] saFileList = Directory.GetFiles(sPath);
                string[] saSplitPath;
                foreach (string sFile in saFileList)
                {
                    saSplitPath = sFile.Split('\\');
                    int iLength = saSplitPath.Length;
                    lstFileList.Items.Add(saSplitPath [iLength -1]);
                }
            }
            else
            {
                MessageBox.Show("Invalid Path");
                txtPath .SelectAll ();
                txtPath .Focus ();
            }
          
        }

        private void lstFileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sVlcPath = @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe";
            string sExcelPath = @"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE";
            string sWordPath = @"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE";
            if(lstFileList.SelectedItem != null )
            {
                string sSelectedVideo = lstFileList.SelectedItem.ToString();
                string sVideoFile = sPath + "\\" + sSelectedVideo;
                string sVideoFileVlc = "\"" + sPath + "\\" + sSelectedVideo + "\"";
                //wmpPlayer .URL = sVideoFile;
                string[] sExt = sSelectedVideo.Split('.');
                if (sExt[1] == "mp4")
                {
                    Process.Start(sVlcPath, sVideoFileVlc);
                }
                else if ((sExt[1] == "jpg") || (sExt[1] == "png"))
                {
                    Process.Start("mspaint", sVideoFileVlc);
                }
                else if ((sExt[1] == "txt") || (sExt[1] == "py"))
                {
                    Process.Start("notepad", sVideoFileVlc);
                }
                else if (sExt[1] == "xlsx")
                {
                    Process.Start(sExcelPath, sVideoFileVlc);
                }
                else if (sExt[1] == "docx")
                {
                    Process.Start(sWordPath, sVideoFileVlc);
                }
                else if (sExt[1] == "exe")
                {
                    Process.Start(sVideoFileVlc);
                }
            }
            

        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            ofdSelectFile.ShowDialog();
            lstFileList .Items.Add (ofdSelectFile.FileName);
        }
    }
}
