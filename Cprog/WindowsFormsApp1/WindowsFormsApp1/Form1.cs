using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDice_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); //Random obj ဖန်တီးတာ
            int iDice = rnd.Next(1, 4); //၁ နဲ့ ၂ ကြား random integer တစ်လုံး ဖန်တီးတာ
            txtDice.Text = iDice.ToString(); //ရလာတဲ့ random int ကို string ပြောင်းပြီး txtDice ရဲ့ Text properties ထဲ ထည့်တာ
        }
    }
}
