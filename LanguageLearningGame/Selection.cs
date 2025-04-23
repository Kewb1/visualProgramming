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
    public partial class Selection : Form
    {
        public Form homepage;
        public Selection(Form homepageInput)
        {
            InitializeComponent();
            homepage = homepageInput;
        }

        private string GameType = "None";
        private string Difficulty = "None";

        private void EasyButton_Click(object sender, EventArgs e)
        {
            Difficulty = "Easy";
        }

        private void MediumButton_Click(object sender, EventArgs e)
        {
            Difficulty = "Medium";
        }

        private void HardButton_Click(object sender, EventArgs e)
        {
            Difficulty = "Hard";
        }

        private void FITBButton_Click(object sender, EventArgs e)
        {
            GameType = "FITB";
        }

        private void MCButton_Click(object sender, EventArgs e)
        {
            GameType = "MC";
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {

            if (GameType == "None" || Difficulty == "None")
            {
                label3.Text = "Choose a Difficulty and Game!";
            }
            else
            {
                Game Game = new Game(GameType, Difficulty, homepage, this);
                Game.Show();
                this.Hide();
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            homepage.Show();
            this.Hide();
        }

        private void Selection_FormClosing(object sender, FormClosingEventArgs e)
        {
            homepage.Close();
        }
    }
}
