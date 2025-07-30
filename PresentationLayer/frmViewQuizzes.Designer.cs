namespace PresentationLayer
{
    partial class frmViewQuizzes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnCancel = new Button();
            btnStartQuiz = new Button();
            btnStartGeneralQuiz = new Button();
            btnGeneralQuizLeaderboard = new Button();
            btnStartLochNessMonsterQuiz = new Button();
            btnLochNessMonsterQuizLeaderboard = new Button();
            btnStartMothmanQuiz = new Button();
            btnMothmanQuizLeaderboard = new Button();
            btnStartSkinwalkerQuiz = new Button();
            btnSkinwalkerQuizLeaderboard = new Button();
            datQuizList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)datQuizList).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Yu Gothic UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(52, 365);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(176, 59);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.Font = new Font("Yu Gothic UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartQuiz.Location = new Point(298, 365);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.Size = new Size(177, 59);
            btnStartQuiz.TabIndex = 2;
            btnStartQuiz.Text = "Start Quiz";
            btnStartQuiz.UseVisualStyleBackColor = true;
            btnStartQuiz.Click += btnStartQuiz_Click;
            // 
            // btnStartGeneralQuiz
            // 
            btnStartGeneralQuiz.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartGeneralQuiz.Location = new Point(500, 79);
            btnStartGeneralQuiz.Name = "btnStartGeneralQuiz";
            btnStartGeneralQuiz.Size = new Size(107, 32);
            btnStartGeneralQuiz.TabIndex = 3;
            btnStartGeneralQuiz.Text = "Start";
            btnStartGeneralQuiz.UseVisualStyleBackColor = true;
            btnStartGeneralQuiz.Click += btnStartGeneralQuiz_Click;
            // 
            // btnGeneralQuizLeaderboard
            // 
            btnGeneralQuizLeaderboard.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGeneralQuizLeaderboard.Location = new Point(641, 79);
            btnGeneralQuizLeaderboard.Name = "btnGeneralQuizLeaderboard";
            btnGeneralQuizLeaderboard.Size = new Size(123, 32);
            btnGeneralQuizLeaderboard.TabIndex = 4;
            btnGeneralQuizLeaderboard.Text = "Leaderboard";
            btnGeneralQuizLeaderboard.UseVisualStyleBackColor = true;
            btnGeneralQuizLeaderboard.Click += btnGeneralQuizLeaderboard_Click;
            // 
            // btnStartLochNessMonsterQuiz
            // 
            btnStartLochNessMonsterQuiz.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartLochNessMonsterQuiz.Location = new Point(500, 145);
            btnStartLochNessMonsterQuiz.Name = "btnStartLochNessMonsterQuiz";
            btnStartLochNessMonsterQuiz.Size = new Size(107, 32);
            btnStartLochNessMonsterQuiz.TabIndex = 5;
            btnStartLochNessMonsterQuiz.Text = "Start";
            btnStartLochNessMonsterQuiz.UseVisualStyleBackColor = true;
            btnStartLochNessMonsterQuiz.Click += btnStartLochNessMonsterQuiz_Click;
            // 
            // btnLochNessMonsterQuizLeaderboard
            // 
            btnLochNessMonsterQuizLeaderboard.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLochNessMonsterQuizLeaderboard.Location = new Point(641, 145);
            btnLochNessMonsterQuizLeaderboard.Name = "btnLochNessMonsterQuizLeaderboard";
            btnLochNessMonsterQuizLeaderboard.Size = new Size(123, 32);
            btnLochNessMonsterQuizLeaderboard.TabIndex = 6;
            btnLochNessMonsterQuizLeaderboard.Text = "Leaderboard";
            btnLochNessMonsterQuizLeaderboard.UseVisualStyleBackColor = true;
            btnLochNessMonsterQuizLeaderboard.Click += btnLochNessMonsterQuizLeaderboard_Click;
            // 
            // btnStartMothmanQuiz
            // 
            btnStartMothmanQuiz.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartMothmanQuiz.Location = new Point(500, 214);
            btnStartMothmanQuiz.Name = "btnStartMothmanQuiz";
            btnStartMothmanQuiz.Size = new Size(107, 32);
            btnStartMothmanQuiz.TabIndex = 7;
            btnStartMothmanQuiz.Text = "Start";
            btnStartMothmanQuiz.UseVisualStyleBackColor = true;
            btnStartMothmanQuiz.Click += btnStartMothmanQuiz_Click;
            // 
            // btnMothmanQuizLeaderboard
            // 
            btnMothmanQuizLeaderboard.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMothmanQuizLeaderboard.Location = new Point(641, 214);
            btnMothmanQuizLeaderboard.Name = "btnMothmanQuizLeaderboard";
            btnMothmanQuizLeaderboard.Size = new Size(123, 32);
            btnMothmanQuizLeaderboard.TabIndex = 8;
            btnMothmanQuizLeaderboard.Text = "Leaderboard";
            btnMothmanQuizLeaderboard.UseVisualStyleBackColor = true;
            btnMothmanQuizLeaderboard.Click += btnMothmanQuizLeaderboard_Click;
            // 
            // btnStartSkinwalkerQuiz
            // 
            btnStartSkinwalkerQuiz.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartSkinwalkerQuiz.Location = new Point(500, 278);
            btnStartSkinwalkerQuiz.Name = "btnStartSkinwalkerQuiz";
            btnStartSkinwalkerQuiz.Size = new Size(107, 32);
            btnStartSkinwalkerQuiz.TabIndex = 9;
            btnStartSkinwalkerQuiz.Text = "Start";
            btnStartSkinwalkerQuiz.UseVisualStyleBackColor = true;
            btnStartSkinwalkerQuiz.Click += btnStartSkinwalkerQuiz_Click;
            // 
            // btnSkinwalkerQuizLeaderboard
            // 
            btnSkinwalkerQuizLeaderboard.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSkinwalkerQuizLeaderboard.Location = new Point(641, 278);
            btnSkinwalkerQuizLeaderboard.Name = "btnSkinwalkerQuizLeaderboard";
            btnSkinwalkerQuizLeaderboard.Size = new Size(123, 32);
            btnSkinwalkerQuizLeaderboard.TabIndex = 10;
            btnSkinwalkerQuizLeaderboard.Text = "Leaderboard";
            btnSkinwalkerQuizLeaderboard.UseVisualStyleBackColor = true;
            btnSkinwalkerQuizLeaderboard.Click += btnSkinwalkerQuizLeaderboard_Click;
            // 
            // datQuizList
            // 
            datQuizList.AllowUserToAddRows = false;
            datQuizList.AllowUserToDeleteRows = false;
            datQuizList.AllowUserToResizeColumns = false;
            datQuizList.AllowUserToResizeRows = false;
            datQuizList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            datQuizList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            datQuizList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            datQuizList.DefaultCellStyle = dataGridViewCellStyle2;
            datQuizList.Location = new Point(52, 37);
            datQuizList.MultiSelect = false;
            datQuizList.Name = "datQuizList";
            datQuizList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            datQuizList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            datQuizList.RowHeadersVisible = false;
            datQuizList.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datQuizList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            datQuizList.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datQuizList.RowTemplate.Height = 65;
            datQuizList.RowTemplate.ReadOnly = true;
            datQuizList.ScrollBars = ScrollBars.Vertical;
            datQuizList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datQuizList.Size = new Size(423, 290);
            datQuizList.TabIndex = 11;
            // 
            // frmViewQuizzes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(datQuizList);
            Controls.Add(btnSkinwalkerQuizLeaderboard);
            Controls.Add(btnStartSkinwalkerQuiz);
            Controls.Add(btnMothmanQuizLeaderboard);
            Controls.Add(btnStartMothmanQuiz);
            Controls.Add(btnLochNessMonsterQuizLeaderboard);
            Controls.Add(btnStartLochNessMonsterQuiz);
            Controls.Add(btnGeneralQuizLeaderboard);
            Controls.Add(btnStartGeneralQuiz);
            Controls.Add(btnStartQuiz);
            Controls.Add(btnCancel);
            Name = "frmViewQuizzes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmViewQuizzes";
            Load += frmViewQuizzes_Load;
            ((System.ComponentModel.ISupportInitialize)datQuizList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCancel;
        private Button btnStartQuiz;
        private Button btnStartGeneralQuiz;
        private Button btnGeneralQuizLeaderboard;
        private Button btnStartLochNessMonsterQuiz;
        private Button btnLochNessMonsterQuizLeaderboard;
        private Button btnStartMothmanQuiz;
        private Button btnMothmanQuizLeaderboard;
        private Button btnStartSkinwalkerQuiz;
        private Button btnSkinwalkerQuizLeaderboard;
        private DataGridView datQuizList;
    }
}