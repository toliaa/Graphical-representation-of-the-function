using System;
using System.Drawing;
using System.Windows.Forms;

namespace ParametricGraph
{
    public partial class GraphicalRepresentation : Form
    {
        public GraphicalRepresentation()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            double R;
            if (!double.TryParse(rTextBox.Text, out R))
            {
                MessageBox.Show("Please enter a valid numeric value for R.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DrawGraph(R);
        }

        private void DrawGraph(double R)
        {
            Bitmap bmp = new Bitmap(graphPanel.Width, graphPanel.Height);
            Graphics g = Graphics.FromImage(bmp);

            // Clear the panel
            g.Clear(Color.White);

            // Draw coordinate system
            Pen axisPen = new Pen(Color.Black, 2);
            g.DrawLine(axisPen, graphPanel.Width / 2, 0, graphPanel.Width / 2, graphPanel.Height); // Y-axis
            g.DrawLine(axisPen, 0, graphPanel.Height / 2, graphPanel.Width, graphPanel.Height / 2); // X-axis

            // Draw labels
            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            g.DrawString("X", font, brush, graphPanel.Width - 20, graphPanel.Height / 2 + 5);
            g.DrawString("Y", font, brush, graphPanel.Width / 2 + 5, 5);

            // Calculate and draw the curve
            Pen curvePen = new Pen(Color.Blue, 2);
            double tStep = 0.01;
            PointF? prevPoint = null;

            for (double t = 0; t <= 2 * Math.PI; t += tStep)
            {
                double x = R * Math.Pow(Math.Cos(t), 3);
                double y = R * Math.Pow(Math.Sin(t), 3);

                // Transform the point to fit the panel
                float drawX = (float)(graphPanel.Width / 2 + x * 50);
                float drawY = (float)(graphPanel.Height / 2 - y * 50);

                PointF currentPoint = new PointF(drawX, drawY);

                if (prevPoint != null)
                {
                    g.DrawLine(curvePen, prevPoint.Value, currentPoint);
                }

                prevPoint = currentPoint;
            }

            // Display the graph
            graphPanel.BackgroundImage = bmp;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GraphicalRepresentation_Load(object sender, EventArgs e)
        {

        }
    }
}
