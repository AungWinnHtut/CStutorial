using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022021402_Fortune_Teller
{
    public partial class frmFortuneTeller : Form
    {
        public frmFortuneTeller()
        {
            InitializeComponent();
        }

        private void frmFortuneTeller_Load(object sender, EventArgs e)
        {
            this.Text = "Fortune Teller App";
            //picOne.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
            picTwo.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");
            picThree.Image = Image.FromFile("D:\\CStutorial\\baydin\\back.png");

            //picOne.SizeMode = PictureBoxSizeMode.StretchImage;
            picTwo.SizeMode = PictureBoxSizeMode.StretchImage;
            picThree.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void picOne_Click(object sender, EventArgs e)
        {
            picOne.Image = Image.FromFile("D:\\CStutorial\\baydin\\king.png");
        }

        private void picTwo_Click(object sender, EventArgs e)
        {
            picTwo.Image = Image.FromFile("D:\\CStutorial\\baydin\\queen.jpg");
        }

        private void picThree_Click(object sender, EventArgs e)
        {
            picThree.Image = Image.FromFile("D:\\CStutorial\\baydin\\fool.jpg");
        }
    }
}
