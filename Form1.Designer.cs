namespace Pong
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startGame = new System.Windows.Forms.Button();
            this.resume = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startGame
            // 
            this.startGame.Location = new System.Drawing.Point(356, 52);
            this.startGame.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(268, 73);
            this.startGame.TabIndex = 0;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // resume
            // 
            this.resume.Location = new System.Drawing.Point(390, 208);
            this.resume.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(268, 29);
            this.resume.TabIndex = 1;
            this.resume.Text = "Resume";
            this.resume.UseVisualStyleBackColor = true;
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(304, 266);
            this.quit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(268, 29);
            this.quit.TabIndex = 2;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 411);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.resume);
            this.Controls.Add(this.startGame);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button startGame;
        private Button resume;
        private Button quit;
    }
}