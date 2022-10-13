using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{

    //Shape class sets up the base for drawing both paddles.
    public abstract class Shapes
    {
        protected const int PADWID = 10;
        protected const int PADHEI = 100;
        protected const int MOVESPEED = 10;
        protected const int HEICONTROL = 320;

        protected Graphics graphics;
        protected Point paddleP;
        protected Color color;


        public Shapes(Graphics graphics, Point paddleP, Color color, int PADWID, int PADHEI, int MOVESPEED, int HEICONTROL)
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