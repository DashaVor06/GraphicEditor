using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    internal class Section : TwoDotsFigure
    {
        public Section(List<Point> points) : base(points)
        {
        }
        public Section() : base()
        {
        }

        public override void Print(object sender, PaintEventArgs e)
        {
            if (points.Count == 2)
            {
                
                using (Pen pen = new Pen(Color.Black, this.thikness))
                {
                    e.Graphics.DrawLine(pen, points[0], points[1]);
                }
            }
        }

    }
}
