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
        private bool _down = false;
        
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

        private void addPoint()
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
                    string folderPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "pictures"));
                    string filePath = Path.Combine(folderPath, $"{fieldNameValue}.png");
                    newButton.Image = Image.FromFile(filePath);
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

        private void fMain_MouseUp(object sender, MouseEventArgs e)
        {
            _down = false;
        }

        private void fMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (_down && fig != null)
            {
                Point point = this.PointToClient(Cursor.Position);
                fig.points[fig.points.Count - 1] = point;
                print();
            }
        }

        private void fMain_MouseDown(object sender, MouseEventArgs e)
        {
            _down = true;
            addPoint();
            if (fig.points.Count == 1) addPoint();
        }
    }
}
