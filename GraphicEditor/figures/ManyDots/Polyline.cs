using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Laba1
{
    public class Polyline : ManyDotsFigure
    {
        public Polyline(List<Point> points) : base(points)
        {
        }
        public Polyline() : base()
        {
        }

        public override string name
        {
            get { return "Ломаная"; }
        }

        public override void Print(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(this.border, this.thikness))
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
