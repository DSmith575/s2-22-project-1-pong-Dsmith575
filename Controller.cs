using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{

    public class Controller
    {
        private const int BALLPOSX = 690;
        private const int BALLPOSY = 475;

        private const int PLAYPADX = 0;
        private const int PLAYPADY = 300;
        private const int CPUPADX = 1330;
        private const int CPUPADY = 200;


        private Graphics graphics;

        private int width;
        private int height;
        private Random rand;

        private Ball ball;
        private Paddle paddle;
        private CPUPaddle paddleCPU;

        private bool playerUp;
        private bool playerDown;



        public Controller(Graphics graphics, int width, int height)
        {
            this.graphics = graphics;
            this.width = width;
            this.height = height;
        }


        public void Run()
        {
            BallMove();
            ball.BallBounce();
            paddle.PaddleDraw();
            paddleCPU.PaddleDrawCPU();
        }

        public void BallMove()
        {
            ball.PaddleBounce(paddle, paddleCPU);
            ball.MoveBall();
            ball.DrawBall();

        }

        public void Start()
        {

            //Draws ball, player paddle, cpu paddle, randoms their colors.
            rand = new Random();
            ball = new Ball(graphics, new Point(BALLPOSX, BALLPOSY), Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)), width, height);
            paddle = new Paddle(graphics, new Point(PLAYPADX, PLAYPADY),Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
            paddleCPU = new CPUPaddle(graphics, new Point(CPUPADX, CPUPADY), Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));

        }


        //MOVEMENT

        public void PlayerMoveUp()
        {
            paddle.PlayerMoveUp();
        }

        public void PlayerMoveDown()
        {
            paddle.PlayerMoveDown();
        }

    }
}
