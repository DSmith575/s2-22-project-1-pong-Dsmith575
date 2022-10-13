namespace Pong
{
    partial class Form1
    {

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
        protected void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startGame = new System.Windows.Forms.Button();
            this.resume = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.highscore = new System.Windows.Forms.Button();
            this.menuquit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pauseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startGame
            // 
            this.startGame.Location = new System.Drawing.Point(100, 75);
            this.startGame.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(246, 49);
            this.startGame.TabIndex = 0;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // resume
            // 
            this.resume.Location = new System.Drawing.Point(129, 126);
            this.resume.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(191, 29);
            this.resume.TabIndex = 1;
            this.resume.Text = "Resume";
            this.resume.UseVisualStyleBackColor = true;
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(455, 128);
            this.quit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(191, 29);
            this.quit.TabIndex = 2;
            this.quit.Text = "Main Menu";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // highscore
            // 
            this.highscore.Location = new System.Drawing.Point(351, 90);
            this.highscore.Name = "highscore";
            this.highscore.Size = new System.Drawing.Size(75, 23);
            this.highscore.TabIndex = 3;
            this.highscore.Text = "Highscores";
            this.highscore.UseVisualStyleBackColor = true;
            // 
            // menuquit
            // 
            this.menuquit.Location = new System.Drawing.Point(432, 75);
            this.menuquit.Name = "menuquit";
            this.menuquit.Size = new System.Drawing.Size(246, 49);
            this.menuquit.TabIndex = 4;
            this.menuquit.Text = "Quit Game";
            this.menuquit.UseVisualStyleBackColor = true;
            this.menuquit.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(537, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // pauseLabel
            // 
            this.pauseLabel.AutoSize = true;
            this.pauseLabel.Location = new System.Drawing.Point(375, -1);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Size = new System.Drawing.Size(51, 15);
            this.pauseLabel.TabIndex = 7;
            this.pauseLabel.Text = "P: Pause";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 161);
            this.Controls.Add(this.pauseLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuquit);
            this.Controls.Add(this.highscore);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.resume);
            this.Controls.Add(this.startGame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Timer timer1;
        protected Button startGame;
        protected Button resume;
        protected Button quit;
        protected Button highscore;
        protected Button menuquit;
        private System.ComponentModel.IContainer components;
        private Label pauseLabel;
        public Label label1;
        public Label label2;
    }
}