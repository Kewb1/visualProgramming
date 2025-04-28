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
        // form/page var
        public Form homepage;

        // game selection vars
        private string GameType = "None";
        private string Difficulty = "None";

        public Selection(Form homepageInput)
        {
            InitializeComponent();

            //  Initialize form/page var
            homepage = homepageInput;
        }

        private void EasyButton_Click(object sender, EventArgs e)
        {
            // change difficulty
            Difficulty = "Easy";
        }

        private void MediumButton_Click(object sender, EventArgs e)
        {
            // change difficulty
            Difficulty = "Medium";
        }

        private void HardButton_Click(object sender, EventArgs e)
        {
            // change difficulty
            Difficulty = "Hard";
        }

        private void FITBButton_Click(object sender, EventArgs e)
        {
            // change game type
            GameType = "FITB";
        }

        private void MCButton_Click(object sender, EventArgs e)
        {
            // change game type
            GameType = "MC";
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            // if user hasnt selected enough options, display error, else start game
            if (GameType == "None" || Difficulty == "None")
            {
                label3.Text = "Choose a Difficulty and Game!";
            }
            else
            {
                // create game instance, and pass game type, difficulty, homepage and selection page
                Game Game = new Game(GameType, Difficulty, homepage, this);

                // open the game
                Game.Show();

                // hide this page
                this.Hide();
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            // show the homepage
            homepage.Show();

            // hide this
            this.Hide();
        }

        private void Selection_FormClosing(object sender, FormClosingEventArgs e)
        {
            // close this page
            homepage.Close();
        }
    }
}
