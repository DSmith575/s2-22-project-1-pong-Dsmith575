namespace Pong
{

    public class Controller
    {
        private const int BALLPOSX = 500; //Ball starting pos X
        private const int BALLPOSY = 200; //Ball starting pos Y
        private const int PLAYPADX = 3; //Player starting pos X pos
        private const int PLAYPADY = 100; //Player starting pos Y position
        private const int CPUPADX = 970;
        private const int CPUPADY = 0;

        private Graphics graphics;
        private Ball ball;
        private Paddle paddle;
        private CPUPaddle paddleCPU;

        private int width;
        private int height;
        private Random rand = new Random();


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

    }
}
