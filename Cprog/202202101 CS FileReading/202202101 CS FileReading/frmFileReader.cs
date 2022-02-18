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
            //StreamReader obj ဖန်တီးတာ ဖိုင်နေရာနဲ့ နာမည် တစ်ခါတည်းပေးရမယ်
            StreamReader sr = new StreamReader("D:\\CStutorial\\baydin\\3.txt");
            //ဖိုင်တစ်ဖိုင်လုံးကို ဖတ်တာ
            txtFileReader.Text =  sr.ReadToEnd();
        }
    }
}
