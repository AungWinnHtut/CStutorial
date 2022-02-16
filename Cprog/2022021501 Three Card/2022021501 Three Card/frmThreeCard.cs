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
            picOne.Image = Image.FromFile("D:\\CStutorial\\baydin\\king.png");
            picTwo.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
            picThree.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
            picOne.Enabled = false;
            picTwo.Enabled = false;
            picThree.Enabled = false;
            txtBaydin.Text = "King, သင်ကံကောင်းနေသည်";
           
        }

        private void picTwo_Click(object sender, EventArgs e)
        {
            picTwo.Image = Image.FromFile("D:\\CStutorial\\baydin\\queen.jpg");
            picOne.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
            picThree.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
            picOne.Enabled = false;
            picTwo.Enabled = false;
            picThree.Enabled = false;
            txtBaydin.Text = "Queen, မဆိုးပါဘူး";
        }

        private void picThree_Click(object sender, EventArgs e)
        {
            picThree.Image = Image.FromFile("D:\\CStutorial\\baydin\\fool.jpg");
            picTwo.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
            picOne.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
            picOne.Enabled = false;
            picTwo.Enabled = false;
            picThree.Enabled = false;
            txtBaydin.Text = "Fool, သင်ကံဆိုးနေသည်";
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
