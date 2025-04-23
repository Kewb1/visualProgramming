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
            playButton.Location = new Point(183, 215);
            playButton.Name = "playButton";
            playButton.Size = new Size(75, 23);
            playButton.TabIndex = 2;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // checkAnswerButton
            // 
            checkAnswerButton.Location = new Point(347, 415);
            checkAnswerButton.Name = "checkAnswerButton";
            checkAnswerButton.Size = new Size(155, 23);
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
            panelNav.Margin = new Padding(1);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(44, 592);
            panelNav.TabIndex = 9;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(3, 252);
            exitButton.Margin = new Padding(1);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(40, 22);
            exitButton.TabIndex = 13;
            exitButton.TabStop = false;
            exitButton.Text = "exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(3, 219);
            settingsButton.Margin = new Padding(1);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(41, 21);
            settingsButton.TabIndex = 12;
            settingsButton.Text = "button6";
            settingsButton.UseVisualStyleBackColor = true;
            // 
            // gameSelectButton
            // 
            gameSelectButton.Location = new Point(3, 92);
            gameSelectButton.Margin = new Padding(1);
            gameSelectButton.Name = "gameSelectButton";
            gameSelectButton.Size = new Size(41, 70);
            gameSelectButton.TabIndex = 10;
            gameSelectButton.Text = "Select Game";
            gameSelectButton.UseVisualStyleBackColor = true;
            gameSelectButton.Click += gameSelectButton_Click;
            // 
            // progressButton
            // 
            progressButton.Location = new Point(1, 57);
            progressButton.Margin = new Padding(1);
            progressButton.Name = "progressButton";
            progressButton.Size = new Size(43, 20);
            progressButton.TabIndex = 1;
            progressButton.Text = "button2";
            progressButton.UseVisualStyleBackColor = true;
            progressButton.Click += progressButton_Click;
            // 
            // homeButton
            // 
            homeButton.AllowDrop = true;
            homeButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            homeButton.Location = new Point(3, 20);
            homeButton.Margin = new Padding(1);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(39, 24);
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
            panelContent.Location = new Point(44, 0);
            panelContent.Margin = new Padding(1);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(852, 592);
            panelContent.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(42, 173);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(522, 23);
            label1.TabIndex = 4;
            label1.Text = "Bienvenidos! Start your Spanish journey today.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(145, 57);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(384, 271);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 592);
            Controls.Add(panelContent);
            Controls.Add(panelNav);
            Controls.Add(checkAnswerButton);
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
        private Button progressButton;
       
        private Button exitButton;
        private Button settingsButton;
        private Panel panelContent;
        private Label label1;
        private PictureBox pictureBox1;
        public Button homeButton;
    }
}