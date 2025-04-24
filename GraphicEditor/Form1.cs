using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laba1
{
    public partial class fMain : Form
    {
        private Figure _fig = null;
        private int _thikness = 2;
        private bool _down = false;
        
        public fMain()
        {
            InitializeComponent();
        }

        private void print()
        {
            if (_fig != null)
            {
                _fig.border = colorDialogBorder.Color;
                _fig.filling = colorDialogFilling.Color;
                _fig.thikness = _thikness;
                Paint -= new PaintEventHandler(_fig.Print);
                Paint += new PaintEventHandler(_fig.Print);
                Invalidate();
            } 
        }

        private void addPoint()
        {
            if (_fig != null)
            {
                Point Point = this.PointToClient(Cursor.Position);
                int Err = _fig.Add(Point);

                if (Err != 0)
                {
                    var NewFig = Activator.CreateInstance(_fig.GetType()) as dynamic;
                    _fig = NewFig;
                    _fig.Add(Point);
                }

                print();   
            }
        }
        
        private void fMain_Load(object sender, EventArgs e)
        {
            UploadClasses.getClasses(_fig, tstripFigures);
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

        private void fMain_MouseUp(object sender, MouseEventArgs e)
        {
            _down = false;
        }
        private void fMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (_down && _fig != null)
            {
                Point Point = this.PointToClient(Cursor.Position);
                _fig.points[_fig.points.Count - 1] = Point;
                print();
            }
        }
        private void fMain_MouseDown(object sender, MouseEventArgs e)
        {
            _down = true;
            addPoint();
            if (_fig != null && _fig.points.Count == 1) addPoint();
        }
    }
}
