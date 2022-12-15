namespace QuizTest
{
    public partial class frmQuiz : Form
    {

        int correctAnswer = 1; //0-left 1-right
        int userChoice;
        int Marks = 0;
        public frmQuiz()
        {
            InitializeComponent();
        }

        private void frmQuiz_Load(object sender, EventArgs e)
        {
            lblMarks.Text = Marks.ToString();
            lblQuestion.Text = "The longest river";
            lblLeft.Text = "Ayawaddy";
            lblRight.Text = "Nile";
            picLeft.Image = Image.FromFile(@"C:\quiz\IR.jpg");
            picRight.Image = Image.FromFile(@"C:\quiz\N.png");

        }

        private void picLeft_Click(object sender, EventArgs e)
        {
            userChoice = 0;
            checkAnswer();
        }

        private void picRight_Click(object sender, EventArgs e)
        {
            userChoice = 1;
            checkAnswer();
        }

        void checkAnswer()
        {
            if (userChoice == correctAnswer)
            {
                MessageBox.Show("Correct!");
                Marks = Marks + 10;
                lblMarks.Text = Marks.ToString();
                // Marks+=10;
            }
            else
            {
                MessageBox.Show("Wrong Ans!");
            }
        }
    }
}