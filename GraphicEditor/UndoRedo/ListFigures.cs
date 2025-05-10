using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public class ListFigures
    {
        private List<Figure> ListUndo { get; set; }
        public List<Figure> ListRedo { get; set; }
        public Figure Current {  get; set; }

        public ListFigures() {
            ListUndo = new List<Figure>();
            ListRedo = new List<Figure>();
            Current = null;
        }

        public void Add()
        {
            if (Current != null)
            {
                ListUndo.Add(Current);
                ListRedo = ListUndo.ToList();
            }
        }

        public void Change()
        {
            ListUndo[ListUndo.Count - 1] = Current;
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
