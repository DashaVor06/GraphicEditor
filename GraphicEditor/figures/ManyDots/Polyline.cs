using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    internal class Polyline : ManyDotsFigure
    {
        public Polyline(List<Point> points) : base(points)
        {
        }
        public Polyline() : base()
        {
        }

        public override void Print(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(this.color, this.thikness))
            {
                if (points.Count > 1)
                {
                    Point[] arrPoints = points.ToArray();
                    e.Graphics.DrawLines(pen, arrPoints);
                }
            }
        }
    }
}
