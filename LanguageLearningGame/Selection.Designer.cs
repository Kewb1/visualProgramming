namespace LanguageLearningGame
{
    partial class Selection
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
            panel1 = new Panel();
            homeButton = new Button();
            HardButton = new Button();
            MediumButton = new Button();
            EasyButton = new Button();
            label1 = new Label();
            label2 = new Label();
            FITBButton = new Button();
            MCButton = new Button();
            label3 = new Label();
            PlayButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(homeButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 75);
            panel1.TabIndex = 4;
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
            homeButton.Size = new Size(884, 74);
            homeButton.TabIndex = 2;
            homeButton.Text = "🏡";
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // HardButton
            // 
            HardButton.BackColor = Color.Cornsilk;
            HardButton.Font = new Font("Gill Sans Ultra Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            HardButton.ForeColor = Color.FromArgb(0, 40, 75);
            HardButton.Location = new Point(114, 259);
            HardButton.Name = "HardButton";
            HardButton.Size = new Size(656, 60);
            HardButton.TabIndex = 5;
            HardButton.Text = "Hard";
            HardButton.UseVisualStyleBackColor = false;
            HardButton.Click += HardButton_Click;
            // 
            // MediumButton
            // 
            MediumButton.BackColor = Color.Cornsilk;
            MediumButton.Font = new Font("Gill Sans Ultra Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            MediumButton.ForeColor = Color.FromArgb(0, 40, 75);
            MediumButton.Location = new Point(114, 193);
            MediumButton.Name = "MediumButton";
            MediumButton.Size = new Size(656, 60);
            MediumButton.TabIndex = 6;
            MediumButton.Text = "Medium";
            MediumButton.UseVisualStyleBackColor = false;
            MediumButton.Click += MediumButton_Click;
            // 
            // EasyButton
            // 
            EasyButton.BackColor = Color.Cornsilk;
            EasyButton.Font = new Font("Gill Sans Ultra Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            EasyButton.ForeColor = Color.FromArgb(0, 40, 75);
            EasyButton.Location = new Point(114, 127);
            EasyButton.Name = "EasyButton";
            EasyButton.Size = new Size(656, 60);
            EasyButton.TabIndex = 7;
            EasyButton.Text = "Easy";
            EasyButton.UseVisualStyleBackColor = false;
            EasyButton.Click += EasyButton_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gill Sans Ultra Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(114, 78);
            label1.Name = "label1";
            label1.Size = new Size(656, 46);
            label1.TabIndex = 8;
            label1.Text = "Select A Difficulty!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gill Sans Ultra Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(114, 322);
            label2.Name = "label2";
            label2.Size = new Size(656, 46);
            label2.TabIndex = 11;
            label2.Text = "Select A Game!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FITBButton
            // 
            FITBButton.BackColor = Color.Cornsilk;
            FITBButton.Font = new Font("Gill Sans Ultra Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            FITBButton.ForeColor = Color.FromArgb(0, 40, 75);
            FITBButton.Location = new Point(114, 371);
            FITBButton.Name = "FITBButton";
            FITBButton.Size = new Size(656, 60);
            FITBButton.TabIndex = 10;
            FITBButton.Text = "Fill In The Blank";
            FITBButton.UseVisualStyleBackColor = false;
            FITBButton.Click += FITBButton_Click;
            // 
            // MCButton
            // 
            MCButton.BackColor = Color.Cornsilk;
            MCButton.Font = new Font("Gill Sans Ultra Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            MCButton.ForeColor = Color.FromArgb(0, 40, 75);
            MCButton.Location = new Point(114, 437);
            MCButton.Name = "MCButton";
            MCButton.Size = new Size(656, 60);
            MCButton.TabIndex = 9;
            MCButton.Text = "Multiple Choice";
            MCButton.UseVisualStyleBackColor = false;
            MCButton.Click += MCButton_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Gill Sans Ultra Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(114, 512);
            label3.Name = "label3";
            label3.Size = new Size(656, 57);
            label3.TabIndex = 13;
            label3.Text = "No Details Chosen Yet!";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlayButton
            // 
            PlayButton.BackColor = Color.Cornsilk;
            PlayButton.Font = new Font("Gill Sans Ultra Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            PlayButton.ForeColor = Color.FromArgb(0, 40, 75);
            PlayButton.Location = new Point(114, 561);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(656, 71);
            PlayButton.TabIndex = 12;
            PlayButton.Text = "Play";
            PlayButton.UseVisualStyleBackColor = false;
            PlayButton.Click += PlayButton_Click;
            // 
            // Selection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 661);
            Controls.Add(label3);
            Controls.Add(PlayButton);
            Controls.Add(label2);
            Controls.Add(FITBButton);
            Controls.Add(MCButton);
            Controls.Add(label1);
            Controls.Add(EasyButton);
            Controls.Add(MediumButton);
            Controls.Add(HardButton);
            Controls.Add(panel1);
            Name = "Selection";
            Text = "Lingua Learn";
            FormClosing += Selection_FormClosing;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button homeButton;
        private Button HardButton;
        private Button MediumButton;
        private Button EasyButton;
        private Label label1;
        private Label label2;
        private Button FITBButton;
        private Button MCButton;
        private Label label3;
        private Button PlayButton;
    }
}