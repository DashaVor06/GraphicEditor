using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    internal class Polygon : Figure
    {
        public Polygon(List<Point> points) : base(points)
        {
        }

        public Polygon() : base()
        {
        }

        public override void Print(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 2))
            {
                if (points.Count > 1)
                {
                    Point[] arrPoints = points.ToArray();
                    e.Graphics.DrawPolygon(pen, arrPoints);
                }
            }
        }

        public override int Add(Point point)
        {
            points.Add(point);
            return 0;
        }
    }
}
