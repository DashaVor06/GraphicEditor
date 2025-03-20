using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public abstract class SimpleFigure: Figure
    {
        public SimpleFigure(List<Point> points) : base(points)
        {
        }
        public SimpleFigure() : base()
        {
        }

        public override void Print(object sender, PaintEventArgs e)
        {
        }

        public override int Add(Point point)
        {
            {
                if (points.Count < 2)
                {
                    points.Add(point);
                    return 0;
                }
                else
                    return 1;
            }
        }
    }
}
