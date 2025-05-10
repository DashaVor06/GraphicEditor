using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laba1
{
    public partial class fMain : Form
    {
        private int _thikness = 2;
        private bool _down = false;
        public ListFigures ListFigures = new ListFigures();
        
        public fMain()
        {
            InitializeComponent();
        }

        private void print()
        {
            if (ListFigures.Current != null)
            {
                ListFigures.Current.border = colorDialogBorder.Color;
                ListFigures.Current.filling = colorDialogFilling.Color;
                ListFigures.Current.thikness = _thikness;
                Paint -= new PaintEventHandler(ListFigures.Current.Print);
                Paint += new PaintEventHandler(ListFigures.Current.Print);
                Invalidate();
            } 
        }

        private void addPoint()
        {
            if (ListFigures.Current != null)
            {
                Point Point = this.PointToClient(Cursor.Position);
                int Err = ListFigures.Current.Add(Point);
                ListFigures.Change();

                if (Err != 0)
                {
                    var NewFig = Activator.CreateInstance(ListFigures.Current.GetType()) as dynamic;
                    ListFigures.Current = NewFig;
                    ListFigures.Current.Add(Point);
                    ListFigures.Add();
                }

                print();   
            }
        }
        
        private void fMain_Load(object sender, EventArgs e)
        {
            UploadClasses.getClasses(this, tstripFigures, ListFigures);
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
            if (_down && ListFigures.Current != null)
            {
                Point Point = PointToClient(Cursor.Position);
                ListFigures.Current.points[ListFigures.Current.points.Count - 1] = Point;
                print();
            }
        }
        private void fMain_MouseDown(object sender, MouseEventArgs e)
        {
            _down = true;
            addPoint();
            if (ListFigures.Current != null)
            {
                if (ListFigures.Current.points.Count == 1) addPoint();
            }
        }

        private void отменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListFigures.Undo(this);
        }

        private void вернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListFigures.Redo(this);
        }
    }
}
