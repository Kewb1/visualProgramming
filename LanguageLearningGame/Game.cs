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
        // translation vars
        private List<string> spanishWords = new List<string>();
        private List<string> englishWords = new List<string>();

        // random var
        private Random random = new Random();

        // game mechanic vars
        public int setIndex;
        public string game = "";
        public string difficulty = "";
        public bool hasAnswered = false;
        public int count = 0;
        public int correct = 0;
        public string UserAnswer = "";
        public string CorrectAnswer = "";

        // form vars
        public Form homepage;
        public Form selectionpage;

        public Game(string gameType, string Difficulty, Form homePageInput, Form selectionPageInput)
        {
            InitializeComponent();

            // Initialize game type, difficulty, and form/page vars
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
            // set up game depending on game type
            if (game == "FITB")
            {
                //enable and show option text box
                answerTextBox.Enabled = true;
                answerTextBox.Visible = true;

                // focus on the text box
                answerTextBox.Focus();

                // disable and hide option buttons
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
                // disable and hide text box
                answerTextBox.Enabled = false;
                answerTextBox.Visible = false;

                // enable and show option buttons
                option1.Enabled = true;
                option1.Visible = true;
                option2.Enabled = true;
                option2.Visible = true;
                option3.Enabled = true;
                option3.Visible = true;
                option4.Enabled = true;
                option4.Visible = true;
            }

            // filename var
            string fileName = "";

            // Determine which file to load based on difficulty
            if (difficulty == "Easy")
                fileName = "easy.txt";
            else if (difficulty == "Medium")
                fileName = "medium.txt";
            else if (difficulty == "Hard")
                fileName = "hard.txt";

            // set up stream reader
            StreamReader reader = new StreamReader(fileName);

            // variable to hold the lin eof text
            string line;

            // Read the file line by line until the end
            while ((line = reader.ReadLine()) != null)
            {
                // Split the line by the colon separator
                string[] parts = line.Split(':');

                //put english and spanish word from text into the array
                if (parts.Length == 2)
                {
                    spanishWords.Add(parts[1].Trim());
                    englishWords.Add(parts[0].Trim());
                }
            }

            // shuffle for a new question
            SetupQuestion();

            // close the file
            reader.Close();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            //clear arrays
            spanishWords.Clear();
            englishWords.Clear();

            // show the home page
            homepage.Show();

            // hide this page
            this.Hide();
        }

        private void questionText_Click(object sender, EventArgs e)
        {
            // change user answer
            UserAnswer = answerTextBox.Text;
        }

        private void option1_Click(object sender, EventArgs e)
        {
            // change user answer
            UserAnswer = option1.Text;
        }

        private void option2_Click(object sender, EventArgs e)
        {
            // change user answer
            UserAnswer = option2.Text;
        }

        private void option3_Click(object sender, EventArgs e)
        {
            // change user answer
            UserAnswer = option3.Text;
        }

        private void option4_Click(object sender, EventArgs e)
        {
            // change user answer
            UserAnswer = option4.Text;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // display a error if the user hasnt put in an answer, else handle answer 
            if (UserAnswer == "Type Your Answer Here..." || UserAnswer == "")
            {

                // display different error message based on game type
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
                // display the message 
                MessageBox.Show("Incorrect! The correct answer was : " + CorrectAnswer);

                // increment 
                count++;

                // set question counter text
                questionCount.Text = count.ToString() + " Questions Answered";

                // shuffle again for new question
                SetupQuestion();
            }
            else
            {
                // display the message 
                MessageBox.Show("Correct! Keep Going!");

                // increment
                count++;
                correct++;

                // set both question counter texts
                questionCount.Text = count.ToString() + " Questions Answered";
                correctCount.Text = correct.ToString() + " Questions Correct";

                // shuffle again for new question
                SetupQuestion();
            }

        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            // close selection page when this page is closing
            selectionpage.Close();
        }

        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {
            // set the use answer to the text in the answer text box
            UserAnswer= answerTextBox.Text;
        }
    }
}
