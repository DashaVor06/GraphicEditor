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
        private Figure fig = null;

        public fMain()
        {
            InitializeComponent();
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

                Paint -= new PaintEventHandler(fig.Print);
                Paint += new PaintEventHandler(fig.Print);
                Invalidate();
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
        }

        private void ооToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fig != null) fig.thikness = 1;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (fig != null) fig.thikness = 2;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (fig != null) fig.thikness = 3;
        }
    }
}
