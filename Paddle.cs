
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public class Paddle
    {
        private const int PADDLEWIDTH = 10;
        private const int PADDLEHEIGHT = 100;

        private Graphics graphics;
        private Brush brush;
        private Point paddleP;



        public Paddle(Graphics graphics, Color color, Point paddleP)
        {
            this.graphics = graphics;
            this.paddleP = paddleP;
            brush = new SolidBrush(color);

        }

        public void Draw() //Method to draw paddle
        {
            graphics.FillRectangle(brush, paddleP.X, paddleP.Y, PADDLEWIDTH, PADDLEHEIGHT);
        }


        public Point PaddleP
        {
            get
            {
                return paddleP;
            }
        }
    }
}