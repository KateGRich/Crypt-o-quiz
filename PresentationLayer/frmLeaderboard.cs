using DataDomain;
using LogicLayer;
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
    public partial class frmLeaderboard : Form
    {
        private string _quizName;
        private string _leaderboardFileName;

        private List<QuizLeaderboard> _leaderboard = new List<QuizLeaderboard>();
        private LeaderboardManager _leaderboardManager = new LeaderboardManager();

        public frmLeaderboard(string quizName, string leaderboardFileName)
        {
            _quizName = quizName;
            _leaderboardFileName = leaderboardFileName;

            InitializeComponent();
        }

        // Back To Quizzes - Button Click Event.
        private void btnBackToQuizzes_Click(object sender, EventArgs e)
        {
            Close();
        }

        // frmLeaderboard - Load Event.
        private void frmLeaderboard_Load(object sender, EventArgs e)
        {
            this.Text = _quizName + " Leaderboard";
            lblQuizName.Text = _quizName;

            try
            {
                _leaderboard = _leaderboardManager.GetLeaderboard(_leaderboardFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message);
            }
            displayLeaderboard();
        }

        // Display the List of Leaderboard Data.
        private void displayLeaderboard()
        {
            datLeaderboard.DataSource = _leaderboard;

            // Extra Spacing is for Display on Data Grid
            datLeaderboard.Columns[0].HeaderText = "    Place";
            datLeaderboard.Columns[1].HeaderText = "    Player Name";
            datLeaderboard.Columns[2].HeaderText = "    Player Score";
            datLeaderboard.Columns[3].HeaderText = "    Date Achieved";
            datLeaderboard.ClearSelection();
        }

        // Edit a Leaderboard Record.
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (datLeaderboard.SelectedRows.Count == 0)
            {
                MessageBox.Show("You must select a record in order to edit the leaderboard.", "No Record Selected");
                return;
            }

            // Get the selected record.
            QuizLeaderboard record = _leaderboard[datLeaderboard.SelectedRows[0].Index];

            // Pass to the AddEditLeaderboardForm.
            var addEditLeaderboardForm = new frmAddEditLeaderboard(_quizName, _leaderboardFileName, record);
            addEditLeaderboardForm.ShowDialog();
            // "Refresh" form to show newly updated data.
            new frmLeaderboard(_quizName, _leaderboardFileName).ShowDialog();
            this.Close();
        }

        // Delete a Leaderboard Record.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(datLeaderboard.SelectedRows.Count == 0)
            {
                MessageBox.Show("You must select a record to Delete.", "No Record Selected");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to permanently delete this record?", "Permanently Delete Record?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                // Get the selected record.
                QuizLeaderboard record = _leaderboard[datLeaderboard.SelectedRows[0].Index];
            
                // User the LeaderboardManager & DataAccessor to delete the record, while changing the Place of every following record.
                bool isDeleted = _leaderboardManager.DeleteRecord(_leaderboardFileName, record);

                if(isDeleted == true)
                {
                    MessageBox.Show("Leaderboard Record Deleted Succesfully!", "Delete Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // "Refresh" form to show newly updated data.
                    new frmLeaderboard(_quizName, _leaderboardFileName).ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
