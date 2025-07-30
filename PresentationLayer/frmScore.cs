using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmScore : Form
    {
        private string _quizName;
        private string _leaderboardFileName;
        private string _playerScoreString;
        private int _playerScore;
        public frmScore(string quizName, string leaderboardFileName, string playerScoreString, int playerScore)
        {
            _quizName = quizName;
            _leaderboardFileName = leaderboardFileName;
            _playerScoreString = playerScoreString;
            _playerScore = playerScore;
            InitializeComponent();
        }

        // Score Form - Load Event.
        private void frmScore_Load(object sender, EventArgs e)
        {
            // Put Quiz Name in the Title.
            this.Text = _quizName + " Score";

            // Show the player their score.
            lblPlayerScore.Text = _playerScoreString;
        }


        // Add My Score - Button Click Event.
        private void btnAddMyScore_Click(object sender, EventArgs e)
        {
            var addEditLeaderboardForm = new frmAddEditLeaderboard(_quizName, _leaderboardFileName, _playerScore);
            addEditLeaderboardForm.ShowDialog();
            this.Close();
        }


        // Score - No Thanks Button Click Event.
        private void btnNoThanks_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you don't want to add your score?\n" +
                "It will not be saved if you don't add it.", "Discard Score?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
        
    }
}