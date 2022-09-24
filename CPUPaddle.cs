using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public class CPUPaddle : Paddle

    {

        private const int PADWID = 20;
        private const int PADHEI = 250;



        public CPUPaddle(Graphics graphics, Point paddleP, Color color) : base(graphics, paddleP, color)
        {
            this.graphics = graphics;
            this.paddleP = paddleP;
            this.color = color;

            brush = new SolidBrush(color);

        }

        public void PaddleDrawCPU()
        {
            graphics.FillRectangle(brush, paddleP.X, paddleP.Y, PADWID, PADHEI);
        }

        public void CPUPaddleMovement(Ball ball)
        {
            if (paddleP.Y > 0)
            {
                paddleP.Y = ball.BallP.Y - 30;
            }

            if (paddleP.Y + PADHEI <= 850)
            {
                paddleP.Y = ball.BallP.Y - 30;
            }





                
        }

    }
}
