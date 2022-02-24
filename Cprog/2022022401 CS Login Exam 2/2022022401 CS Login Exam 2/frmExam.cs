using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022022401_CS_Login_Exam_2
{
    public partial class frmExam : Form
    {
        public frmExam()
        {
            InitializeComponent();
        }

        private void frmExam_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application .Exit();
        }

        private void frmExam_Load(object sender, EventArgs e)
        {
            this.Text = "Exam System";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application .Exit();
        }

        private void mathsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaths maths = new frmMaths();
            maths.ShowDialog();

        }

        private void physicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhysics physics = new frmPhysics();
            physics.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }
    }
}
