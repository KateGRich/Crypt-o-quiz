namespace PresentationLayer
{
    partial class frmCryptidQuiz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCryptidQuiz));
            btnViewQuizzes = new Button();
            lblWelcome = new Label();
            picWolf = new PictureBox();
            picSkinwalker = new PictureBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)picWolf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSkinwalker).BeginInit();
            SuspendLayout();
            // 
            // btnViewQuizzes
            // 
            btnViewQuizzes.Font = new Font("Yu Gothic UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewQuizzes.Location = new Point(337, 174);
            btnViewQuizzes.Name = "btnViewQuizzes";
            btnViewQuizzes.Size = new Size(181, 87);
            btnViewQuizzes.TabIndex = 0;
            btnViewQuizzes.Text = "View Quizzes";
            btnViewQuizzes.UseVisualStyleBackColor = true;
            btnViewQuizzes.Click += btnViewQuizzes_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Berkshire Swash", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.ControlLightLight;
            lblWelcome.Location = new Point(176, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(501, 74);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome to Crypt-o-Quiz!";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picWolf
            // 
            picWolf.Image = (Image)resources.GetObject("picWolf.Image");
            picWolf.Location = new Point(26, 102);
            picWolf.Name = "picWolf";
            picWolf.Size = new Size(260, 345);
            picWolf.SizeMode = PictureBoxSizeMode.StretchImage;
            picWolf.TabIndex = 2;
            picWolf.TabStop = false;
            // 
            // picSkinwalker
            // 
            picSkinwalker.Image = (Image)resources.GetObject("picSkinwalker.Image");
            picSkinwalker.Location = new Point(572, 102);
            picSkinwalker.Name = "picSkinwalker";
            picSkinwalker.Size = new Size(260, 345);
            picSkinwalker.SizeMode = PictureBoxSizeMode.StretchImage;
            picSkinwalker.TabIndex = 3;
            picSkinwalker.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Yu Gothic UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(337, 309);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(181, 87);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmCryptidQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(856, 494);
            Controls.Add(btnExit);
            Controls.Add(picSkinwalker);
            Controls.Add(picWolf);
            Controls.Add(lblWelcome);
            Controls.Add(btnViewQuizzes);
            ForeColor = SystemColors.ControlText;
            Name = "frmCryptidQuiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crypt-o-Quiz";
            ((System.ComponentModel.ISupportInitialize)picWolf).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSkinwalker).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewQuizzes;
        private Label lblWelcome;
        private PictureBox picWolf;
        private PictureBox picSkinwalker;
        private Button btnExit;
    }
}
