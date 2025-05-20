using System;
using System.IO;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Laba1.serialization;
using System.Threading.Tasks;

namespace Laba1
{
    public static class Loader
    {
        private static void func(Assembly assembly, fMain form, ToolStripMenuItem MenuItem, ListFigures ListFigures)
        {
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                if (type.IsClass && type.IsSubclassOf(typeof(Figure)))
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

        public static void AddPluginBtn(fMain form, ToolStripMenuItem MenuItem, ListFigures ListFigures)
        {
            ToolStripMenuItem newButton = new ToolStripMenuItem("Добавить плагин");

            newButton.Click += (sender, e) =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "DLL файлы (*.dll)|*.dll";
                openFileDialog.DefaultExt = "dll";
                openFileDialog.ValidateNames = true;
                openFileDialog.CheckFileExists = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    AddPluginAsync(openFileDialog.FileName);
                    Assembly assembly = Assembly.LoadFrom(openFileDialog.FileName);
                    func(assembly, form, MenuItem, ListFigures);
                }
            };

            MenuItem.DropDownItems.Add(newButton);
        }


        public static void LoadClasses(fMain form, ToolStripMenuItem MenuItem, ListFigures ListFigures)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            func(assembly, form, MenuItem, ListFigures);
        }

        private static void loadPlugins(fMain form, ToolStripMenuItem MenuItem, ListFigures ListFigures)
        {
            string pluginsDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Plugins");
            if (!Directory.Exists(pluginsDir))
            {
                Directory.CreateDirectory(pluginsDir);
            }
            foreach (string dllPath in Directory.GetFiles(pluginsDir, "*.dll"))
            {
                Assembly assembly = Assembly.LoadFrom(dllPath);
                func(assembly, form, MenuItem, ListFigures);
            }
        }

        public static bool AddPluginAsync(string fileName)
        {        
            string pluginsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Plugins");
            if (!Directory.Exists(pluginsDirectory))
            {
                Directory.CreateDirectory(pluginsDirectory);
            }

            string createdFileName = Path.Combine(pluginsDirectory, Path.GetFileName(fileName));
            if (File.Exists(createdFileName))
            {
                return false;
            }

            byte[] bytes;
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[fs.Length];
                fs.Read(bytes, 0, bytes.Length);
            }

            using (FileStream fs = new FileStream(createdFileName, FileMode.Create, FileAccess.Write))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
            return true;
        }

        public static void LoadPlugins(fMain form, ToolStripMenuItem MenuItem, ListFigures ListFigures)
        {
            loadPlugins(form, MenuItem, ListFigures);
        }
    }
}
