﻿namespace Pong
{
    public  class CPUPaddle : Paddle

    {

        private const int PADWID = 10;
        private const int PADHEI = 100;
        private const int MOVEMENTCPU = 10; //CPU PADDLE SPEED
        private const int MOVEDOWN = 420; //== form width

        private bool movementSwitch = false;


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
            //AI follows ball.Y pos
            //paddleP.Y = ball.BallP.Y;


            //Bool switch to determine which way the CPU will move.
            switch (movementSwitch)
            {
             
                case false:
                    if (paddleP.Y + PADHEI <= MOVEDOWN)
                    {
                        paddleP.Y += MOVEMENTCPU;
                        if (paddleP.Y + PADHEI == MOVEDOWN)
                        {
                            movementSwitch = true;
                        }
                    }
                    break;

                case true:
                    if (paddleP.Y != 0)
                    {
                        paddleP.Y -= MOVEMENTCPU;
                        {
                            if (paddleP.Y == 0)
                            {
                                movementSwitch = false;
                            }
                        }
                    }
                    break;

                default:


            }


            //Move DOWN
            //if (paddleP.Y + PADHEI <= 850)
            //{
            //    paddleP.Y += MOVEMENTCPU;
            //    if (paddleP.Y + PADHEI == 850)
            //    {
            //        movementSwitch = true;
            //    }
            //}

            ////Move UP
            //if (paddleP.Y != 0)
            //{
            //    paddleP.Y -= MOVEMENTCPU;
            //    {
            //        if (paddleP.Y == 0)
            //        {
            //            movementSwitch = false;
            //        }
            //    }
            //}






        }

    }
}
