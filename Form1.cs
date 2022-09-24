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



            controller = new Controller(bufferGraphics, width, height);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bufferGraphics.FillRectangle(Brushes.White, 0, 0, Width, Height);
            
            controller.Run();

            graphics.DrawImage(bufferImage, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Starts Game
            controller.Start();
            timer1.Enabled = true;
            button1.Visible = false;
            Focus(); //Focues on form not hidden buttons
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}