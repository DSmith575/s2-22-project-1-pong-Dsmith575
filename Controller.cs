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

        private Graphics graphics;
        private Ball ball;



        public Controller(Graphics graphics, int width, int height)
        {
            this.graphics = graphics;

            ball = new Ball(graphics, Color.Black, new Point(BALLPOSX, BALLPOSY), width, height);
        }

        //Move ball around form
        private void BallBounce()
        {
            ball.Draw();
            ball.Move();
           
        }


        //Runs on every timer1 tick
        public void Run()
        {
            BallBounce();
            
        }

        public void ChangeVelocity(int index, int velocity)
        {
            ball.Velocity = new Point(velocity, velocity);
        }
    }
}