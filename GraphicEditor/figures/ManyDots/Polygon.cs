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
            using (Pen pen = new Pen(this.color, this.thikness))
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
            }
        }
    }
}
