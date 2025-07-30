namespace PresentationLayer
{
    partial class frmTakeQuiz
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
            btnSubmit = new Button();
            btnQuit = new Button();
            lblQuestion = new Label();
            cbAnswers = new ComboBox();
            btnNext = new Button();
            btnBack = new Button();
            gbQuestion = new GroupBox();
            lblChooseAnswer = new Label();
            gbQuestion.SuspendLayout();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Yu Gothic UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(593, 366);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(177, 59);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Yu Gothic UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.Location = new Point(38, 366);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(176, 59);
            btnQuit.TabIndex = 4;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lblQuestion
            // 
            lblQuestion.BackColor = Color.DarkGray;
            lblQuestion.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(48, 50);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(425, 86);
            lblQuestion.TabIndex = 5;
            lblQuestion.Text = "label1";
            // 
            // cbAnswers
            // 
            cbAnswers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAnswers.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbAnswers.FormattingEnabled = true;
            cbAnswers.Location = new Point(95, 176);
            cbAnswers.MaxDropDownItems = 4;
            cbAnswers.Name = "cbAnswers";
            cbAnswers.Size = new Size(335, 28);
            cbAnswers.TabIndex = 6;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(413, 233);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 39);
            btnNext.TabIndex = 7;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(18, 233);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 39);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // gbQuestion
            // 
            gbQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbQuestion.BackColor = Color.DarkGray;
            gbQuestion.Controls.Add(lblChooseAnswer);
            gbQuestion.Controls.Add(lblQuestion);
            gbQuestion.Controls.Add(btnNext);
            gbQuestion.Controls.Add(cbAnswers);
            gbQuestion.Controls.Add(btnBack);
            gbQuestion.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbQuestion.ForeColor = SystemColors.ControlText;
            gbQuestion.Location = new Point(146, 60);
            gbQuestion.Name = "gbQuestion";
            gbQuestion.Size = new Size(524, 289);
            gbQuestion.TabIndex = 9;
            gbQuestion.TabStop = false;
            gbQuestion.Text = "groupBox1";
            // 
            // lblChooseAnswer
            // 
            lblChooseAnswer.AutoSize = true;
            lblChooseAnswer.Location = new Point(95, 148);
            lblChooseAnswer.Name = "lblChooseAnswer";
            lblChooseAnswer.Size = new Size(187, 25);
            lblChooseAnswer.TabIndex = 9;
            lblChooseAnswer.Text = "Choose Your Answer:";
            // 
            // frmTakeQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(gbQuestion);
            Controls.Add(btnQuit);
            Controls.Add(btnSubmit);
            Name = "frmTakeQuiz";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmTakeQuiz";
            Load += frmTakeQuiz_Load;
            gbQuestion.ResumeLayout(false);
            gbQuestion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSubmit;
        private Button btnQuit;
        private Label lblQuestion;
        private ComboBox cbAnswers;
        private Button btnNext;
        private Button btnBack;
        private GroupBox gbQuestion;
        private Label lblChooseAnswer;
    }
}