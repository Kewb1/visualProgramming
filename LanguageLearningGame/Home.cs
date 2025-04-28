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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close when exit button is pressed
            this.Close();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            // create selection page, and pass home page
            Selection Selection = new Selection(this);

            // open selection page
            Selection.Show();

            // hide this page
            this.Hide();
        }
    }
}
