using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;  // ဖိုင် ဖတ်တာ ရေးတာ သုံးဖို့

namespace _202202101_CS_FileReading
{
    public partial class frmFileReader : Form
    {
        public frmFileReader()
        {
            InitializeComponent();
        }

        private void frmFileReader_Load(object sender, EventArgs e)
        {
            this.Text = "File Reader";
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string sFname = txtFname.Text;

          if(File.Exists(sFname ))
            {
                //StreamReader obj ဖန်တီးတာ ဖိုင်နေရာနဲ့ နာမည် တစ်ခါတည်းပေးရမယ်
                StreamReader sr = new StreamReader(sFname);
                //ဖိုင်တစ်ဖိုင်လုံးကို ဖတ်တာ
                txtFileReader.Text = sr.ReadToEnd();
                sr.Close();
            }
            else
            {
                MessageBox.Show("Wrong Path and Filename, Please enter correctly!");
            }

           

        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            // string variable တည်ဆောက်ပြီး txtFileReader ထဲက Text Property ကို သိမ်းလိုက်တယ်
            string sData =  txtFileReader.Text;
            string sFileName = txtFname .Text;

            // sFileName ထဲက ဖိုင် အပြင်မှာ တကယ်ရှိမရှိ စစ်တာ။ ရှိရင် true ပြန်ပေးမယ်
            // if ထဲက ကုဒ်တွေ အလုပ်လုပ်မယ်
            if(File.Exists(sFileName )) 
            {
                // User ကို သေချာအောင် မေးတာ။ အဖြေကို DialogResult variable ဖန်တီးပြီး သိမ်း
                DialogResult drAns= MessageBox.Show("Are you sure you want to override file!","Warning",MessageBoxButtons.YesNo);
                if (drAns == DialogResult.Yes) // User confirm override file
                {
                    StreamWriter sw = new StreamWriter(sFileName);
                    sw.WriteLine(sData);
                    sw.Close();
                    MessageBox.Show("File Written");
                }
                else // User deny override file
                {
                    MessageBox.Show("File do not Written");
                }
            }
            else // if file does not exist, create new file and write data
            {
                StreamWriter sw = new StreamWriter(sFileName);
                sw.WriteLine(sData);
                sw.Close();
                MessageBox.Show("File Written");
            }


            
           

           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFileReader.Clear();
        }
    }
}
