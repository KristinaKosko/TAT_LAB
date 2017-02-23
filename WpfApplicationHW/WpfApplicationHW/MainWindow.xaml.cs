using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Interop;

namespace WpfApplicationHW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string selectedPath;
        private string pathToDll;

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        private const int GWL_STYLE = -16;

        private const int WS_MAXIMIZEBOX = 0x10000; //maximize button 
        private const int WS_MINIMIZEBOX = 0x20000; //minimize button 

        public MainWindow()
        {
            InitializeComponent();
            this.SourceInitialized += MainWindow_SourceInitialized;
        }

        private IntPtr _windowHandle;
        private void MainWindow_SourceInitialized(object sender, EventArgs e)
        {
            _windowHandle = new WindowInteropHelper(this).Handle;

            //disable both minimize and maximize button 
            HideMinimizeAndMaximizeButtons();
        }

        protected void HideMinimizeAndMaximizeButtons()
        {
            if (_windowHandle == null)
                throw new InvalidOperationException("The window has not yet been completely initialized");

            SetWindowLong(_windowHandle, GWL_STYLE, GetWindowLong(_windowHandle, GWL_STYLE) & ~WS_MAXIMIZEBOX & ~WS_MINIMIZEBOX);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    selectedPath = fbd.SelectedPath;
                    selectFolder.Text = selectedPath;
                    var files = Directory.GetFiles(fbd.SelectedPath, "*.dll");
                    dlls.IsEnabled = true;
                    dlls.Items.Clear();
                    foreach (var file in files)
                    {                        
                        FileInfo f = new FileInfo(file);
                        dlls.Items.Add(f.Name);
                    }
                }
            }
        }

        public void GetClassesOfDll(System.Windows.Controls.ListBox listBox)
        {
            string dllName = null;
            dllName = listBox.SelectedItem.ToString();
            pathToDll = $"{selectedPath}\\{dllName}";
            Assembly assembly;
            Type[] classesOfDll;
            try
            {
                assembly = Assembly.LoadFile(pathToDll);
                classesOfDll = assembly.GetTypes();
                classes.IsEnabled = true;
                classes.Items.Clear();
                foreach (Type type in classesOfDll)
                {
                    if (type.IsClass)
                    {
                        classes.Items.Add(type);
                    }
                }
            }
            catch
            {
                assembly = null;
                classesOfDll = null;
                classes.Items.Clear();
                classes.IsEnabled = false;
                methods.IsEnabled = false;
                classes.Items.Add("Couldn't load the .DLL");
            }
        }

        public void GetMethodsOfDll(System.Windows.Controls.ListBox listBox, bool addMore)
        {
            if (!addMore) methods.Items.Clear();
            var lbType = (Type)listBox.SelectedItem;
            var methodsOfClass = lbType.GetMethods();
            foreach (MethodInfo type in methodsOfClass)
            {
                if (type.IsPublic)
                {
                    methods.Items.Add(type);
                }
            }
        }

        public void GetFieldsOfDll(System.Windows.Controls.ListBox listBox, bool addMore)
        {
            if (!addMore) methods.Items.Clear();
            var lbType = (Type)listBox.SelectedItem;
            var fieldsOfClass = lbType.GetFields();
            foreach (FieldInfo type in fieldsOfClass)
            {
                if (type.IsPublic)
                {
                    methods.Items.Add(type);
                }
            }
        }

        public void GetPropertiesOfDll(System.Windows.Controls.ListBox listBox, bool addMore)
        {
            if (!addMore) methods.Items.Clear();
            var lbType = (Type)listBox.SelectedItem;
            var propertiesOfClass = lbType.GetProperties();
            
            foreach (PropertyInfo type in propertiesOfClass)
            {
                methods.Items.Add(type);
            }
        }
        
        private void chooseProperties_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            methods.IsEnabled = true;
            switch (chooseProperties.Text)
            {
                case "Methods":
                    GetMethodsOfDll(classes, false);
                    break;
                case "Properties":
                    GetPropertiesOfDll(classes, false);
                    break;
                case "Fields":
                    GetFieldsOfDll(classes, false);
                    break;
                case "All":
                    GetMethodsOfDll(classes, false);
                    GetPropertiesOfDll(classes, true);
                    GetFieldsOfDll(classes, true);
                    break;
            }
        }

        private void dlls_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            methods.Items.Clear();
            GetClassesOfDll(dlls);
        }

        private void classes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GetMethodsOfDll(classes, false);
        }
    }
}

