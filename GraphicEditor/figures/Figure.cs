using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Laba1
{
    public abstract class Figure
    {
        public abstract void Print(object sender, PaintEventArgs e);
        public abstract int Add(Point point);

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
    }
}
