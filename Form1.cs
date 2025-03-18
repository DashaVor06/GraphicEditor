using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Laba1
{

    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private Figure fig;
        private List list;

        private List fillList()
        {
            List list = new List();

            List<Point> points0 = new List<Point>
            {
                new Point(200, 50),
                new Point(300, 100)
            };
            list.Add(new Section(points0));

            List<Point> points1 = new List<Point>
            {
                new Point(50, 230),
                new Point(70, 270),
                new Point(80, 240),
                new Point(90, 270),
                new Point(110, 230)
            };
            list.Add(new Polyline(points1));

            List<Point> points2 = new List<Point>
            {
                new Point(150, 230),
                new Point(170, 270),
                new Point(180, 240),
                new Point(160, 210)
            };
            list.Add(new Polygon(points2));

            List<Point> points3 = new List<Point>
            {
                new Point(100, 100),
                new Point(200, 130)
            };
            list.Add(new Ellipse(points3));

            List<Point> points4 = new List<Point>
            {
                new Point(200, 150),
                new Point(250, 200)
            };
            list.Add(new Rectangle(points4));

            return list;
        }
        
        private Point GetCursorPosition()
        {
            Point point = new Point();
            point.X = Cursor.Position.X - Location.X - (Width - ClientSize.Width) / 2;
            point.Y = Cursor.Position.Y - Location.Y - (Height - ClientSize.Height);
            return point;
        }

        //laba1
        private void fMain_Load(object sender, EventArgs e)
        {
            list = fillList();
            list.Print(this);
        }

        //laba2
        private void fMain_Click(object sender, EventArgs e)
        {
            
            Point point = GetCursorPosition();
            int err = fig.Add(point);

            if (err != 0)
            {
                var newFig = Activator.CreateInstance(fig.GetType()) as dynamic;
                fig = newFig;
                fig.Add(point);
            }

            Paint -= new PaintEventHandler(fig.Print);
            Paint += new PaintEventHandler(fig.Print);
            Invalidate();
        }

        private void tsbtSection_Click(object sender, EventArgs e)
        {
            fig = new Section();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fig = new Polyline();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            fig = new Polygon();
        }

        private void tsbtRectangle_Click(object sender, EventArgs e)
        {
            fig = new Rectangle();
        }

        private void tsbtEllipse_Click(object sender, EventArgs e)
        {
            fig = new Ellipse();
        }
    }
}
