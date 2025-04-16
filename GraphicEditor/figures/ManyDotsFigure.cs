using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Laba1
{
    public abstract class ManyDotsFigure : Figure
    {
        public override int Add(Point point)
        {
            points.Add(point);
            return 0;
        }
    }
}
