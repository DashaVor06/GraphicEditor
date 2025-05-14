using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Laba1
{
    public abstract class Figure
    {
        public virtual void Print(object sender, PaintEventArgs e) { }
        public abstract int pointsCount {  get; }
        public abstract string name { get; }

        public Figure(List<Point> points)
        {
            this.points = points;
        }

        public Figure() : this(new List<Point>())
        {
        }

        public int thikness { get; set; }
        public List<Point> points { get; set; }
        public Color border { get; set; }
        public Color filling { get; set; }

        public int Add(Point point)
        {
            {
                if (pointsCount == 0 || points.Count < pointsCount)
                {
                    points.Add(point);
                    return 0;
                }
                return 1;
            }
        }

    }
}
