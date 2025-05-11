using System;
using System.IO;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Laba1
{
    public static class UploadClasses
    {
        public static void getClasses(fMain form, ToolStripMenuItem MenuItem, ListFigures ListFigures)
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
                        ListFigures.Current = newFig;
                        ListFigures.AddFigure();
                    };
                    string folderPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "pictures"));
                    string filePath = Path.Combine(folderPath, $"{fieldNameValue}.png");
                    newButton.Image = Image.FromFile(filePath);
                    MenuItem.DropDownItems.Add(newButton);
                }

            }
        }
    }
}
