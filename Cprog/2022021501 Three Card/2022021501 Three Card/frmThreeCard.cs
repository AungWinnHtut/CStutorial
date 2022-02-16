using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022021501_Three_Card
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
            picOne.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
            picOne.SizeMode = PictureBoxSizeMode.StretchImage;

            picTwo.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
            picTwo.SizeMode = PictureBoxSizeMode.StretchImage;

            picThree.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
            picThree.SizeMode = PictureBoxSizeMode.StretchImage;

            txtBaydin .Enabled = false;
            txtBaydin.ForeColor = Color.Red;
            txtBaydin.SelectionAlignment= HorizontalAlignment.Center;
         
        }

        private void picOne_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int iChoice = rnd.Next(1, 4);

            if (iChoice == 1)
            {
                picOne.Image = Image.FromFile("D:\\CStutorial\\baydin\\king.png");
                picTwo.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
                picThree.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
                txtBaydin.Text = "King, သင်ကံကောင်းနေသည်";
            }

            if (iChoice == 2)
            {
                picOne.Image = Image.FromFile("D:\\CStutorial\\baydin\\queen.jpg");
                picTwo.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
                picThree.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
                txtBaydin.Text = "Queen, မဆိုးပါဘူး";
            }
            if (iChoice == 3)
            {
                picOne.Image = Image.FromFile("D:\\CStutorial\\baydin\\fool.jpg");
                picTwo.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
                picThree.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
                txtBaydin.Text = "Fool, သင်ကံဆိုးနေသည်";
            }


            picOne.Enabled = false;
            picTwo.Enabled = false;
            picThree.Enabled = false;
           
           
        }

        private void picTwo_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int iChoice = rnd.Next(1, 4);

            if (iChoice == 1)
            {
                picTwo.Image = Image.FromFile("D:\\CStutorial\\baydin\\king.png");
                picOne.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
                picThree.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
                txtBaydin.Text = "King, သင်ကံကောင်းနေသည်";
            }

            if (iChoice == 2)
            {
                picTwo.Image = Image.FromFile("D:\\CStutorial\\baydin\\queen.jpg");
                picOne.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
                picThree.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
                txtBaydin.Text = "Queen, မဆိုးပါဘူး";
            }
            if (iChoice == 3)
            {
                picTwo.Image = Image.FromFile("D:\\CStutorial\\baydin\\fool.jpg");
                picOne.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
                picThree.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
                txtBaydin.Text = "Fool, သင်ကံဆိုးနေသည်";
            }


            picOne.Enabled = false;
            picTwo.Enabled = false;
            picThree.Enabled = false;


        }

        private void picThree_Click(object sender, EventArgs e)
        {
            // 1 -3 ကြား random vlue တစ်ခု ဖန်တီး
            Random rnd = new Random();
            int iChoice = rnd.Next(1, 4);

            // 1 ဖြစ်ရင် ဒါတွေလုပ်မယ်
            if (iChoice == 1)
            {
                picThree.Image = Image.FromFile("D:\\CStutorial\\baydin\\king.png");
                picTwo.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
                picOne.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
                txtBaydin.Text = "King, သင်ကံကောင်းနေသည်";
            }

            if (iChoice == 2)
            {
                picThree.Image = Image.FromFile("D:\\CStutorial\\baydin\\queen.jpg");
                picTwo.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
                picOne.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
                txtBaydin.Text = "Queen, မဆိုးပါဘူး";
            }
            if (iChoice == 3)
            {
                picThree.Image = Image.FromFile("D:\\CStutorial\\baydin\\fool.jpg");
                picTwo.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
                picOne.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
                txtBaydin.Text = "Fool, သင်ကံဆိုးနေသည်";
            }


            // User interactive လုပ်လို့မရအောင် enable false ပေးလိုက်မယ်
            picOne.Enabled = false;
            picTwo.Enabled = false;
            picThree.Enabled = false;


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            picOne.Enabled = true;
            picTwo.Enabled = true;
            picThree.Enabled=true;
        
            picOne.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
            picTwo.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
            picThree.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");

            txtBaydin.Clear();
           // txtBaydin.Text = "";
        }
    }
}
