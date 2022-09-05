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
        private const int BALLPOSX = 120;
        private const int BALLPOSY = 75;


        private List<Ball> balls;

        public Controller(Graphics graphics, int width, int height)
        {

            //Creates a list of "Ball" and adds a new ball with it's properties
            balls = new List<Ball>();
            balls.Add(new Ball(graphics, Color.Red, new Point(BALLPOSX, BALLPOSY), width, height));
        }

        public void Run()
        {
            foreach (Ball ball in balls)
            {
                ball.Move();
                ball.Draw();
            }
        }

        public void ChangeVelocity(int index, int velocity)
        {
            balls[index].Velocity = new Point(velocity, velocity);
        }
    }
}