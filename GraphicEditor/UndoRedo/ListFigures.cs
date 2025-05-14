using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Laba1
{
    public class ListFigures
    {
        public List<Figure> ListUndo { get; set; }
        public List<Figure> ListRedo { get; set; }
        public Figure Current {  get; set; }

        public ListFigures() {
            ListUndo = new List<Figure>();
            ListRedo = new List<Figure>();
            Current = null;
        }

        public void AddFigure()
        {
            if (Current != null)
            {
                ListUndo.Add(Current);
                ListRedo = ListUndo.ToList();
            }
        }

        public void AddPoint(fMain form)
        {
            if (Current != null)
            {
                Point Point = form.PointToClient(Cursor.Position);
                int Err = Current.Add(Point);
                Change();

                if (Err != 0)
                {
                    var NewFig = Activator.CreateInstance(Current.GetType()) as dynamic;
                    Current = NewFig;
                    Current.Add(Point);
                    AddFigure();
                }

                PrintCurrent(form);
            }
        }

        public void Change()
        {
            if (ListUndo.Count > 0)
                ListUndo[ListUndo.Count - 1] = Current;
        }

        public void ClearList(fMain form)
        {
            foreach (Figure f in ListUndo)
            {
                form.Paint -= new PaintEventHandler(f.Print);
            }
            form.Invalidate();
        }

        public void PrintList(fMain form)
        {
            foreach (Figure f in ListUndo)
            {
                form.Paint += new PaintEventHandler(f.Print);
            }
            form.Invalidate();
        }

        public void PrintCurrent(fMain form)
        {
            if (Current != null)
            {
                form.Paint -= new PaintEventHandler(Current.Print);
                form.Paint += new PaintEventHandler(Current.Print);
                form.Invalidate();
            }
        }

        public void Undo(fMain form)
        {
            if (ListUndo.Count > 0)
            {
                form.Paint -= new PaintEventHandler(ListUndo[ListUndo.Count - 1].Print);
                form.Invalidate();

                ListUndo.Remove(ListUndo[ListUndo.Count - 1]);
            }
        }
        
        public void Redo(fMain form)
        {
            if (ListRedo.Count > ListUndo.Count)
            {
                ListUndo.Add(ListRedo[ListUndo.Count]);

                form.Paint += new PaintEventHandler(ListUndo[ListUndo.Count - 1].Print);
                form.Invalidate();
            }
                
        }
    }
}
