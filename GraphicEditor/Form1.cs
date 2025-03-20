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

        //laba2
        private void fMain_Click(object sender, EventArgs e)
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
