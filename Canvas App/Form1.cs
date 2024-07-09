using System.Drawing;

namespace Canvas_App
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point lastPoint = Point.Empty;
        private Bitmap drawingBitmap;
        private Graphics graphics;
        public Form1()
        {
            InitializeComponent();

            // Initialize the bitmap and graphics objects for drawing
            drawingBitmap = new Bitmap(drawingPanel.Width, drawingPanel.Height);
            graphics = Graphics.FromImage(drawingBitmap);
            graphics.Clear(Color.White);
            drawingPanel.BackgroundImage = drawingBitmap;
            drawingPanel.BackgroundImageLayout = ImageLayout.None;

        }
        private void drawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location;
            }
        }

        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (lastPoint != Point.Empty)
                {
                    graphics.DrawLine(Pens.Black, lastPoint, e.Location);
                    lastPoint = e.Location;
                    drawingPanel.Invalidate(); // Redraw the panel to update the drawing
                }
            }
        }

        private void drawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                lastPoint = Point.Empty;
            }
        }
    

    private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
