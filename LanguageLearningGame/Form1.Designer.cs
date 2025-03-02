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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.gameOneTxtBxOne = new System.Windows.Forms.TextBox();
            this.checkAnswerButton = new System.Windows.Forms.Button();
            this.gameOneAnswerTxtBx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-15, -55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(818, 612);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exitButton.Location = new System.Drawing.Point(713, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Bye bye!";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(387, 335);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // gameOneTxtBxOne
            // 
            this.gameOneTxtBxOne.Enabled = false;
            this.gameOneTxtBxOne.Location = new System.Drawing.Point(164, 304);
            this.gameOneTxtBxOne.Name = "gameOneTxtBxOne";
            this.gameOneTxtBxOne.Size = new System.Drawing.Size(173, 23);
            this.gameOneTxtBxOne.TabIndex = 3;
            this.gameOneTxtBxOne.Visible = false;
            // 
            // checkAnswerButton
            // 
            this.checkAnswerButton.Location = new System.Drawing.Point(347, 415);
            this.checkAnswerButton.Name = "checkAnswerButton";
            this.checkAnswerButton.Size = new System.Drawing.Size(155, 23);
            this.checkAnswerButton.TabIndex = 6;
            this.checkAnswerButton.Text = "Check Answer";
            this.checkAnswerButton.UseVisualStyleBackColor = true;
            this.checkAnswerButton.Click += new System.EventHandler(this.checkAnswerButton_Click);
            // 
            // gameOneAnswerTxtBx
            // 
            this.gameOneAnswerTxtBx.Enabled = false;
            this.gameOneAnswerTxtBx.Location = new System.Drawing.Point(495, 304);
            this.gameOneAnswerTxtBx.Name = "gameOneAnswerTxtBx";
            this.gameOneAnswerTxtBx.Size = new System.Drawing.Size(164, 23);
            this.gameOneAnswerTxtBx.TabIndex = 7;
            this.gameOneAnswerTxtBx.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameOneAnswerTxtBx);
            this.Controls.Add(this.checkAnswerButton);
            this.Controls.Add(this.gameOneTxtBxOne);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button exitButton;
        private Button playButton;
        private TextBox gameOneTxtBxOne;
        private Button checkAnswerButton;
        private TextBox gameOneAnswerTxtBx;
    }
}