using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; /// <summary>
/// 
/// </summary>

namespace _2022022401_CS_Login_Exam_2
{
    public partial class frmPhysics : Form
    {
        int iPhysicsPages = 0;
        int iPhysicTotalMarks = 0;
        public frmPhysics()
        {
            InitializeComponent();
        }

        private void frmPhysics_Load(object sender, EventArgs e)
        {
            txtPhysicsQuestion.Text = "Speed of light is ......";
            lblAns1.Text = "(a) 299 792 458 m/s";
            lblAns2.Text = "(b) 499 792 458 m/s";
            lblAns3.Text = "(c) 999 792 458 m/s";



        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            string sAns = txtMultipleChoice .Text;
            if(sAns == "a")
            {
                iPhysicTotalMarks += 10;
                MessageBox.Show("Correct Answer!");
                txtPhysicsTotalMarks.Text = iPhysicTotalMarks.ToString();
            }
            else
            {
                MessageBox.Show("Wrong Answer!");
            }
        }

        private void btnNextPhysicsQuestion_Click(object sender, EventArgs e)
        {
            iPhysicsPages++;
            string sPhysicsQuestion = "";


            StreamReader srPhysicsQuestion = new StreamReader("physics_questions.txt");
            sPhysicsQuestion = srPhysicsQuestion.ReadToEnd();

            txtPhysicsQuestion.Text = sPhysicsQuestion ;
            lblAns1.Text = "";
            lblAns2.Text = "";
            lblAns3.Text = "";
            txtMultipleChoice.Clear();
            txtMultipleChoice.Focus();
        }
    }
}
