using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

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

        private void getClasses()
        {         
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                if (type.IsClass && (type.IsSubclassOf(typeof(TwoDotsFigure)) || type.IsSubclassOf(typeof(ManyDotsFigure))))
                {
                    PropertyInfo name = type.GetProperty("name", BindingFlags.Public | BindingFlags.Instance);
                    var tempInstance = Activator.CreateInstance(type);
                    string fieldNameValue = name.GetValue(tempInstance) as string;
                    ToolStripMenuItem newButton = new ToolStripMenuItem(fieldNameValue);
                    newButton.Click += (sender, e) =>
                    {
                        var newFig = Activator.CreateInstance(type) as dynamic;
                        fig = newFig;
                    };
                    newButton.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "pictures", fieldNameValue + ".png"));

                    tstripFigures.DropDownItems.Add(newButton);
                }
                    
            }
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            getClasses();
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
