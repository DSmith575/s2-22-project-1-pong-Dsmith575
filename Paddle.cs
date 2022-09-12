
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public class Paddle
    {
        private const int PADDLEWIDTH = 20;
        private const int PADDLEHEIGHT = 200;

        private Graphics graphics;
        private Brush brush;
        private Point paddlePoint;



        public Paddle(Graphics graphics, Color color, Point paddlePoint)//contructor
        {
            this.graphics = graphics;
            this.paddlePoint = paddlePoint;
            brush = new SolidBrush(color);

        }

        public void Draw()//draw the paddle to form
        {
            graphics.FillRectangle(brush, paddlePoint.X, paddlePoint.Y, PADDLEWIDTH, PADDLEHEIGHT);
        }


        public Point PaddlePoint
        {
            get
            {
                return paddlePoint;
            }
        }
    }
}