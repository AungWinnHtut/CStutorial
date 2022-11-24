using System.IO;
using System.Windows.Forms;

namespace TextEditor01
{
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sText = txtEditor.Text;
            string sFname = "";

            saveFileDialog1.InitialDirectory = @"I:\test";
            saveFileDialog1.Title = "GH File Save As...";
            saveFileDialog1.Filter = "စာသားဖိုင်များ| *.txt     |ဖိုင်အားလုံး|   *.*";

            if (saveFileDialog1 .ShowDialog ()==DialogResult.OK)
            {
                sFname = saveFileDialog1.FileName;

                StreamWriter sw = new StreamWriter(sFname, true);
                sw.WriteLine(sText);
                sw.Close();
                MessageBox.Show("File is Saved!");
            }
            else
            {
                MessageBox.Show("File saving cancel!");
            }
            
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEditor .Clear();
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sText = txtEditor.Text;
            string sFname = "";

            saveFileDialog1.InitialDirectory = @"I:\test";
            saveFileDialog1.Title = "GH File Save As...";
            saveFileDialog1.Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sFname = saveFileDialog1.FileName;

                StreamWriter sw = new StreamWriter(sFname, true);
                sw.WriteLine(sText);
                sw.Close();
                MessageBox.Show("File is Saved!");
            }
            else
            {
                MessageBox.Show("File saving cancel!");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sFname = "";
            openFileDialog1.InitialDirectory = @"I:\test";
            openFileDialog1.Title = "GH File Open...";
            openFileDialog1.Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            openFileDialog1.FileName = "";
            if (openFileDialog1 .ShowDialog ()==DialogResult.OK)
            {
                sFname =openFileDialog1.FileName;
                StreamReader sr = new StreamReader(sFname);
                string sText = sr.ReadToEnd();
                sr.Close();
                txtEditor.Text = sText;
                string justFname = Path.GetFileName(sFname);
                this.Text = this.Text + " - " + justFname;
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Clear();
        }
    }
}