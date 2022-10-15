/* Program name:          Pong
 * Project file name:     Pong
 * Author:                Deacon Smith
 * Date:                  05/09/17
 * Language:              C#
 * Platform:              Microsoft Visual Studio 2022
 *
 * Purpose:               Recreating the game pong for Programming 2 assessment 1.
 *
 * Description:           Ball will move around the screen and bounce from the top and bottom of the form, the player (left) and a computer controlled paddle (right)
 *                        will move their paddles to stop the ball from entering their side of the screen.
 *                        Each time the ball hits the left or right side of the screen, the player or computer is given a point, first to reach 10 points wins and the game stops.
 *  
 *                        Player paddle is controlled by the 'UP' and 'DOWN' keys, they can be pressed or held down to move. 
 *                        The computer paddle is controlled by a switch statement and bools to make it's movements
 *                         
 *                     
 * Known bugs:            Ball sometimes get stuck when hitting the paddles from the bottom, fixes itself when paddle no longer it's position.
 *                        When the ball is black it has a flicker, assuming it is due to the Rectangle brush being black
 *                        
 *                        
 *  
 * Additional features:   Sounds effects (Paddle bounce, user win, cpu wins.
 *                        Simple scoring system
 *                        High score system
 */

using System.Media;
using System.Net.Sockets;
using System.Security.Cryptography;

namespace Pong
{
    public partial class Form1 : Form
    {
        protected Graphics bufferGraphics;
        protected Graphics graphics;
        protected Controller controller;
        protected Image bufferImage;
        protected Ball ball;
        protected Paddle paddle;
        protected CPUPaddle paddleCPU;
        protected Scores score;
        protected int height;
        protected int width;


        public Form1()
        {
            InitializeComponent();
            FormLoader();
        }

        public void FormLoader()
        {
            bufferImage = new Bitmap(Width, Height);
            bufferGraphics = Graphics.FromImage(bufferImage);
            graphics = CreateGraphics();
            width = ClientSize.Width;
            height = ClientSize.Height;
            resume.Visible = false;
            quit.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            controller = new Controller(bufferGraphics, width, height, ball, paddle, paddleCPU, timer1, label1, label2);

        }

        public void TimerStart()
        {
            timer1.Enabled = true;
            startGame.Visible = false;
            quit.Visible = false;
            menuquit.Visible = false;
            highscore.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
        }

        public void ResumeGame()
        {
            timer1.Enabled = true;
            resume.Visible = false;
            quit.Visible = false;
        }

        public void MenuReturn()
        {
            timer1.Enabled = false;
            resume.Visible = false;
            quit.Visible = false;
            startGame.Visible = true;
            menuquit.Visible = true;
            highscore.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            this.Refresh();
        }

        protected void timer1_Tick(object sender, EventArgs e)
        {
            //Run game
            bufferGraphics.FillRectangle(Brushes.White, 0, 0, Width, Height);
            controller.Run();
            graphics.DrawImage(bufferImage, 0, 0);
        }

        protected void startGame_Click(object sender, EventArgs e)
        {
            //Starts Game
            controller.Start();
            TimerStart();
            Focus();
        }

        protected void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //MoveUp
                case Keys.Up:
                    controller.PlayerMoveUp();
                    break;

                //MoveDown
                case Keys.Down:
                    controller.PlayerMoveDown();
                    break;

                //Pause Game
                case Keys.P:
                    timer1.Enabled = false;
                    resume.Visible = true;
                    quit.Visible = true;          
                    break;

                default:
                    break;
            }
        }

        protected void resume_Click(object sender, EventArgs e)
        {
            ResumeGame();
            Focus();
        }

        protected void quit_Click(object sender, EventArgs e)
        {
            MenuReturn();
        }

        protected void button2_Click(object sender, EventArgs e)
        {
           Environment.Exit(0);
        }
    }
}
