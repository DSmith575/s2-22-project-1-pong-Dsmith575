using Timer = System.Windows.Forms.Timer;

namespace Pong
{

    public class Controller
    {
        protected const int BALLPOSX = 500; //Ball starting pos X
        protected const int BALLPOSY = 200; //Ball starting pos Y
        protected const int PLAYPADX = 0; //Player starting pos X pos
        protected const int PLAYPADY = 100; //Player starting pos Y position
        protected const int CPUPADX = 790;
        protected const int CPUPADY = 0;

        protected Graphics graphics;
        protected Ball ball;
        protected Paddle paddle;
        protected CPUPaddle paddleCPU;

        protected int width;
        protected int height;
        protected Random rand = new Random();

        private int playerScore = 0;
        private int cpuScore = 0;
        protected Timer timer1;

        public Controller(Graphics graphics, int width, int height, Ball ball, Paddle paddle, CPUPaddle paddleCPU)
        {
            this.graphics = graphics;
            this.width = width;
            this.height = height;

            this.ball = ball;
            this.paddle = paddle;
            this.paddleCPU = paddleCPU;
        }

        public void Start()
        {

            //Draws ball, player paddle, cpu paddle, randoms their colors.
            ball = new Ball(graphics, new Point(BALLPOSX, BALLPOSY), Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)), width, height);
            paddle = new Paddle(graphics, new Point(PLAYPADX, PLAYPADY), Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
            paddleCPU = new CPUPaddle(graphics, new Point(CPUPADX, CPUPADY), Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
        }


        public void Run()
        {
            BallMove();
            ball.BallBounce();
            paddle.Draw();
            paddleCPU.Draw();
            paddleCPU.CPUPaddleMovement(ball);
            CheckWin();
        }

        public void BallMove()
        {
            ball.PaddleBounce(paddle, paddleCPU);
            ball.MoveBall();
            ball.DrawBall();
            paddleCPU.Draw();
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

        public void CheckWin()
        {
            if (playerScore == 10)
            {
                timer1.Enabled = false;
                MessageBox.Show("You Win!");
            }

            if (cpuScore == 10)
            {
                timer1.Enabled = false;
                MessageBox.Show("CPU WINS");
            }
        }

    }
}
