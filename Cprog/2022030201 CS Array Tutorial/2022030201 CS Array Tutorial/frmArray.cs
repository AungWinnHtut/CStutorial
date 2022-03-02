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

namespace _2022030201_CS_Array_Tutorial
{
    public partial class frmArray : Form
    {
        public frmArray()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // File ကနေ တစ်ကြောင်းချင်းဖတ်ရန်
            string line = "";
            string[] saPQ = new string[6];
            StreamReader sr = new StreamReader("questions.txt");
            // တစ်လိုင်းချင်းဖတ်မှာ
            while ((line = sr.ReadLine()) != null)
            {
                // တစ်ကြောင်းချင်းကနေ အပိုင်း၆ပိုင်း ခွဲထုတ်ရန်               
                saPQ = line.Split('$');
                // အပိုင်း ၆ ပိုင်းကို 5 ပိုင်းကို UI ပေါ်တင်ရမယ်။ User အဖြေကို နောက်ဆုံး အပိုင်း အဖြေမှန်နဲ့ တိုက်ဆိုင်စစ်ဆေးမယ်
            }
            sr.Close();

           
            
            
        }
    }
}
