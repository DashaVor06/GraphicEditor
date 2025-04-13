using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Laba1
{
    public class Ellipse : TwoDotsFigure
    {
        public Ellipse(List<Point> points) : base(points)
        {
        }
        public Ellipse() : base()
        {
        }

        public override string name
        {
            get { return "Эллипс"; }
        }

        public override void Print(object sender, PaintEventArgs e)
        {

            if (points.Count == 2)
            {
                int width = Math.Abs(points[0].X - points[1].X);
                int height = Math.Abs(points[0].Y - points[1].Y);

                using (Pen pen = new Pen(this.border, this.thikness))
                {
                    using (Brush brush = new SolidBrush(this.filling))
                    {
                        e.Graphics.FillEllipse(brush, points[0].X, points[0].Y, width, height);
                        e.Graphics.DrawEllipse(pen, points[0].X, points[0].Y, width, height);
                    }
                        
                }
            }
        }
    }
}
