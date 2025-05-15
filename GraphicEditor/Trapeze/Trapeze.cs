using System;
using Laba1;
using System.Drawing;
using System.Windows.Forms;

namespace Trapeze
{
    public class Trapeze : Figure
    {
        public override int pointsCount => 4;
        public override string name => "Трапеция";

        public override void Print(object sender, PaintEventArgs e)
        {
            if (points.Count > 1)
            {
                Point[] arrPoints = points.ToArray();

                if (points.Count == 4)
                {
                    double A = (double)(arrPoints[1].Y - arrPoints[0].Y) / (arrPoints[1].X - arrPoints[0].X);
                    arrPoints[3].Y = arrPoints[2].Y + (int)(A * (arrPoints[3].X - arrPoints[2].X));
                }

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
