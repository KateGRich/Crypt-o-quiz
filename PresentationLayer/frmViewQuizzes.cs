using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using DataDomain;

namespace PresentationLayer
{
    public partial class frmViewQuizzes : Form
    {
        private List<QuizList> _quizList;
        private QuizManager _quizManager = new QuizManager();


        public frmViewQuizzes()
        {
            InitializeComponent();
        }


        // Cancel Button - Click Event.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }



        // frmViewQuizzes - Load Event
        private void frmViewQuizzes_Load(object sender, EventArgs e)
        {
            try
            {
                _quizList = _quizManager.GetQuizList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message);
            }
            displayQuizListData();
        }

        // Display the List of Quizzes.
        private void displayQuizListData()
        {
            datQuizList.DataSource = _quizList;
            datQuizList.Columns.RemoveAt(2);
            datQuizList.Columns.RemoveAt(2);

            // Extra Spacing is for Display on Data Grid
            datQuizList.Columns[0].HeaderText = "     Quiz Name";
            datQuizList.Columns[1].HeaderText = "     Number of Questions";
            datQuizList.ClearSelection();
        }

        // Start Quiz Click Event.
        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            if (datQuizList.SelectedRows.Count == 0)
            {
                MessageBox.Show("You must select a quiz or click the corresponding Start button for the quiz you'd like to take.", "No Selected Quiz");
                return;
            }
            int index = datQuizList.SelectedRows[0].Index;

            startQuiz(index);
        }


        // Start General Quiz.
        private void btnStartGeneralQuiz_Click(object sender, EventArgs e)
        {
            int index = 0;
            startQuiz(0);
        }

        // Start Loch Ness Monster Quiz.
        private void btnStartLochNessMonsterQuiz_Click(object sender, EventArgs e)
        {
            int index = 1;
            startQuiz(1);
        }

        // Start Mothman Quiz.
        private void btnStartMothmanQuiz_Click(object sender, EventArgs e)
        {
            int index = 2;
            startQuiz(2);
        }

        // Start Skinwalker Quiz.
        private void btnStartSkinwalkerQuiz_Click(object sender, EventArgs e)
        {
            int index = 3;
            startQuiz(3);
        }

        // Start Quiz.
        public void startQuiz(int index)
        {
            string quizName = _quizList[index].QuizName;
            string quizFileName = _quizList[index].QuizFileName;
            string leaderboardFileName = _quizList[index].QuizLeaderboardFileName;
            var takeQuizForm = new frmTakeQuiz(quizName, quizFileName, leaderboardFileName, _quizManager);
            takeQuizForm.ShowDialog();
        }





        // View General Quiz Leaderboard.
        private void btnGeneralQuizLeaderboard_Click(object sender, EventArgs e)
        {
            int index = 0;
            viewLeaderboard(0);
        }

        // View Loch Ness Monster Quiz Leaderboard.
        private void btnLochNessMonsterQuizLeaderboard_Click(object sender, EventArgs e)
        {
            int index = 1;
            viewLeaderboard(1);
        }

        // View Mothman Quiz Leaderboard.
        private void btnMothmanQuizLeaderboard_Click(object sender, EventArgs e)
        {
            int index = 2;
            viewLeaderboard(2);
        }

        // View Skinwalker Quiz Leaderboard.
        private void btnSkinwalkerQuizLeaderboard_Click(object sender, EventArgs e)
        {
            int index = 3;
            viewLeaderboard(3);
        }

        // View Leaderboard.
        public void viewLeaderboard(int index)
        {
            string quizName = _quizList[index].QuizName;
            string leaderboardFileName = _quizList[index].QuizLeaderboardFileName;
            var leaderboardForm = new frmLeaderboard(quizName, leaderboardFileName);
            leaderboardForm.ShowDialog();
        }
    }
}