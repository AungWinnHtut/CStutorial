using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022021001BasicTools
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void picBaydin_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); //random object
            int ans = rnd.Next(1, 4);
            txtAns.Text = ans.ToString();

            if(ans==1)
            {
                picBaydin.Image = Image.FromFile("D:\\CStutorial\\baydin\\1.jpg");
                txtBaydin.Text = "ဒီ​နေ့ ကံကောင်းနေတယ်";
            }
            else if(ans==2)
            {
                picBaydin.Image = Image.FromFile("D:\\CStutorial\\baydin\\2.jpg");
                txtBaydin.Text = "ဒီ​နေ့ ကံမကောင်းပါ";
            }
            else
            {
                picBaydin.Image = Image.FromFile("D:\\CStutorial\\baydin\\3.jpg");
                txtBaydin.Text = "ဒီ​နေ့ ထူးခြားမှု မရှိပါ";
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
