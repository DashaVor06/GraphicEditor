﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    internal class Rectangle : Figure
    {
        public Rectangle(List<Point> points) : base(points)
        {
        }
        public Rectangle() : base()
        {
        }

        public override void Print(object sender, PaintEventArgs e)
        {
            if (points.Count == 2)
            {
                int width = Math.Abs(points[1].X - points[0].X);
                int height = Math.Abs(points[1].Y - points[0].Y);

                using (Pen pen = new Pen(Color.Black, 2))
                {
                    e.Graphics.DrawRectangle(pen, points[0].X, points[0].Y, width, height);
                }
            }
        }

        public override int Add(Point point)
        {
            if (points.Count < 2)
            {
                points.Add(point);
                return 0;
            }
            else
            {
                //Figure newFig = new Ellipse();
                //newFig.points.Add(point);
                //return newFig;
                return 1;
            }
        }
    }
}
