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
    public partial class frmDice : Form
    {
        public frmDice()
        {
            InitializeComponent();
        }

        private void btnDice_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random(); //Random obj ဖန်တီးတာ
            //int iDice = rnd.Next(1, 4); //၁ နဲ့ ၂ ကြား random integer တစ်လုံး ဖန်တီးတာ
            //txtDice.Text = iDice.ToString(); //ရလာတဲ့ random int ကို string ပြောင်းပြီး txtDice ရဲ့ Text properties ထဲ ထည့်တာ

            Random rnd = new Random();
            int iRandomNumber = rnd.Next(1,7);
            txtDice.Text = iRandomNumber.ToString();
        }

        private void frmDice_Load(object sender, EventArgs e)
        {
            txtDice.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
