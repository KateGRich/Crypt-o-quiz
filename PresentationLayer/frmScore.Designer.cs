namespace PresentationLayer
{
    partial class frmScore
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
            btnAddMyScore = new Button();
            lblScore = new Label();
            lblPlayerScore = new Label();
            btnNoThanks = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAddMyScore
            // 
            btnAddMyScore.Font = new Font("Yu Gothic UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddMyScore.Location = new Point(466, 328);
            btnAddMyScore.Name = "btnAddMyScore";
            btnAddMyScore.Size = new Size(213, 93);
            btnAddMyScore.TabIndex = 0;
            btnAddMyScore.Text = "Add My Score";
            btnAddMyScore.UseVisualStyleBackColor = true;
            btnAddMyScore.Click += btnAddMyScore_Click;
            // 
            // lblScore
            // 
            lblScore.Font = new Font("Berkshire Swash", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.Snow;
            lblScore.Location = new Point(196, 101);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(233, 50);
            lblScore.TabIndex = 1;
            lblScore.Text = "Your Score Is:";
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayerScore
            // 
            lblPlayerScore.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerScore.ForeColor = Color.Aqua;
            lblPlayerScore.Location = new Point(435, 94);
            lblPlayerScore.Name = "lblPlayerScore";
            lblPlayerScore.Size = new Size(190, 64);
            lblPlayerScore.TabIndex = 2;
            lblPlayerScore.Text = "playerScore";
            lblPlayerScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNoThanks
            // 
            btnNoThanks.Font = new Font("Yu Gothic UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNoThanks.Location = new Point(121, 328);
            btnNoThanks.Name = "btnNoThanks";
            btnNoThanks.Size = new Size(213, 93);
            btnNoThanks.TabIndex = 3;
            btnNoThanks.Text = "No Thanks!";
            btnNoThanks.UseVisualStyleBackColor = true;
            btnNoThanks.Click += btnNoThanks_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Berkshire Swash", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(196, 222);
            label1.Name = "label1";
            label1.Size = new Size(416, 90);
            label1.TabIndex = 4;
            label1.Text = "Add to Leaderboard?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmScore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnNoThanks);
            Controls.Add(lblPlayerScore);
            Controls.Add(lblScore);
            Controls.Add(btnAddMyScore);
            Name = "frmScore";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmScore";
            Load += frmScore_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddMyScore;
        private Label lblScore;
        private Label lblPlayerScore;
        private Button btnNoThanks;
        private Label label1;
    }
}