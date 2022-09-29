using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public abstract class Shapes
    {
        protected Graphics graphics;
        protected Point paddleP;
        protected Color color;
        protected const int PADWID = 10;
        protected const int PADHEI = 100;

        public Shapes(Graphics graphics, Point paddleP, Color color, int PADWID, int PADHEI)
        {
            this.graphics = graphics;
            this.paddleP = paddleP;
            this.color = color;
        }

        public Point PaddleP
        {
            get { return paddleP; }
        }

        public abstract void Draw();
    }
}