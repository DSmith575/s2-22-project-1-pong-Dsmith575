using System.Drawing;

namespace Pong
{
    public class Paddle : Shapes
    {

        private const int HEICONTROL = 400; //max value for paddle + height position
        private const int PADSPEED = 20; //How far the paddle.Y moves when key press



        public Paddle(Graphics graphics, Point paddleP, Color color) : base(graphics, paddleP, color, PADHEI, PADWID)
        {
            this.graphics = graphics;
            this.paddleP = paddleP;
            
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

        public override void Draw()
        {
            Brush brush = new SolidBrush(color);
            graphics.FillRectangle(brush, paddleP.X, paddleP.Y, PADWID, PADHEI);
        }
    }
}
