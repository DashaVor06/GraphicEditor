﻿using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Laba1
{
    public class Section : TwoDotsFigure
    {
        public override string name
        {
            get { return "Отрезок"; }
        }

        public override void Print(object sender, PaintEventArgs e)
        {
            if (points.Count == 2)
            {   
                using (Pen pen = new Pen(this.border, this.thikness))
                {
                    e.Graphics.DrawLine(pen, points[0], points[1]);
                }
            }
        }

    }
}
