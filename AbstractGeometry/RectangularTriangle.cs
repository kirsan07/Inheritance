using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class RectangularTriangle : Triangle
    {
        double side;
        public double Side
        {
            get { return side; }
            set
            {
                if (value < MIN_LENGTH) value = MIN_LENGTH;
                if (value > MAX_LENGTH) value = MAX_LENGTH;
                side = value;
            }
        }
        public RectangularTriangle(int side, int start_x, int start_y, int line_width, Color color) : base(start_x, start_y, line_width, color) { Side = side; }
        public override double GetHeight()
        {
            return Math.Sqrt(Math.Pow(Side, 2) - Math.Pow(Side / 2, 2));

        }
        public override double GetArea()
        {
            return Math.Pow(GetHeight(), 2) * Math.Sqrt(3);
        }
        public override double GetPerimeter()
        {
            return Side * 3;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            Point[] points = new Point[]
            { new Point(StartX,StartY+(int)Side),
                new Point(StartX+(int)Side,StartY),
                    new Point(StartX+(int)Side/2,StartY +(int)Side - (int)GetHeight())
                };
            e.Graphics.DrawPolygon(pen, points);
        }

    }
}

