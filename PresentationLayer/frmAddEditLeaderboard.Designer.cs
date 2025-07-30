namespace PresentationLayer
{
    partial class frmAddEditLeaderboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblScore = new Label();
            lblQuizName = new Label();
            lblDate = new Label();
            txtScore = new TextBox();
            txtQuizName = new TextBox();
            txtDate = new TextBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = SystemColors.ControlLightLight;
            lblFirstName.Location = new Point(395, 119);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(125, 35);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            lblFirstName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(395, 157);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(350, 31);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = SystemColors.ControlLightLight;
            lblLastName.Location = new Point(395, 228);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(125, 35);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            lblLastName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(395, 266);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(350, 31);
            txtLastName.TabIndex = 3;
            // 
            // lblScore
            // 
            lblScore.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.ForeColor = SystemColors.ControlLightLight;
            lblScore.Location = new Point(70, 119);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(125, 35);
            lblScore.TabIndex = 4;
            lblScore.Text = "Score";
            lblScore.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblQuizName
            // 
            lblQuizName.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuizName.ForeColor = SystemColors.ControlLightLight;
            lblQuizName.Location = new Point(71, 23);
            lblQuizName.Name = "lblQuizName";
            lblQuizName.Size = new Size(125, 35);
            lblQuizName.TabIndex = 5;
            lblQuizName.Text = "Quiz Name";
            lblQuizName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = SystemColors.ControlLightLight;
            lblDate.Location = new Point(70, 228);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(125, 35);
            lblDate.TabIndex = 6;
            lblDate.Text = "Date";
            lblDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtScore
            // 
            txtScore.BackColor = SystemColors.InactiveCaption;
            txtScore.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtScore.Location = new Point(71, 157);
            txtScore.Name = "txtScore";
            txtScore.ReadOnly = true;
            txtScore.Size = new Size(176, 31);
            txtScore.TabIndex = 7;
            // 
            // txtQuizName
            // 
            txtQuizName.BackColor = SystemColors.InactiveCaption;
            txtQuizName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuizName.Location = new Point(70, 61);
            txtQuizName.Name = "txtQuizName";
            txtQuizName.ReadOnly = true;
            txtQuizName.Size = new Size(675, 31);
            txtQuizName.TabIndex = 8;
            // 
            // txtDate
            // 
            txtDate.BackColor = SystemColors.InactiveCaption;
            txtDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDate.Location = new Point(70, 266);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(176, 31);
            txtDate.TabIndex = 9;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Yu Gothic UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(568, 362);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(177, 59);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Yu Gothic UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(70, 362);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(177, 59);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddEditLeaderboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(800, 453);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(txtDate);
            Controls.Add(txtQuizName);
            Controls.Add(txtScore);
            Controls.Add(lblDate);
            Controls.Add(lblQuizName);
            Controls.Add(lblScore);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Name = "frmAddEditLeaderboard";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAddEditLeaderboard";
            Load += frmAddEditLeaderboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblScore;
        private Label lblQuizName;
        private Label lblDate;
        private TextBox txtScore;
        private TextBox txtQuizName;
        private TextBox txtDate;
        private Button btnSubmit;
        private Button btnCancel;
    }
}