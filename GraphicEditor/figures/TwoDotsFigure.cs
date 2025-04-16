using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Laba1
{
    public abstract class TwoDotsFigure: Figure
    {
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
