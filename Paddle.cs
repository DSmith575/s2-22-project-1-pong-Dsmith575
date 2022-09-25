namespace Pong
{
    public class Paddle
    {

        private const int PADWID = 20;
        private const int PADHEI = 250;
        private const int HEICONTROL = 850; //max value for paddle + height position
        private const int PADSPEED = 50; //How far the paddle.Y moves when key press

        protected Graphics graphics;
        protected Brush brush;
        protected Color color;

        protected Point paddleP;

        public Paddle(Graphics graphics, Point paddleP, Color color)
        {

            this.graphics = graphics;
            this.paddleP = paddleP;
            this.color = color;

            brush = new SolidBrush(color);
        }

        public void PaddleDraw()
        {
            graphics.FillRectangle(brush, paddleP.X, paddleP.Y, PADWID, PADHEI);
        }

        public Point PaddleP
        {
            get { return paddleP; }
        }

        public void PlayerMoveUp()
        {
            if (paddleP.Y > 0)
            {
                paddleP.Y -= PADSPEED;
            }
        }

        public void PlayerMoveDown()
        {
            if (paddleP.Y + PADHEI <= HEICONTROL)
            {
                paddleP.Y += PADSPEED;
            }
        }
    }
}
