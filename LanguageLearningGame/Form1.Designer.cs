namespace LanguageLearningGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            playButton = new Button();
            checkAnswerButton = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panelNav = new Panel();
            exitButton = new Button();
            settingsButton = new Button();
            gameSelectButton = new Button();
            progressButton = new Button();
            homeButton = new Button();
            panelContent = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelNav.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // playButton
            // 
            playButton.Location = new Point(393, 545);
            playButton.Margin = new Padding(6, 8, 6, 8);
            playButton.Name = "playButton";
            playButton.Size = new Size(161, 58);
            playButton.TabIndex = 2;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // checkAnswerButton
            // 
            checkAnswerButton.Location = new Point(744, 1051);
            checkAnswerButton.Margin = new Padding(6, 8, 6, 8);
            checkAnswerButton.Name = "checkAnswerButton";
            checkAnswerButton.Size = new Size(332, 58);
            checkAnswerButton.TabIndex = 6;
            checkAnswerButton.Text = "Check Answer";
            checkAnswerButton.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panelNav
            // 
            panelNav.BackColor = SystemColors.ScrollBar;
            panelNav.Controls.Add(exitButton);
            panelNav.Controls.Add(settingsButton);
            panelNav.Controls.Add(gameSelectButton);
            panelNav.Controls.Add(progressButton);
            panelNav.Controls.Add(homeButton);
            panelNav.Dock = DockStyle.Left;
            panelNav.Location = new Point(0, 0);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(94, 753);
            panelNav.TabIndex = 9;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(7, 638);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(62, 43);
            exitButton.TabIndex = 13;
            exitButton.TabStop = false;
            exitButton.Text = "exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(7, 555);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(62, 43);
            settingsButton.TabIndex = 12;
            settingsButton.Text = "button6";
            settingsButton.UseVisualStyleBackColor = true;
            // 
            // gameSelectButton
            // 
            gameSelectButton.Location = new Point(7, 233);
            gameSelectButton.Name = "gameSelectButton";
            gameSelectButton.Size = new Size(62, 43);
            gameSelectButton.TabIndex = 10;
            gameSelectButton.Text = "button3";
            gameSelectButton.UseVisualStyleBackColor = true;
            gameSelectButton.Click += gameSelectButton_Click;
            // 
            // progressButton
            // 
            progressButton.Location = new Point(3, 144);
            progressButton.Name = "progressButton";
            progressButton.Size = new Size(62, 43);
            progressButton.TabIndex = 1;
            progressButton.Text = "button2";
            progressButton.UseVisualStyleBackColor = true;
            progressButton.Click += progressButton_Click;
            // 
            // homeButton
            // 
            homeButton.AllowDrop = true;
            homeButton.Location = new Point(12, 57);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(53, 43);
            homeButton.TabIndex = 0;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click_1;
            // 
            // panelContent
            // 
            panelContent.BorderStyle = BorderStyle.Fixed3D;
            panelContent.Controls.Add(label1);
            panelContent.Controls.Add(pictureBox1);
            panelContent.Controls.Add(playButton);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(94, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1024, 753);
            panelContent.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(91, 439);
            label1.Name = "label1";
            label1.Size = new Size(765, 34);
            label1.TabIndex = 4;
            label1.Text = "Bienvenidos! Start your Spanish journey today.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(310, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(384, 271);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 753);
            Controls.Add(panelContent);
            Controls.Add(panelNav);
            Controls.Add(checkAnswerButton);
            Margin = new Padding(6, 8, 6, 8);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelNav.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button playButton;
        private Button checkAnswerButton;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panelNav;
        private Button gameSelectButton;
        private Button progressButton;
       
        private Button exitButton;
        private Button settingsButton;
        private Panel panelContent;
        private Label label1;
        private PictureBox pictureBox1;
        public Button homeButton;
    }
}