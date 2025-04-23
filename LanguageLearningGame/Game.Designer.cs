namespace LanguageLearningGame
{
    partial class Game
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
            questionCount = new Label();
            homeButton = new Button();
            panel1 = new Panel();
            correctCount = new Label();
            answerTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            questionText = new Label();
            option1 = new Button();
            option2 = new Button();
            option3 = new Button();
            option4 = new Button();
            SubmitButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // questionCount
            // 
            questionCount.BackColor = Color.SteelBlue;
            questionCount.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            questionCount.ForeColor = SystemColors.Control;
            questionCount.Location = new Point(611, 1);
            questionCount.Name = "questionCount";
            questionCount.Size = new Size(273, 39);
            questionCount.TabIndex = 1;
            questionCount.Text = " 0 Questions Answered";
            questionCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.SteelBlue;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            homeButton.ForeColor = SystemColors.Control;
            homeButton.Location = new Point(0, 1);
            homeButton.Margin = new Padding(0);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(75, 74);
            homeButton.TabIndex = 2;
            homeButton.Text = "🏡";
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(correctCount);
            panel1.Controls.Add(questionCount);
            panel1.Controls.Add(homeButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 75);
            panel1.TabIndex = 3;
            // 
            // correctCount
            // 
            correctCount.BackColor = Color.SteelBlue;
            correctCount.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            correctCount.ForeColor = SystemColors.Control;
            correctCount.Location = new Point(611, 36);
            correctCount.Name = "correctCount";
            correctCount.Size = new Size(273, 39);
            correctCount.TabIndex = 3;
            correctCount.Text = " 0 Questions Correct";
            correctCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // answerTextBox
            // 
            answerTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            answerTextBox.Location = new Point(250, 450);
            answerTextBox.Multiline = true;
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(400, 50);
            answerTextBox.TabIndex = 4;
            answerTextBox.Text = "Type Your Answer Here...";
            answerTextBox.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SteelBlue;
            pictureBox1.Location = new Point(245, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 190);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // questionText
            // 
            questionText.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            questionText.Location = new Point(250, 190);
            questionText.Name = "questionText";
            questionText.Size = new Size(400, 180);
            questionText.TabIndex = 7;
            questionText.Text = "Question Text...";
            questionText.Click += questionText_Click;
            // 
            // option1
            // 
            option1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            option1.Location = new Point(245, 394);
            option1.Name = "option1";
            option1.Size = new Size(200, 70);
            option1.TabIndex = 9;
            option1.Text = "option1";
            option1.UseVisualStyleBackColor = true;
            option1.Click += option1_Click;
            // 
            // option2
            // 
            option2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            option2.Location = new Point(455, 394);
            option2.Name = "option2";
            option2.Size = new Size(200, 70);
            option2.TabIndex = 10;
            option2.Text = "option2";
            option2.UseVisualStyleBackColor = true;
            option2.Click += option2_Click;
            // 
            // option3
            // 
            option3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            option3.Location = new Point(245, 485);
            option3.Name = "option3";
            option3.Size = new Size(200, 70);
            option3.TabIndex = 11;
            option3.Text = "option3";
            option3.UseVisualStyleBackColor = true;
            option3.Click += option3_Click;
            // 
            // option4
            // 
            option4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            option4.Location = new Point(455, 485);
            option4.Name = "option4";
            option4.Size = new Size(200, 70);
            option4.TabIndex = 12;
            option4.Text = "option4";
            option4.UseVisualStyleBackColor = true;
            option4.Click += option4_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SubmitButton.Location = new Point(284, 595);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(332, 40);
            SubmitButton.TabIndex = 13;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 661);
            Controls.Add(SubmitButton);
            Controls.Add(option4);
            Controls.Add(option3);
            Controls.Add(option2);
            Controls.Add(option1);
            Controls.Add(questionText);
            Controls.Add(pictureBox1);
            Controls.Add(answerTextBox);
            Controls.Add(panel1);
            Name = "Game";
            FormClosing += Game_FormClosing;
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label questionCount;
        private Button homeButton;
        private Panel panel1;
        private TextBox answerTextBox;
        private PictureBox pictureBox1;
        private Label questionText;
        private Button option1;
        private Button option2;
        private Button option3;
        private Button option4;
        private Button SubmitButton;
        private Label correctCount;
    }
}