using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LanguageLearningGame
{
    public partial class Form1 : Form
    {
        private string[] spanishWords;
        private string[] englishWords;
        private Random random = new Random();
        public int setIndex;
        //public int tempRandNum;

        public Form1()
        {
            InitializeComponent();
            ParseFile();
        }

        private void ParseFile()
        {
            string filePath = Path.Combine(Application.StartupPath, "key.txt");
            //MessageBox.Show("Looking for file at:\n" + Path.GetFullPath(filePath), "Debug Info");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Error: key.txt not found! Meow!", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void StartGameOne()
        {
            gameOneAnswerTxtBx.Enabled = true;
            gameOneAnswerTxtBx.Visible = true;
            gameOneTxtBxOne.Enabled = true;
            gameOneTxtBxOne.Visible = true;

            setIndex = GetRandomIndex();
            gameOneTxtBxOne.Text = spanishWords[setIndex];

            return;
        }

        private bool IsCorrectAnswer(int index)
        {
            if (gameOneAnswerTxtBx.Text == englishWords[index].ToString())
                return true;
            else
                return false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            playButton.Enabled = false;
            playButton.Visible = false;
            StartGameOne();
        }

        private void checkAnswerButton_Click(object sender, EventArgs e)
        {
            if (IsCorrectAnswer(setIndex))
            {
                MessageBox.Show("Correct!");
            }
            else
                MessageBox.Show("Incorrect.");
        }

    }
}