using System.IO;
namespace FileIO
{
    public partial class frmFileIO : Form
    {
        public frmFileIO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sFilePath = txtFilePath .Text;
            if(File.Exists(sFilePath))
            {
                MessageBox.Show ("ဖိုင်ရှိတယ်");
            }
            else
            {
                MessageBox.Show("ဖိုင်မရှိပါ");
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            string sFilePath = txtFilePath.Text;
            string sNewFilePath = txtNewFilePath.Text;
            File.Move(sFilePath, sNewFilePath);
        }
    }
}