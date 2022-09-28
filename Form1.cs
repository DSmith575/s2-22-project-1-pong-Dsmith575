namespace Pong
{
    public partial class Form1 : Form
    {
        private Graphics bufferGraphics;
        private Graphics graphics;
        private Controller controller;
        private Image bufferImage;



        private int height;
        private int width;

        public Form1()
        {
            InitializeComponent();


            bufferImage = new Bitmap(Width, Height);
            bufferGraphics = Graphics.FromImage(bufferImage);
            graphics = CreateGraphics();



            width = ClientSize.Width;
            height = ClientSize.Height;



            resume.Visible = false;
            quit.Visible = false;



            controller = new Controller(bufferGraphics, width, height);
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            bufferGraphics.FillRectangle(Brushes.White, 0, 0, Width, Height);

            controller.Run();

            graphics.DrawImage(bufferImage, 0, 0);

        }

        private void startGame_Click(object sender, EventArgs e)
        {
            //Starts Game
            controller.Start();
            //EnableDoubleBuffering();
            timer1.Enabled = true;
            startGame.Visible = false;
            quit.Visible = false;
            menuquit.Visible = false;
            highscore.Visible = false;
            Focus(); //Focus on form not hidden buttons
        }


        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //MoveUp
                case Keys.Up:
                    controller.PlayerMoveUp();
                    break;

                //MoveDown
                case Keys.Down:
                    controller.PlayerMoveDown();
                    break;

                //Pause Game
                case Keys.P:
                    timer1.Enabled = false;
                    resume.Visible = true;
                    quit.Visible = true;
                    break;


                default:
                    break;
            }
        }


        private void resume_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            resume.Visible = false;
            quit.Visible = false;
            Focus();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            resume.Visible = false;
            quit.Visible = false;
            startGame.Visible = true;
            menuquit.Visible = true;
            highscore.Visible = true;
            this.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Environment.Exit(0);
        }




        //public void EnableDoubleBuffering()
        //{
        //    // Set the value of the double-buffering style bits to true.
        //    this.SetStyle(ControlStyles.DoubleBuffer |
        //       ControlStyles.UserPaint |
        //       ControlStyles.AllPaintingInWmPaint,
        //       true);
        //    this.UpdateStyles();
        //}
    }
}
