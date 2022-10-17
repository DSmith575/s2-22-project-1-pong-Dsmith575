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

        protected const int PADWID = 10;          //Paddle width and height controls
        protected const int PADHEI = 100;
        protected const int MOVESPEED = 10;     //How fast paddles move per tick
        protected const int HEICONTROL = 350;  //Stopping point for paddles hitting bottom of screen

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