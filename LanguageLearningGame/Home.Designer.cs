namespace LanguageLearningGame
{
    partial class Home
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
            pictureBox1 = new PictureBox();
            panelNav = new Panel();
            playButton = new Button();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelNav.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.LinLo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, -74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(884, 709);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.SteelBlue;
            panelNav.Controls.Add(playButton);
            panelNav.Dock = DockStyle.Bottom;
            panelNav.Location = new Point(0, 576);
            panelNav.Margin = new Padding(1);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(884, 85);
            panelNav.TabIndex = 16;
            // 
            // playButton
            // 
            playButton.BackColor = Color.Cornsilk;
            playButton.Font = new Font("Gill Sans Ultra Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            playButton.ForeColor = Color.FromArgb(0, 40, 75);
            playButton.Location = new Point(12, 8);
            playButton.Name = "playButton";
            playButton.Size = new Size(860, 70);
            playButton.TabIndex = 2;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = false;
            playButton.Click += playButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Cornsilk;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Gill Sans Ultra Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.ForeColor = Color.FromArgb(0, 40, 75);
            exitButton.Location = new Point(824, 0);
            exitButton.Margin = new Padding(1);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(60, 60);
            exitButton.TabIndex = 17;
            exitButton.TabStop = false;
            exitButton.Text = "X";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LinLo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 661);
            Controls.Add(exitButton);
            Controls.Add(panelNav);
            Controls.Add(pictureBox1);
            Name = "Home";
            Text = "Lingua Learn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelNav.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panelNav;
        private Button playButton;
        private Button exitButton;
    }
}