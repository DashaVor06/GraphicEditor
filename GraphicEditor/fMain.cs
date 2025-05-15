using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Laba1.serialization;

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

        private void fMain_Load(object sender, EventArgs e)
        {
            Loader.AddPluginBtn(this, фигурыToolStripMenuItem, ListFigures);
            Loader.LoadClasses(this, фигурыToolStripMenuItem, ListFigures);
            Loader.LoadPlugins(this, фигурыToolStripMenuItem, ListFigures);    
        }

        private void fMain_MouseUp(object sender, MouseEventArgs e)
        {
            _down = false;
        }
        private void takeParams()
        {
            if (ListFigures.Current != null)
            {
                ListFigures.Current.thikness = _thikness;
                ListFigures.Current.border = colorDialogBorder.Color;
                ListFigures.Current.filling = colorDialogFilling.Color;
            }
        }

        private void mouseMove()
        {
            if (_down && ListFigures.Current != null)
            {
                Point Point = PointToClient(Cursor.Position);
                ListFigures.Current.points[ListFigures.Current.points.Count - 1] = Point;
                takeParams();
                ListFigures.PrintCurrent(this);
            }
        }

        private void fMain_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove();
        }

        private void fMain_MouseDown(object sender, MouseEventArgs e)
        {
            _down = true;
            ListFigures.AddPoint(this);
            mouseMove();
        }

        private void saveFunc()
        {
            DialogResult result = MessageBox.Show(
                "У вас есть несохраненные изменения.\nСохранить перед выходом?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            switch (result)
            {
                case DialogResult.Yes:
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        SerializationDeserialization.serialize(ListFigures, saveFileDialog.FileName);
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveFunc();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                SerializationDeserialization.serialize(ListFigures, saveFileDialog.FileName);
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFunc();
                ListFigures.ClearList(this);
                string filePath = openFileDialog.FileName;
                ListFigures = SerializationDeserialization.deserialize(ListFigures, filePath);
                ListFigures.PrintList(this);
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListFigures.Undo(this);
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListFigures.Redo(this);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            _thikness = 1;
            takeParams();
            ListFigures.PrintCurrent(this);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            _thikness = 2;
            takeParams();
            ListFigures.PrintCurrent(this);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            _thikness = 3;
            takeParams();
            ListFigures.PrintCurrent(this);
        }

        private void noBorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialogBorder.Color = Color.Transparent;
            takeParams();
            ListFigures.PrintCurrent(this);
        }

        private void withBorderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialogBorder.ShowDialog();
            takeParams();
            ListFigures.PrintCurrent(this);
        }

        private void noFillingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialogFilling.Color = Color.Transparent;
            takeParams();
            ListFigures.PrintCurrent(this);
        }

        private void withFillingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            colorDialogFilling.ShowDialog();
            takeParams();
            ListFigures.PrintCurrent(this);
        }
    }
}
