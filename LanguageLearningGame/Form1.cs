using System;
using System.IO;
using System.Linq;

using System.Windows.Forms;

namespace LanguageLearningGame
{
    public partial class Form1 : Form
    {
        private string[] spanishWords = Array.Empty<string>();
        private string[] englishWords = Array.Empty<string>();
        private Random random = new Random();
        public int setIndex;

        public Form1()
        {
            InitializeComponent();
            ParseFile();
        }

        // Load the key.txt file and populate Spanish/English arrays
        private void ParseFile()
        {
            string filePath = Path.Combine(Application.StartupPath, "key.txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Error: key.txt not found!", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            spanishWords = new string[lines.Length];
            englishWords = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
                if (parts.Length == 2)
                {
                    spanishWords[i] = parts[0].Trim();
                    englishWords[i] = parts[1].Trim();
                }
            }
        }

        private int GetRandomIndex()
        {
            return random.Next(0, spanishWords.Length);
        }

        // MAIN NAVIGATION BUTTONS



        private void progressButton_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            ProgressBar progressBar = new ProgressBar
            {
                Value = 50, // Dummy value, replace with actual logic
                Location = new System.Drawing.Point(150, 200),
                Width = 300
            };
            panelContent.Controls.Add(progressBar);
        }

        private void gameSelectButton_Click(object sender, EventArgs e)
        {
            ShowGameSelection();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Label settingsLabel = new Label
            {
                Text = "Settings - Coming Soon!",
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(150, 200)
            };
            panelContent.Controls.Add(settingsLabel);
        }



        // PLAY BUTTON
        private void playButton_Click(object sender, EventArgs e)
        {
            playButton.Visible = false;
            ShowGameSelection();
        }

        // GAME SELECTION SCREEN
        private void ShowGameSelection()
        {
            panelContent.Controls.Clear();

            Button fillBlankBtn = new Button
            {
                Text = "Fill in the Blank",
                Location = new System.Drawing.Point(150, 150),
                Width = 150
            };
            fillBlankBtn.Click += (s, ev) => StartGameOne();

            Button flashCardBtn = new Button
            {
                Text = "Flash Card",
                Location = new System.Drawing.Point(150, 200),
                Width = 150
            };
            flashCardBtn.Click += (s, ev) => StartFlashCardGame();

            Button multiChoiceBtn = new Button
            {
                Text = "Multiple Choice",
                Location = new System.Drawing.Point(150, 250),
                Width = 150
            };
            multiChoiceBtn.Click += (s, ev) => StartMultipleChoiceGame();

            panelContent.Controls.Add(fillBlankBtn);
            panelContent.Controls.Add(flashCardBtn);
            panelContent.Controls.Add(multiChoiceBtn);
        }

        // GAME ONE - Fill in the Blank
        private void StartGameOne()
        {
            panelContent.Controls.Clear();

            setIndex = GetRandomIndex();

            Label spanishLabel = new Label
            {
                Text = spanishWords[setIndex],
                Location = new System.Drawing.Point(150, 100),
                Font = new System.Drawing.Font("Segoe UI", 12F),
                AutoSize = true
            };

            TextBox answerBox = new TextBox
            {
                Name = "gameOneAnswerTxtBx",
                Location = new System.Drawing.Point(150, 150),
                Width = 200
            };

            Button checkAnswerBtn = new Button
            {
                Text = "Check Answer",
                Location = new System.Drawing.Point(150, 200)
            };
            checkAnswerBtn.Click += (s, e) =>
            {
                string userInput = answerBox.Text.Trim();
                if (userInput.Equals(englishWords[setIndex], StringComparison.OrdinalIgnoreCase))
                    MessageBox.Show("Correct!");
                else
                    MessageBox.Show($"Incorrect. Correct answer: {englishWords[setIndex]}");
            };

            panelContent.Controls.Add(spanishLabel);
            panelContent.Controls.Add(answerBox);
            panelContent.Controls.Add(checkAnswerBtn);
        }

        // GAME TWO - Flash Card
        private void StartFlashCardGame()
        {
            panelContent.Controls.Clear();
            // TODO: Implement Flash Card game logic

            //get a random word pair
            setIndex = GetRandomIndex();

            Label spanishLabel = new Label
            {
                Text = spanishWords[setIndex],
                Location = new System.Drawing.Point(150, 100),
                Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold),
                AutoSize = true
            };

            Label englishLabel = new Label
            {
                Text = "???", //hidden initially
                Location = new System.Drawing.Point(150, 150),
                Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular),
                AutoSize = true
            };

            Button showAnswerBtn = new Button
            {
                Text = "Show Answer",
                Location = new System.Drawing.Point(150, 200),
                Width = 120
            };

            showAnswerBtn.Click += (s, e) =>
            {
                englishLabel.Text = englishWords[setIndex];
            };

            Button nextCardBtn = new Button
            {
                Text = "Next Card",
                Location = new System.Drawing.Point(280, 200),
                Width = 100
            };

            nextCardBtn.Click += (s, e) =>
            {
                StartFlashCardGame(); // Reload this method for the next flashcard
            };

            panelContent.Controls.Add(spanishLabel);
            panelContent.Controls.Add(englishLabel);
            panelContent.Controls.Add(showAnswerBtn);
            panelContent.Controls.Add(nextCardBtn);
        }

        // GAME THREE - Multiple Choice
        private void StartMultipleChoiceGame()
        {
            panelContent.Controls.Clear();
            // TODO: Implement Multiple Choice game logic
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: show welcome screen on load
        }

        private void homeButton_Click_1(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Label welcomeLabel = new Label
            {
                Text = "Bienvenidos! Start your Spanish journey today.",
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic),
                Location = new System.Drawing.Point(150, 200)
            };
            panelContent.Controls.Add(welcomeLabel);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
