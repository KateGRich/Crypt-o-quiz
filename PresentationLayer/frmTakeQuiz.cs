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
    public partial class frmTakeQuiz : Form
    {
        private int _questionCount = 0;

        private int _playerScore = 0;
        private string[] _playerAnswers;

        private string _quizName;
        private string _quizFileName;
        private string _leaderboardFileName;
        private List<QuizQuestion> _quizToTake;
        private QuizManager _quizManager;

        public frmTakeQuiz(string quizName, string quizFileName, string leaderboardFileName, QuizManager quizManager)
        {
            // pass to this the quiz that was select
            // save this object to _quizToTake
            _quizName = quizName;
            _quizFileName = quizFileName;
            _leaderboardFileName = leaderboardFileName;
            _quizManager = quizManager;

            InitializeComponent();
        }

        // Take Quiz - Load Event.
        private void frmTakeQuiz_Load(object sender, EventArgs e)
        {
            // put its name up in the tile (i.e. General Quiz)  
            this.Text = _quizName;

            // use its filename to get the list of QuizQuestions
            // save them to _questionList
            try
            {
                _quizToTake = _quizManager.GetQuizToTake(_quizFileName);
                _playerAnswers = new string[_quizToTake.Count];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message);
            }

            // call showQuestion to display the first question and its list of possible answers
            showQuestion();
        }

        // Show Question & Possible Answers.
        private void showQuestion()
        {
            try
            {
                gbQuestion.Text = "Question " + (_questionCount + 1);
                lblQuestion.Text = _quizToTake[_questionCount].Question;
                cbAnswers.Items.Add(_quizToTake[_questionCount].Answer1);
                cbAnswers.Items.Add(_quizToTake[_questionCount].Answer2);
                cbAnswers.Items.Add(_quizToTake[_questionCount].Answer3);
                cbAnswers.Items.Add(_quizToTake[_questionCount].Answer4);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message);
            }

            if(_questionCount == 0)
            {
                btnBack.Enabled = false;
                btnBack.Visible = false;
            }
            else
            {
                btnBack.Enabled = true;
                btnBack.Visible = true;
                
            }

            if(_questionCount == _quizToTake.Count - 1)
            {
                btnNext.Enabled = false;
                btnNext.Visible = false;
                btnSubmit.Enabled = true;
                btnSubmit.Visible = true;
            }
            else
            {
                btnNext.Enabled = true;
                btnNext.Visible = true;
                btnSubmit.Enabled = false;
                btnSubmit.Visible = false;
            }
        }

        // Take Quiz - Next Button Click Event.
        private void btnNext_Click(object sender, EventArgs e)
        {
            collectPlayerAnswer();
            if(collectPlayerAnswer() == false)
            {
                DialogResult result = MessageBox.Show("You must select an answer.", "No Answer Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            
            _questionCount++;
            if(_questionCount >= _quizToTake.Count)
            {
                btnNext.Enabled = false;
            }

            cbAnswers.Items.Clear();
            showQuestion();
        }

        // Take Quiz - Back Button Click Event.
        private void btnBack_Click(object sender, EventArgs e)
        {
            _questionCount--;
            if (_questionCount < 0)
            {
                _questionCount = _quizToTake.Count - 1;
            }

            cbAnswers.Items.Clear();
            showQuestion();
        }

        // Take Quiz - Quit Button Click Event.
        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?\n" +
                "All of your progress will be lost.", "Give Up?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        // Take Quiz - Submit Button Click Event.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            collectPlayerAnswer();
            if (collectPlayerAnswer() == false)
            {
                DialogResult result = MessageBox.Show("You must select an answer.", "No Answer Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tallyScore();

            string playerScoreString = _playerScore + " out of " + _quizToTake.Count;

            var scoreForm = new frmScore(_quizName, _leaderboardFileName, playerScoreString, _playerScore);
            scoreForm.ShowDialog();
            this.Close();
        }


        // Collect Player's Answers in a string[].
        public bool collectPlayerAnswer()
        {
            if(cbAnswers.SelectedItem != null)
            {
                _playerAnswers[_questionCount] = cbAnswers.SelectedItem.ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        // Tally up the Player's Score.
        public void tallyScore()
        {
            for(int i = 0; i < _quizToTake.Count; i++)
            {
                if (_quizToTake[i].CorrectAnswer == _playerAnswers[i])
                {
                    _playerScore++;
                }
            }
        }
    }
}