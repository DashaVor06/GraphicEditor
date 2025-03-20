using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public abstract class Figure
    {
        public abstract void Print(object sender, PaintEventArgs e);
        public abstract int Add(Point point);

        private List<Point> _points;

        public Figure(List<Point> points)
        {
            this.points = points;
        }

        public Figure() : this(new List<Point>()) 
        { 
        }

        public List<Point> points
        {
            get { return _points; }
            set { _points = value; }
        }
    }
}
