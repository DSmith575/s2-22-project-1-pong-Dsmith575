using System.Security.Cryptography.X509Certificates;

namespace Pong
{
    public class Ball
    {

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

        protected const int PADHEI = 100;
        protected const int PADWID = 10;

        protected int height;
        protected int width;

        protected Controller controller;
        protected Form1 form1;

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
            ballP.X += velocity.X;
            ballP.Y += velocity.Y;
        }

        public void BallBounce()
        {
            if (ballP.X <= 0)
            {
                BallReset();
                
            }

            if (ballP.X > width)
            {
                BallReset();
                //Player Score
            }


            //Check ball pos to top and bottom of form and bounce
            if ((ballP.Y + BALLSIZE) >= height || ballP.Y <= 0)
            {
                velocity.Y *= BOUNCE;
            }
        }


        public void PaddleBounce(Paddle paddle, CPUPaddle paddleCPU)
        {
            //Checks pos of ball and paddles and if true bounces the ball back
            if ((ballP.X <= paddleCPU.PaddleP.X + PADWID) && (ballP.X + BALLSIZE >= paddleCPU.PaddleP.X) &&
                    (ballP.Y <= paddleCPU.PaddleP.Y + PADHEI) && (ballP.Y + BALLSIZE >= paddleCPU.PaddleP.Y) ||

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
