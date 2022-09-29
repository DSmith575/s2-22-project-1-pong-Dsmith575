using System.Drawing;
namespace Pong
{
    public class Paddle : Shapes
    {
        public Paddle(Graphics graphics, Point paddleP, Color color) : base(graphics, paddleP, color, PADHEI, PADWID, MOVESPEED, HEICONTROL, HEICTRLCPU)
        {
            this.graphics = graphics;
            this.paddleP = paddleP;
        }

        public void PlayerMoveUp()
        {
            if (paddleP.Y > 0)
            {
                paddleP.Y -= MOVESPEED;
            }
        }

        public void PlayerMoveDown()
        {
            if (paddleP.Y + PADHEI <= HEICONTROL)
            {
                paddleP.Y += MOVESPEED;
            }
        }

        public override void Draw()
        {
            Brush brush = new SolidBrush(color);
            graphics.FillRectangle(brush, paddleP.X, paddleP.Y, PADWID, PADHEI);
        }
    }
}
