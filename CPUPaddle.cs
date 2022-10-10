namespace Pong
{
    public  class CPUPaddle : Shapes
    {
        protected bool movementSwitch = false;

        public CPUPaddle(Graphics graphics, Point paddleP, Color color) : base(graphics, paddleP, color, PADWID, PADHEI, MOVESPEED, HEICONTROL, HEICTRLCPU)
        {
            this.graphics = graphics;
            this.paddleP = paddleP;   
        }
        public override void Draw()
        {
            Brush brush = new SolidBrush(color);
            graphics.FillRectangle(brush, paddleP.X, paddleP.Y, PADWID, PADHEI);
        }

        public void CPUPaddleMovement(Ball ball)
        {
            //Bool switch to determine which way the CPU will move.
            switch (movementSwitch)
            {
             
                case false:
                    if (paddleP.Y + PADHEI <= HEICTRLCPU)
                    {
                        paddleP.Y += MOVESPEED;
                        if (paddleP.Y + PADHEI == HEICTRLCPU)
                        {
                            movementSwitch = true;
                        }
                    }
                    break;

                case true:
                    if (paddleP.Y != 0)
                    {
                        paddleP.Y -= MOVESPEED;
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
        }
    }
}
