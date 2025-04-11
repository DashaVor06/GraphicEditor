using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laba1
{
    public partial class fMain : Form
    {
        private Figure fig = null;
        private int _thikness = 2;
        
        public fMain()
        {
            InitializeComponent();
        }

        private void print()
        {
            if (fig != null)
            {
                fig.border = colorDialogBorder.Color;
                fig.filling = colorDialogFilling.Color;
                fig.thikness = _thikness;
                Paint -= new PaintEventHandler(fig.Print);
                Paint += new PaintEventHandler(fig.Print);
                Invalidate();
            } 
        }

        private void fMain_Click(object sender, EventArgs e)
        {
            if (fig != null)
            {
                Point point = this.PointToClient(Cursor.Position);
                int err = fig.Add(point);

                if (err != 0)
                {
                    var newFig = Activator.CreateInstance(fig.GetType()) as dynamic;
                    fig = newFig;
                    fig.Add(point);
                }

                print();           
            }
        }

        private void отрезокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fig = new Section();
        }

        private void ломанаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fig = new Polyline();
        }

        private void прямоугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fig = new Rectangle();
        }

        private void многоугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fig = new Polygon();
        }

        private void эллипсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fig = new Ellipse();
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            _thikness = 1;
            print();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _thikness = 2;
            print();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            _thikness = 3;
            print();
        }

        private void однороднаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialogFilling.ShowDialog();
            print();
        }

        private void сплошнойЦветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialogBorder.ShowDialog();
            print();
        }

        private void безЗаливкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialogFilling.Color = Color.Transparent;
            print();
        }

        private void безToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialogBorder.Color = Color.Transparent;
            print();
        }
    }
}
