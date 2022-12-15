using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp3
{
    public partial class frmQuiz1 : Form
    {
        int ans_1 = 3; //1 left, 2 middle, 3 right
        int Marks = 0;
        public frmQuiz1()
        {
            InitializeComponent();
        }

        private void btnSend_1_Click(object sender, EventArgs e)
        {
            if(rdoAns3_1 .Checked ==true )
            {
                Marks += 10;
                MessageBox.Show("Right!");
            }
            else
            {
                MessageBox.Show("Wrong");
            }
            this.Hide();
            frmQuiz2 frmQuiz2= new frmQuiz2();
            frmQuiz2.Show();

        }

        private void frmQuiz1_Load(object sender, EventArgs e)
        {
            lblQ1_1.Text = "Longest river in the world....";
            rdoAns1_1.Text = "Ayeyarwaddy";
            rdoAns2_1.Text = "Chindwin";
            rdoAns3_1.Text = "Nile";

        }
    }
}
