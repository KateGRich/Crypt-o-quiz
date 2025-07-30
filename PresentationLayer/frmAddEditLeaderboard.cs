using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataDomain;
using LogicLayer;

namespace PresentationLayer
{
    public partial class frmAddEditLeaderboard : Form
    {
        private bool _isEdit = false;

        private string _quizName;
        private string _leaderboardFileName;
        private int _playerScore = -1;


        private LeaderboardManager _leaderboardManager = new LeaderboardManager();
        private QuizLeaderboard _currentPlayerRecord = new QuizLeaderboard();

        // Edit Mode Constructor.
        public frmAddEditLeaderboard(string quizName, string leaderboardFileName, QuizLeaderboard record)
        {
            _quizName = quizName;
            _leaderboardFileName = leaderboardFileName;
            _currentPlayerRecord = record;

            InitializeComponent();
        }


        // Add Mode Constructor.
        public frmAddEditLeaderboard(string quizName, string leaderboardFileName, int playerScore)
        {
            _quizName = quizName;
            _leaderboardFileName = leaderboardFileName;
            _playerScore = playerScore;

            InitializeComponent();
        }

        private void frmAddEditLeaderboard_Load(object sender, EventArgs e)
        {
            // Form Title & Populate the fields Users cannot edit/populate.

            if(_playerScore == -1)
            {
                _isEdit = true;
            }

            if(_isEdit == false)
            {
                this.Text = "Add Your Score: " + _quizName + " Leaderboard";
                txtQuizName.Text = _quizName;
                txtScore.Text = _playerScore.ToString();
                txtDate.Text = DateOnly.FromDateTime(DateTime.Now).ToString();
            }
            else
            {
                this.Text = "Edit Record: " + _quizName + " Leaderboard";
                txtQuizName.Text = _quizName;
                txtScore.Text = _currentPlayerRecord.PlayerScore.ToString();
                txtDate.Text = _currentPlayerRecord.DateAchieved.ToString();


                // Get player's first & last name they entered previously.


                string firstName = "";
                string lastName = "";
                var name = _currentPlayerRecord.PlayerName.Split(' ');
                firstName = name[0];
                lastName = name[1];

                txtFirstName.Text = firstName;
                txtLastName.Text = lastName;
            }
        }

        // Cancel Button Click Event - doesn't save User score to Leaderboard.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you don't want to save your changes?", "Cancel?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        // Submit Button Click - Saves User name, score, etc. to the Leaderboard.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Ensure User entered values for First Name & Last Name.
            if(txtFirstName.Text == "")
            {
                MessageBox.Show("Please enter the First Name you'd like displayed in the leaderboard.");
                txtFirstName.Focus();
                return;
            }
            if(txtLastName.Text == "")
            {
                MessageBox.Show("Please enter the Last Name you'd like displayed in the leaderboard.");
                txtLastName.Focus();
                return;
            }
            
            // Ensure the Name fields don't contain spaces.
            if(txtFirstName.Text.Contains(' '))
            {
                MessageBox.Show("First Name cannot contain spaces. Please enter only one name here.");
                txtFirstName.Focus();
                return;
            }
            if(txtLastName.Text.Contains(' '))
            {
                MessageBox.Show("Last Name cannot contain spaces. Please enter only one name here.");
                txtLastName.Focus();
                return;
            }

            if(_isEdit == false) // Add Mode
            {
                _currentPlayerRecord.PlayerName = txtFirstName.Text + " " + txtLastName.Text;
                _currentPlayerRecord.PlayerScore = _playerScore;
                _currentPlayerRecord.DateAchieved = DateOnly.Parse(txtDate.Text);

                try
                {
                    // Determine the current player's place in the leaderboard.
                    List<QuizLeaderboard> newLeaderboard = _leaderboardManager.DeterminePlace(_leaderboardFileName, _currentPlayerRecord, _leaderboardManager);

                    if (_leaderboardManager.SaveLeaderboard(_leaderboardFileName, newLeaderboard))
                    {
                        MessageBox.Show("Your Score Was Added Successfully!", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;

                        // Show the leaderboard.
                        var leaderboardForm = new frmLeaderboard(_quizName, _leaderboardFileName);
                        leaderboardForm.ShowDialog();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message);
                }
            }
            else // Edit Mode
            {
                string newPlayerName = txtFirstName.Text + " " + txtLastName.Text;

                if(_leaderboardManager.SaveLeaderboard(_leaderboardFileName, _currentPlayerRecord, newPlayerName))
                {
                    MessageBox.Show("Leaderboard Record Updated Successfully!", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }

            }
        }
    }
}