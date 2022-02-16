using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022021601_CS_3CardGame_Random
{
    public partial class frmThreeCard : Form
    {
        public frmThreeCard()
        {
            InitializeComponent();
        }

        private void frmThreeCard_Load(object sender, EventArgs e)
        {
            this.Text = "Three Card Game";
            pic1.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
            pic2.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
            pic3.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");

            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3.SizeMode = PictureBoxSizeMode.StretchImage;

            txtBaydin.Enabled = false;
            txtBaydin.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            //  1. Random number 1 - 3 generate
            Random rnd = new Random();
            int iCard = rnd.Next(1, 4);

            //  2. ကျလာတဲ့ တန်ဖိုးပေါ် မူတည်ပြီး သက်ဆိုင်ရာ ပုံပြမယ်
            //      ဥပမာ 1-King   2-Queen  3-Fool
            if(iCard == 1)
            {
                pic1.Image = Image.FromFile("D:\\CStutorial\\baydin\\king.png");
                txtBaydin.Text = "ဘုရင်ဖြစ်ကိန်းရှိသည်";
            }
            if (iCard == 2)
            {
                pic1.Image = Image.FromFile("D:\\CStutorial\\baydin\\queen.jpg");
                txtBaydin.Text = "မဆိုးပါဘူး";
            }
            if (iCard == 3)
            {
                pic1.Image = Image.FromFile("D:\\CStutorial\\baydin\\fool.jpg");
                txtBaydin.Text = "သင် ကံဆိုးနေသည်";
            }

            // 3. အခြားဖဲချပ်တွေကို (pic2 and 3) မှောက်ခိုင်းထားမယ်
            pic2.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
            pic3.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");


            // 4. Disable လုပ်မယ်
            pic1.Enabled = false;
            pic2.Enabled = false;
            pic3.Enabled = false;


        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //  1. Random number 1 - 3 generate
            Random rnd = new Random();
            int iCard = rnd.Next(1, 4);

            //  2. ကျလာတဲ့ တန်ဖိုးပေါ် မူတည်ပြီး သက်ဆိုင်ရာ ပုံပြမယ်
            //      ဥပမာ 1-King   2-Queen  3-Fool
            if (iCard == 1)
            {
                pic2.Image = Image.FromFile("D:\\CStutorial\\baydin\\king.png");
                txtBaydin.Text = "ဘုရင်ဖြစ်ကိန်းရှိသည်";
            }
            if (iCard == 2)
            {
                pic2.Image = Image.FromFile("D:\\CStutorial\\baydin\\queen.jpg");
                txtBaydin.Text = "မဆိုးပါဘူး";
            }
            if (iCard == 3)
            {
                pic2.Image = Image.FromFile("D:\\CStutorial\\baydin\\fool.jpg");
                txtBaydin.Text = "သင် ကံဆိုးနေသည်";
            }

            // 3. အခြားဖဲချပ်တွေကို (pic2 and 3) မှောက်ခိုင်းထားမယ်
            pic1.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
            pic3.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");


            // 4. Disable လုပ်မယ်
            pic1.Enabled = false;
            pic2.Enabled = false;
            pic3.Enabled = false;


        }

        private void pic3_Click(object sender, EventArgs e)
        {
            //  1. Random number 1 - 3 generate
            Random rnd = new Random();
            int iCard = rnd.Next(1, 4);

            //  2. ကျလာတဲ့ တန်ဖိုးပေါ် မူတည်ပြီး သက်ဆိုင်ရာ ပုံပြမယ်
            //      ဥပမာ 1-King   2-Queen  3-Fool
            if (iCard == 1)
            {
                pic3.Image = Image.FromFile("D:\\CStutorial\\baydin\\king.png");
                txtBaydin.Text = "ဘုရင်ဖြစ်ကိန်းရှိသည်";
            }
            if (iCard == 2)
            {
                pic3.Image = Image.FromFile("D:\\CStutorial\\baydin\\queen.jpg");
                txtBaydin.Text = "မဆိုးပါဘူး";
            }
            if (iCard == 3)
            {
                pic3.Image = Image.FromFile("D:\\CStutorial\\baydin\\fool.jpg");
                txtBaydin.Text = "သင် ကံဆိုးနေသည်";
            }

            // 3. အခြားဖဲချပ်တွေကို (pic2 and 3) မှောက်ခိုင်းထားမယ်
            pic2.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
            pic1.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");


            // 4. Disable လုပ်မယ်
            pic1.Enabled = false;
            pic2.Enabled = false;
            pic3.Enabled = false;


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pic1.Enabled = true;
            pic2.Enabled = true;
            pic3.Enabled = true;
            pic1.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
            pic2.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
            pic3.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
            txtBaydin.Clear();
        }
    }
}
