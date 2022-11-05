using System.IO;


namespace FileIOnew
{
    public partial class frmFileIO : Form
    {
        public frmFileIO()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckFile_Click(object sender, EventArgs e)
        {
            string sFilePath = @"I:\test.txt";
            if(File.Exists(sFilePath))
            {
                MessageBox.Show("File Exists");
            }
            else
            {
                MessageBox.Show("Error!!! Such File does not exists");
            }

        }
    }
}