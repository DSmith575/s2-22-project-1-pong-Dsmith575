using System.Media;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Timer = System.Windows.Forms.Timer;

namespace Pong
{

    public class Controller
    {
        protected const int BALLPOSX = 500; //Ball starting pos X
        protected const int BALLPOSY = 200; //Ball starting pos Y
        protected const int PLAYPADX = 0; //Player starting pos X pos
        protected const int PLAYPADY = 100; //Player starting pos Y position
        protected const int CPUPADX = 12;
        protected const int CPUPADY = 0;
        protected const int MAXGAMESCORE = 3; //Controls how many points required to finish the game

        protected Graphics graphics;
        protected Ball ball;
        protected Paddle paddle;
        protected CPUPaddle paddleCPU;
        protected Scores scores = new Scores();
        protected Random rand = new Random();
        protected Timer timer1;
        protected Label label1;
        protected Label label2;

        protected int width;
        protected int height;
        protected int playerScore;
        protected int cpuScore;

        public Controller(Graphics graphics, int width, int height, Ball ball, Paddle paddle, CPUPaddle paddleCPU, Timer timer1, Label label1, Label label2)
        {
            this.graphics = graphics;
            this.width = width;
            this.height = height;
            this.timer1 = timer1;
            this.ball = ball;
            this.paddle = paddle;
            this.paddleCPU = paddleCPU;
            this.label1 = label1;
            this.label2 = label2;

        }


        public void Start()
        {
            //Draws ball, player paddle, cpu paddle, randoms their colors.
            ball = new Ball(graphics, new Point(BALLPOSX, BALLPOSY), Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)), width, height);
            paddle = new Paddle(graphics, new Point(PLAYPADX, PLAYPADY), Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
            paddleCPU = new CPUPaddle(graphics, new Point(width - CPUPADX, CPUPADY), Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
            playerScore = 0;
            cpuScore = 0;
        }


        public void Run()
        {
            //Method runs below on the timer1 ticks, this runs the whole game flow
            paddle.Draw();
            paddleCPU.Draw();
            BallMove();
            paddleCPU.CPUPaddleMovement(ball);
            label1.Text = playerScore.ToString();
            label2.Text = cpuScore.ToString();
            CheckWin();
        }



        public void BallMove()
        {
            playerScore = ball.BounceCpuSide(playerScore);
            cpuScore = ball.BouncePlayerSide(cpuScore);
            ball.FormBounce();
            ball.PaddleBounce(paddle, paddleCPU);
            ball.MoveBall();
            ball.DrawBall();
            paddleCPU.Draw();
        }

        //PLAYER MOVEMENT
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
            //Checks current value of labels
            if (Convert.ToInt32(label1.Text) == MAXGAMESCORE)
                    {
                timer1.Enabled = false;
                MessageBox.Show("You Win!");
                GameEnd();
            }

            if (Convert.ToInt32(label2.Text) == MAXGAMESCORE)
            {
                timer1.Enabled = false;
                MessageBox.Show("CPU WINS");
                GameEnd();

            }
        }

        public void GameEnd()
        { 
            Application.Restart();
        }

    }
}
