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

namespace Exam_System
{
    public partial class frmExam : Form
    {

        string[] saQuestions = new string[100];
        string[] saCurrentQuestion = new string[7];
        int iCurrentQno = 0;
        int iTotalQ = 0;
        string sCurrentCorrectAns = "";

        public frmExam()
        {
            InitializeComponent();
        }

        private void frmExam_Load(object sender, EventArgs e)
        {
           
        }

        private void funMarking()
        {
            if( rdo1.Checked == false && rdo2.Checked == false && rdo3.Checked == false && rdo4.Checked == false )
            {
                MessageBox.Show("Please Choose One Answer");
            }
            else
            {
                int iScore = int.Parse(txtScores.Text);
                if (sCurrentCorrectAns == "1" && rdo1.Checked == true)
                {
                    iScore = iScore + 10;
                }
                else if (sCurrentCorrectAns == "2" && rdo2.Checked == true)
                {
                    iScore = iScore + 10;
                }
                else if (sCurrentCorrectAns == "3" && rdo3.Checked == true)
                {
                    iScore = iScore + 10;
                }
                else if (sCurrentCorrectAns == "4" && rdo4.Checked == true)
                {
                    iScore = iScore + 10;
                }
                txtScores.Text = iScore.ToString();
                btnSubmit.Enabled = false;
                rdo1.Enabled = false;
                rdo2.Enabled = false;
                rdo3.Enabled = false;
                rdo4.Enabled = false;
            }

           
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            funMarking();
            btnNext .Enabled = true;
           
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(iCurrentQno < iTotalQ ) //    4 - 0 1 2 3
            {
                funNextQuestion();
            }
            else{
                MessageBox.Show("The Quiz is Over");
                btnNext .Enabled = false;    
            }
            
        }

        private void funNextQuestion()
        {
            saCurrentQuestion = saQuestions[iCurrentQno].Split('#');
            if(saCurrentQuestion .Length ==7)
            {
                txtQuestion.Text = saCurrentQuestion[1];
                rdo1.Text = saCurrentQuestion[2];
                rdo2.Text = saCurrentQuestion[3];
                rdo3.Text = saCurrentQuestion[4];
                rdo4.Text = saCurrentQuestion[5];
                sCurrentCorrectAns = saCurrentQuestion[6];
                iCurrentQno++;
                lblQno.Text = iCurrentQno + "/" + iTotalQ;
                btnSubmit.Enabled = true;
                rdo1.Enabled = true;
                rdo2.Enabled = true;
                rdo3.Enabled = true;
                rdo4.Enabled = true;

                btnNext.Enabled = false;
            }
            else
            {
                iCurrentQno++;
                funNextQuestion();
            }
          
        }

        private void frmExam_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if(ofdFname .ShowDialog() == DialogResult.OK)
            {
                txtFname .Text = ofdFname.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtScores.Text = "0";
            if(txtFname .Text ==string.Empty )
            {
                MessageBox.Show("Invalid question");
                return;
            }
            string sQuestion = txtFname .Text ;
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(sQuestion))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        saQuestions[iTotalQ] = line;
                        iTotalQ = iTotalQ + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            funNextQuestion();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
