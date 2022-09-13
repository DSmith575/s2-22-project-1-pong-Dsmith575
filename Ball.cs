using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public class Ball
    {
        private const int SIZE = 20; //Size of the ball
        private const int VELOCITY = 40; //Speed of the ball
        private const int PADHEIGHT =20;
        private const int PADWIDTH =500;

        private Graphics graphics;
        private Brush brush;
        private Point position;
        private Point velocity;
        private int width;
        private int height;

        public Ball(Graphics graphics, Color color, Point position, int width, int height)
        {
            this.graphics = graphics;
            this.position = position;
            this.width = width;
            this.height = height;
            velocity = new Point(VELOCITY, VELOCITY);
            brush = new SolidBrush(color);
        }

        public void Move()
        {
            position.X = position.X + velocity.X;
            position.Y = position.Y + velocity.Y;
            Bounce();
        }


        public void Bounce()
        {
            if ((position.X <= 0) || (position.X + SIZE >= width))
            {
                velocity.X = velocity.X * -1;
            }

            if ((position.Y <= 0) || (position.Y + SIZE >= height))
            {
                velocity.Y = velocity.Y * -1;
            }
        }

        public void PadBounce(Paddle paddle)
        {
            if ((position.Y > paddle.PaddleP.Y) && (position.Y + SIZE <= paddle.PaddleP.Y + PADHEIGHT)
                && (position.X >= paddle.PaddleP.X) && (position.X + SIZE <= paddle.PaddleP.X + PADWIDTH))


                velocity.Y = velocity.Y * -1;
                position.X = position.X + velocity.X;
                position.Y = position.Y + velocity.Y;
            
        }
        


        public void Draw()//Draws the ball
        {
           graphics.FillEllipse(brush, position.X, position.Y, SIZE, SIZE);
        }




        public Point Velocity
        {
            get
            {
                return velocity;
            }

            set
            {
                if (velocity.X > 0)
                {
                    velocity.X = value.X;
                }
                else
                {
                    velocity.X = -value.X;
                }

                if (velocity.Y > 0)
                {
                    velocity.X = value.Y;
                }
                else
                {
                    velocity.Y = -value.Y;
                }

            }
        }
    }
}