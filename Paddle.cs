using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public class Paddle
    {

        private const int PADWID = 20;
        private const int PADHEI = 250;



        
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
            paddleP.Y -= 10;
        }

        public void PlayerMoveDown()
        {
            if (paddleP.Y < 950)
            paddleP.Y += 10;
        }

    }
}
