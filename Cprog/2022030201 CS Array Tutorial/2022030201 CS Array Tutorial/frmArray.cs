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

namespace _2022030201_CS_Array_Tutorial
{
    public partial class frmArray : Form
    {
        int iQno = 0;
        string[] saQA = new string[100];
        int iTotalQuestion = 0;
        int iTotalMarks = 0;
        string[] saSplit = new string[6];

        public frmArray()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (iQno < iTotalQuestion ) //0 1 2      3
            {
                saSplit = saQA[iQno].Split('$');
                txtNumber.Text = saSplit[0];
                txtQuestion.Text = saSplit[1];
                txtAns1.Text = saSplit[2];
                txtAns2.Text = saSplit[3];
                txtAns3.Text = saSplit[4];
                //txtCorrectAnswer.Text = saSplit[5];
                iQno++;
            }
            else
            {
                MessageBox.Show("Exam Questions Over");
            }
           
        }

        private void frmArray_Load(object sender, EventArgs e)
        {
            string sLine = string.Empty;
            StreamReader sr = new StreamReader("questions.txt");
            while((sLine = sr.ReadLine()) != null && (sLine != ""))
            {
                saQA[iTotalQuestion ] = sLine;
                iTotalQuestion ++;
            }
           
           
            saSplit = saQA[iQno].Split('$');
            txtNumber .Text = saSplit[0];
            txtQuestion .Text = saSplit[1];
            txtAns1.Text = saSplit[2];
            txtAns2.Text = saSplit[3];
            txtAns3 .Text = saSplit[4];
            //txtCorrectAnswer .Text =saSplit[5];
            iQno++;

            txtNumber.Enabled = false;
            txtQuestion .Enabled = false;
            txtAns1 .Enabled = false;
            txtAns2.Enabled = false;
            txtAns3.Enabled = false;
            txtTotalMarks.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sAns = txtCorrectAnswer .Text;
            if(sAns == saSplit [5])
            {
                iTotalMarks += 10;
                txtTotalMarks .Text = iTotalMarks .ToString();
            }
        }
    }
}
