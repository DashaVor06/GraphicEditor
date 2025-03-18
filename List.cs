using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using System.Windows.Forms;

namespace Laba1
{
    internal class List
    {
        private List<Figure> _list;
        public List() 
        {
            _list = new List<Figure>();
        }

        public void Add(Figure fig)
        {
            _list.Add(fig);
        }

        public void Print(object sender)
        {
            if (sender is Form form){
                foreach (Figure fig in _list)
                {
                    form.Paint += new PaintEventHandler(fig.Print);
                }

                form.Invalidate();
            }
            
        }
    }
}
