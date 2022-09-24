using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public class Ball
    {

        private const int BALLSIZE = 30; 
        private const int VELOCITY = 20; 
        private const int BOUNCE = -1;

        private Random rand;


        //Used to reset balls pos
        private const int BALLPOSX = 690;
        private const int BALLPOSY = 475;


        private const int PADHEI = 250;
        private const int PADWID = 20;


        private Graphics graphics;
        private Point ballP;
        private Point velocity;
        private Color color;
        private Brush brush;

        private int height;
        private int width;


        public Ball(Graphics graphics, Point ballP, Color color, int width, int height)
        {
            this.graphics = graphics;
            this.ballP = ballP;
            this.color = color;
            velocity = new Point(VELOCITY, VELOCITY);
            this.width = width;
            this.height = height;


            brush = new SolidBrush(color);
        }

        public Point BallP
        {
            get { return ballP; }
        }

        public void DrawBall()
        {
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
                //CPU Score
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
            ballP.X += velocity.X;
            ballP.Y += velocity.Y;

        }

        //Resets balls X & Y POS
        public void BallReset()
        {
            rand = new Random();

            ballP.X = BALLPOSX;
            ballP.Y = BALLPOSY;
            velocity.X *= BOUNCE;
        }

    }
    }
