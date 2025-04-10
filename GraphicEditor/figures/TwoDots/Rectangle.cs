using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Laba1
{
    internal class Rectangle : TwoDotsFigure
    {
        public Rectangle(List<Point> points) : base(points)
        {
        }
        public Rectangle() : base()
        {
        }

        public override void Print(object sender, PaintEventArgs e)
        {
            if (points.Count == 2)
            {
                int width = Math.Abs(points[1].X - points[0].X);
                int height = Math.Abs(points[1].Y - points[0].Y);

                using (Pen pen = new Pen(this.color, this.thikness))
                {
                    e.Graphics.DrawRectangle(pen,Math.Min(points[0].X, points[1].X), Math.Min(points[0].Y, points[1].Y), width, height);
                }
            }
        }
    }
}
