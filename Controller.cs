using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public class Controller
    {

        //Sets the initial position for each ball
        private const int BALLPOSX = 825;
        private const int BALLPOSY = 440;
        private const int PADPOSX = 0;
        private const int PADPOSY = 200;

        private Graphics graphics;
        private Ball ball;
        private Paddle paddle;

        private int width;
        private int height;


        public Controller(Graphics graphics, int width, int height)
        {
            this.graphics = graphics;
            this.width = width;
            this.height = height;

        }

        //Runs on every timer1 tick
        public void Run()
        {
            paddle.Draw();
            BallMove();
            ball.PadBounce(paddle);

        }




        //Move ball around form
        private void BallMove()
        {
            ball.Draw();
            ball.Move();
           
        }

        //private void PlayerMove()
        //{
        //    paddle.Move();
        //}




        public void Start()
        {
            ball = new Ball(graphics, Color.Black, new Point(BALLPOSX, BALLPOSY), width, height);
            paddle = new Paddle(graphics, Color.Black, new Point(PADPOSX, PADPOSY));
        }

        public void ChangeVelocity(int index, int velocity)
        {
            ball.Velocity = new Point(velocity, velocity);
        }
    }
}