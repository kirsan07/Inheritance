using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
        internal class Circle : Shape
        {
            public float Radius { get; set; }
            public Circle(float radius, int start_x, int start_y, int line_width, Color color) : base(start_x, start_y, line_width, color)
            {
                Radius = radius;
            }
        public double GetDiameter()
        {
                return Radius * 2;
            }
            public double GetRadius()
            {
                return GetDiameter() / 2;
            }
            public override double GetArea()
            {
                return Math.PI * Math.Pow(GetRadius(), 2);
            }
            public override double GetPerimeter()
            {
                return Math.PI * 2 * GetRadius();
            }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            /*Point[] points = new Point[]
                { 

                };*/
            float startAngle = 0.0F;
            float sweepAngle = 360.0F;
            e.Graphics.DrawPie(pen, StartX, StartY, (float)GetRadius(), (float)GetRadius(), startAngle, sweepAngle);
        }
        /*public void DrawPieFloat(PaintEventArgs e)
        {

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create location and size of ellipse.
            float x = 0.0F;
            float y = 0.0F;
            float width = 200.0F;
            float height = 100.0F;

            // Create start and sweep angles.
            float startAngle = 0.0F;
            float sweepAngle = 45.0F;

            // Draw pie to screen.
            e.Graphics.DrawPie(blackPen, x, y, width, height, startAngle, sweepAngle);
        }*/
    }
    
}
