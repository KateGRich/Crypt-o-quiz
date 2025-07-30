namespace PresentationLayer
{
    partial class frmLeaderboard
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
            datLeaderboard = new DataGridView();
            btnBackToQuizzes = new Button();
            btnDelete = new Button();
            lblQuizName = new Label();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)datLeaderboard).BeginInit();
            SuspendLayout();
            // 
            // datLeaderboard
            // 
            datLeaderboard.AllowUserToAddRows = false;
            datLeaderboard.AllowUserToDeleteRows = false;
            datLeaderboard.AllowUserToResizeColumns = false;
            datLeaderboard.AllowUserToResizeRows = false;
            datLeaderboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datLeaderboard.BackgroundColor = Color.LightSlateGray;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            datLeaderboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            datLeaderboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            datLeaderboard.DefaultCellStyle = dataGridViewCellStyle2;
            datLeaderboard.Location = new Point(60, 88);
            datLeaderboard.MultiSelect = false;
            datLeaderboard.Name = "datLeaderboard";
            datLeaderboard.ReadOnly = true;
            datLeaderboard.RowHeadersVisible = false;
            datLeaderboard.RowHeadersWidth = 51;
            datLeaderboard.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datLeaderboard.Size = new Size(731, 259);
            datLeaderboard.TabIndex = 0;
            // 
            // btnBackToQuizzes
            // 
            btnBackToQuizzes.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToQuizzes.Location = new Point(60, 374);
            btnBackToQuizzes.Name = "btnBackToQuizzes";
            btnBackToQuizzes.Size = new Size(185, 65);
            btnBackToQuizzes.TabIndex = 5;
            btnBackToQuizzes.Text = "Back to Quizzes";
            btnBackToQuizzes.UseVisualStyleBackColor = true;
            btnBackToQuizzes.Click += btnBackToQuizzes_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(606, 374);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(185, 65);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblQuizName
            // 
            lblQuizName.Font = new Font("Berkshire Swash", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuizName.ForeColor = Color.Ivory;
            lblQuizName.Location = new Point(188, 9);
            lblQuizName.Name = "lblQuizName";
            lblQuizName.Size = new Size(476, 64);
            lblQuizName.TabIndex = 8;
            lblQuizName.Text = "quiz name displays here";
            lblQuizName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(333, 374);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(185, 65);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // frmLeaderboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(854, 482);
            Controls.Add(btnEdit);
            Controls.Add(lblQuizName);
            Controls.Add(btnDelete);
            Controls.Add(btnBackToQuizzes);
            Controls.Add(datLeaderboard);
            Name = "frmLeaderboard";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmLeaderboard";
            Load += frmLeaderboard_Load;
            ((System.ComponentModel.ISupportInitialize)datLeaderboard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView datLeaderboard;
        private Button btnBackToQuizzes;
        private Button btnDelete;
        private Label lblQuizName;
        private Button btnEdit;
    }
}