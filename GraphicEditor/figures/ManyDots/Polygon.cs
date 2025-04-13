using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Laba1
{
    public class Polygon : ManyDotsFigure
    {
        public Polygon(List<Point> points) : base(points)
        {
        }

        public Polygon() : base()
        {
        }

        public override string name
        {
            get { return "Многоугольник"; }
        }

        public override void Print(object sender, PaintEventArgs e)
        {
            /*
            using (Pen pen = new Pen(this.border, this.thikness))
            {
                if (points.Count > 1)
                {
                    Point[] arrPoints = points.ToArray();
                    for (int i = 1; i < arrPoints.Length; i++)
                    {
                        e.Graphics.DrawLine(pen, arrPoints[i], arrPoints[i-1]);
                    }

                    e.Graphics.DrawLine(pen, arrPoints[0], arrPoints[arrPoints.Length-1]);

                }
            }*/
            if (points.Count > 1)
            {
                Point[] arrPoints = points.ToArray();

                using (Pen pen = new Pen(this.border, this.thikness))
                {
                    using (Brush brush = new SolidBrush(this.filling))
                    {
                        e.Graphics.FillPolygon(brush, arrPoints);
                        e.Graphics.DrawPolygon(pen, arrPoints);
                    }
                }
            }
        }
    }
}
