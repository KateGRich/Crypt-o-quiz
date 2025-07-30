namespace PresentationLayer
{
    public partial class frmCryptidQuiz : Form
    {
        public frmCryptidQuiz()
        {
            InitializeComponent();
        }

        private void btnViewQuizzes_Click(object sender, EventArgs e)
        {
            var quizzesForm = new frmViewQuizzes();
            quizzesForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}