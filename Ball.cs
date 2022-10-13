using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;

namespace Pong
{
    public class Ball
    {
        protected const int PADHEI = 100;
        protected const int PADWID = 10;
        protected const int BALLSIZE = 20;
        protected const int VELOCITY = 10;
        protected const int BOUNCE = -1;
        //Used to reset balls pos
        protected const int BALLPOSX = 500;
        protected const int BALLPOSY = 200;

        protected Graphics graphics;
        protected Point ballP;
        protected Point velocity;
        protected Color color;

        protected int playerScore;
        protected int cpuScore;

        protected int height;
        protected int width;

        protected Scores scores = new Scores();


        public Ball(Graphics graphics, Point ballP, Color color, int width, int height)
        {
            this.graphics = graphics;
            this.ballP = ballP;
            this.color = color;
            velocity = new Point(VELOCITY, VELOCITY);
            this.width = width;
            this.height = height;

        }

        public Point BallP
        {
            get 
            { return ballP; }
        }



        public void DrawBall()
        {
            Brush brush = new SolidBrush(color);
            graphics.FillEllipse(brush, ballP.X, ballP.Y, BALLSIZE, BALLSIZE);
        }

        public void MoveBall()
        {
            //Moves the Ball
            ballP.X += velocity.X;
            ballP.Y += velocity.Y;
        }


        public int BouncePlayerSide(int pScore)
        {
            if (ballP.X <= 0)
            {
                //Checks if ball is < left side of screen
                BallReset();
                pScore++;

            }
            return pScore;
        }

        public int BounceCpuSide(int cScore)
        {
            if (ballP.X > width)
            {
                //Checks if ball > right side of screen and resets

                BallReset();
                cScore++;

            }
            return cScore;
        }

        public void FormBounce()
        {
            if ((ballP.Y + BALLSIZE) >= height || ballP.Y <= 0)
            {
                velocity.Y *= BOUNCE;
            }
        }




        public void PaddleBounce(Paddle paddle, CPUPaddle paddleCPU)
        {
            //Checks pos of ball and paddles and if true bounces the ball back
            if ((ballP.X <= paddleCPU.PaddleP.X + PADWID) && (ballP.X + BALLSIZE >= paddleCPU.PaddleP.X) &&
                    (ballP.Y <= paddleCPU.PaddleP.Y + PADHEI) && (ballP.Y + BALLSIZE >= paddleCPU.PaddleP.Y)
                    ||
                    ((ballP.X <= paddle.PaddleP.X + PADWID) && (ballP.X + BALLSIZE >= paddle.PaddleP.X) &&
                    (ballP.Y <= paddle.PaddleP.Y + PADHEI) && (ballP.Y + BALLSIZE >= paddle.PaddleP.Y)))
            {
                VelocityShift();
                

            }
        }
        //Changes Balls Velocity when hitting paddle
        public void VelocityShift()
        {
            velocity.Y *= BOUNCE;
            velocity.X *= BOUNCE;
            
        }

        //Resets balls X & Y POS
        public void BallReset()
        {
            ballP.X = BALLPOSX;
            ballP.Y = BALLPOSY;
            velocity.X *= BOUNCE;
        }


    }
}
