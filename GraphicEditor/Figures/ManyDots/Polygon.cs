using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Laba1
{
    public class Polygon : Figure
    {
        public override int pointsCount => 0;
        public override string name => "Многоугольник"; 

        public override void Print(object sender, PaintEventArgs e)
        {
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
