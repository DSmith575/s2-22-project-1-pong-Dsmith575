namespace Pong
{
    public  class CPUPaddle : Shapes
    {
        private const int MOVEMENTCPU = 10; //CPU PADDLE SPEED
        private const int MOVEDOWN = 420; //== form width

        private bool movementSwitch = false;

        public CPUPaddle(Graphics graphics, Point paddleP, Color color) : base(graphics, paddleP, color, PADWID, PADHEI)
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
        }
    }
}
