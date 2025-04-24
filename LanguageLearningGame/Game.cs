using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageLearningGame
{
    public partial class Game : Form
    {
        private List<string> spanishWords = new List<string>();
        private List<string> englishWords = new List<string>();
        private Random random = new Random();
        public int setIndex;
        public string game = "";
        public string difficulty = "";
        public bool hasAnswered = false;
        public int count = 0;
        public int correct = 0;
        public string UserAnswer = "";
        public string CorrectAnswer = "";
        public Form homepage;
        public Form selectionpage;

        public Game(string gameType, string Difficulty, Form homePageInput, Form selectionPageInput)
        {
            InitializeComponent();
            game = gameType;
            difficulty = Difficulty;
            homepage = homePageInput;
            selectionpage = selectionPageInput;
        }

        private void SetupQuestion()
        {
            // Check if we have words to work with
            if (spanishWords.Count == 0 || englishWords.Count == 0)
                return;

            // Get a random word pair
            Random random = new Random();
            int setIndex = random.Next(0, spanishWords.Count);

            // Display the Spanish word as question
            questionText.Text = "What is the English translation of: " + spanishWords[setIndex];

            //set the answer
            CorrectAnswer = englishWords[setIndex];

            if (game == "MC")
            {
                // Multiple choice game - create options with nearby incorrect answers

                // Create list to hold all option indices
                List<int> optionIndices = new List<int>();

                // Add correct answer
                optionIndices.Add(setIndex);

                // Add nearby incorrect answers
                for (int i = 1; i <= 3; i++)
                {
                    int offset = i;

                    // Randomly decide if we go forward or backward in the array
                    if (random.Next(2) == 0)
                        offset = -offset;

                    // Calculate potential index
                    int potentialIndex = setIndex + offset;

                    // Make sure index is within bounds using modulo
                    // This wraps around to the beginning/end if needed
                    potentialIndex = (potentialIndex + spanishWords.Count) % spanishWords.Count;

                    // If we somehow got the same index, shift by 1
                    if (potentialIndex == setIndex)
                        potentialIndex = (potentialIndex + 1) % spanishWords.Count;

                    // Add to our options
                    optionIndices.Add(potentialIndex);
                }

                // Shuffle the option indices
                ShuffleList(optionIndices);

                // Set button texts
                option1.Text = englishWords[optionIndices[0]];
                option2.Text = englishWords[optionIndices[1]];
                option3.Text = englishWords[optionIndices[2]];
                option4.Text = englishWords[optionIndices[3]];
            }

            // Reset answer state
            hasAnswered = false;
        }

        private void ShuffleList<T>(List<T> list)
        {
            Random random = new Random();
            int n = list.Count;

            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                // Swap elements
                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }

        //USE THIS TO DECIDE THE COMPONENTS THAT APPEAR DURING THE GAME TIME
        private void Form2_Load(object sender, EventArgs e)
        {
            if (game == "FITB")
            {
                answerTextBox.Enabled = true;
                answerTextBox.Visible = true;
                answerTextBox.Focus();

                option1.Enabled = false;
                option1.Visible = false;
                option2.Enabled = false;
                option2.Visible = false;
                option3.Enabled = false;
                option3.Visible = false;
                option4.Enabled = false;
                option4.Visible = false;
            }
            else
            {
                answerTextBox.Enabled = false;
                answerTextBox.Visible = false;

                option1.Enabled = true;
                option1.Visible = true;
                option2.Enabled = true;
                option2.Visible = true;
                option3.Enabled = true;
                option3.Visible = true;
                option4.Enabled = true;
                option4.Visible = true;
            }

            string fileName = "";

            // Determine which file to load based on difficulty
            if (difficulty == "Easy")
                fileName = "easy.txt";
            else if (difficulty == "Medium")
                fileName = "medium.txt";
            else if (difficulty == "Hard")
                fileName = "hard.txt";

            StreamReader reader = new StreamReader(fileName);
            string line;

            // Read the file line by line until the end
            while ((line = reader.ReadLine()) != null)
            {
                // Split the line by the colon separator
                string[] parts = line.Split(':');
                if (parts.Length == 2)
                {
                    spanishWords.Add(parts[1].Trim());
                    englishWords.Add(parts[0].Trim());
                }
            }
            
            SetupQuestion();
            reader.Close();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            spanishWords.Clear();
            englishWords.Clear();
            homepage.Show();
            this.Hide();
        }

        private void questionText_Click(object sender, EventArgs e)
        {
            UserAnswer = answerTextBox.Text;
        }

        private void option1_Click(object sender, EventArgs e)
        {
            UserAnswer = option1.Text;
        }

        private void option2_Click(object sender, EventArgs e)
        {
            UserAnswer = option2.Text;
        }

        private void option3_Click(object sender, EventArgs e)
        {
            UserAnswer = option3.Text;
        }

        private void option4_Click(object sender, EventArgs e)
        {
            UserAnswer = option4.Text;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (UserAnswer == "Type Your Answer Here..." || UserAnswer == "")
            {
                if (game == "FITB")
                {
                    MessageBox.Show("Please Type In Your Answer");
                }
                else
                {
                    MessageBox.Show("Please Select Your Answer");
                }

            }
            else if (UserAnswer != CorrectAnswer)
            {
                MessageBox.Show("Incorrect! The correct answer was : " + CorrectAnswer);
                count++;
                questionCount.Text = count.ToString() + " Questions Answered";
                SetupQuestion();
            }
            else
            {
                MessageBox.Show("Correct! Keep Going!");
                count++;
                correct++;
                questionCount.Text = count.ToString() + " Questions Answered";
                correctCount.Text = correct.ToString() + " Questions Correct";
                SetupQuestion();
            }

        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            selectionpage.Close();
        }
    }
}
