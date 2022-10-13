/* 
 * Known bugs: 
 * Ball sometimes get stuck when hitting the paddles from the bottom, fixes itself when paddle no longer it's position.
 * When the ball is black it has a flicker, assuming it is due to the Rectangle brush being black
 *
 *Could not properly call PADWID/PADHEI from paddles for the ball class (using vars in each class instead of calling, get sets were not working
 *might have been doing them wrong)
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
        protected int height;
        protected int width;

        protected Ball ball;
        protected Paddle paddle;
        protected CPUPaddle paddleCPU;
        protected Scores score;



        public Form1()
        {
            InitializeComponent();


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
            //label1.Text = score.LabelOne;
            //label2.Text = score.LabelTwo;


        }




        protected void timer1_Tick(object sender, EventArgs e)
        {
            bufferGraphics.FillRectangle(Brushes.White, 0, 0, Width, Height);

            controller.Run();

            graphics.DrawImage(bufferImage, 0, 0);


        }

        protected void startGame_Click(object sender, EventArgs e)
        {
            //Starts Game
            controller.Start();
            timerStart();
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
            resumeGame();
            Focus();
        }

        protected void quit_Click(object sender, EventArgs e)
        {
            menuReturn();

        }

        protected void button2_Click(object sender, EventArgs e)
        {
           Environment.Exit(0);
        }

        public void timerStart()
        {
            timer1.Enabled = true;
            startGame.Visible = false;
            quit.Visible = false;
            menuquit.Visible = false;
            highscore.Visible = false;
            label1.Visible = true;
            label2.Visible = true;

        }

        public void resumeGame()
        {
            timer1.Enabled = true;
            resume.Visible = false;
            quit.Visible = false;
        }

        public void menuReturn()
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



    }
}
