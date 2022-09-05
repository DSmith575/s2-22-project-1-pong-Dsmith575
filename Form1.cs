namespace Pong
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Graphics bufferGraphics;
        private Controller controller;
        private int width;
        private int height;
        private Image bufferImage;


        public Form1()
        {

            //BOUNDARIES.WIDTH CHECK (ACCURACY > OR >=)
            InitializeComponent();
            graphics = CreateGraphics();

            width = ClientSize.Width;
            height = ClientSize.Height;


            bufferImage = new Bitmap(width, height);
            bufferGraphics = Graphics.FromImage(bufferImage);
            controller = new Controller(bufferGraphics, width, height);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bufferGraphics.FillRectangle(Brushes.White, 0, 0, width, height);
            controller.Run();
            graphics.DrawImage(bufferImage, 0, 0);
        }
    }
}