using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    internal class Polygon : ManyDotsFigure
    {
        public Polygon(List<Point> points) : base(points)
        {
        }

        public Polygon() : base()
        {
        }

        public override void Print(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, this.thikness))
            {
                if (points.Count > 1)
                {
                    Point[] arrPoints = points.ToArray();
                    e.Graphics.DrawPolygon(pen, arrPoints);
                }
            }
        }
    }
}
