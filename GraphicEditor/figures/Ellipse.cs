using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    internal class Ellipse : SimpleFigure
    {
        public Ellipse(List<Point> points) : base(points)
        {
        }
        public Ellipse() : base()
        {
        }

        public override void Print(object sender, PaintEventArgs e)
        {

            if (points.Count == 2)
            {
                int width = Math.Abs(points[0].X - points[1].X);
                int height = Math.Abs(points[0].Y - points[1].Y);

                using (Pen pen = new Pen(Color.Black, 2))
                {
                    e.Graphics.DrawEllipse(pen, points[0].X, points[0].Y, width, height);
                }
            }
        }

        public override int Add(Point point)
        {
            
            if (points.Count < 2)
            {
                points.Add(point);
                return 0;
            }
            else
                return 1;              
        }
    }
}
