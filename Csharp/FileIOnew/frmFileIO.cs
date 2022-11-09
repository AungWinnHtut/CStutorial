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

      

        private void btnFileExist_Click(object sender, EventArgs e)
        {
            string sFilePath = txtFilePath .Text ;
           if( File.Exists(sFilePath))
            {
                MessageBox.Show("ဖိုင်ရှိပါတယ်");
            }
            else
            {
                MessageBox.Show("ဖိုင်မရှိပါ");
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            string sOldName = txtFilePath .Text ;
            string sNewName = txtFileNewPath .Text ;
            File.Move (sOldName, sNewName);
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            File.Delete (txtFilePath .Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sOriginalFilePath = txtFilePath .Text ;
            string sCopyFilePath = txtFileNewPath .Text ;
            File.Copy (sOriginalFilePath, sCopyFilePath);
        }
    }
}