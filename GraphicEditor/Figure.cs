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

        private int _thikness;

        public Figure(List<Point> points)
        {
            this.points = points;
            this.thikness = 2;
        }

        public Figure() : this(new List<Point>()) 
        { 
        }

        public int thikness
        {
            get { return _thikness; }
            set { _thikness = value; }
        }

        public List<Point> points
        {
            get { return _points; }
            set { _points = value; }
        }
    }
}
