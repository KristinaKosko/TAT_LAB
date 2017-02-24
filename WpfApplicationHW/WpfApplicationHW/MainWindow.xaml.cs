using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Collections.Generic;

namespace WpfApplicationHW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string selectedPath;

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

        private CommonOpenFileDialog GetFolderBrowserDialog()
        {
            var dlg = new CommonOpenFileDialog
            {
                Title = "Choose Folder Which Includes Dlls",
                IsFolderPicker = true,
                AddToMostRecentlyUsedList = false,
                AllowNonFileSystemItems = false,
                EnsureFileExists = true,
                EnsurePathExists = true,
                EnsureReadOnly = false,
                EnsureValidNames = true,
                Multiselect = false,
                ShowPlacesList = true
            };

            return dlg;
        }

        private void AddDllsFromFolder(string directory)
        {
            selectFolder.Text = directory;
            dlls.IsEnabled = true;
            dlls.Items.Clear();
            try
            {
                var files = Directory.GetFiles(directory, "*.dll");
                foreach (var file in files)
                {
                    FileInfo f = new FileInfo(file);
                    dlls.Items.Add(f.Name);
                }
            }
            catch
            {
                dlls.Items.Add("");
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                var dlg = GetFolderBrowserDialog();
                if (dlg.ShowDialog() != CommonFileDialogResult.Ok) return;
                selectedPath = dlg.FileName;
                AddDllsFromFolder(selectedPath);
            }
        }

        private IEnumerable<Type> GetTypes(string dllPath)
        {
            var dll = Assembly.LoadFile(dllPath);
            IEnumerable<Type> types;
            try
            {
                types = dll.GetTypes();
            }
            catch (Exception)
            {
                types = new List<Type>();
            }

            return types;
        }

        private void GetClassesOfDll(System.Windows.Controls.ListBox listBox)
        {
            string dllName = listBox.SelectedItem.ToString();
            string pathToDll = $"{selectedPath}\\{dllName}";
            var classesOfDll = GetTypes(pathToDll);
            classes.Items.Clear();
            foreach (Type type in classesOfDll)
            {
                if (type.IsClass)
                {
                    classes.Items.Add(type);
                }
            }
        }

        private IEnumerable<MethodInfo> GetMethods(Type type)
        {
            IEnumerable<MethodInfo> methods;
            try
            {
                methods = type.GetMethods();
            }
            catch
            {
                methods = new MethodInfo[0];
            }
            return methods;
        }

        private void GetMethodsOfDll(System.Windows.Controls.ListBox listBox, bool addMore)
        {
            if (!addMore) methods.Items.Clear();
            var lbType = (Type)listBox.SelectedItem;
            var methodsOfClass = GetMethods(lbType);
            foreach (MethodInfo method in methodsOfClass)
            {
                if (method.IsPublic)
                {
                    methods.Items.Add(method);
                }
            }
        }

        private IEnumerable<FieldInfo> GetFields(Type type)
        {
            IEnumerable<FieldInfo> fields;
            try
            {
                fields = type.GetFields();
            }
            catch
            {
                fields = new FieldInfo[0];
            }
            return fields;
        }

        private void GetFieldsOfDll(System.Windows.Controls.ListBox listBox, bool addMore)
        {
            if (!addMore) methods.Items.Clear();
            var lbType = (Type)listBox.SelectedItem;
            var fieldsOfClass = GetFields(lbType);
            foreach (FieldInfo type in fieldsOfClass)
            {
                if (type.IsPublic)
                {
                    methods.Items.Add(type);
                }
            }
        }

        private IEnumerable<PropertyInfo> GetProperties(Type type)
        {
            IEnumerable<PropertyInfo> properties;
            try
            {
                properties = type.GetProperties();
            }
            catch
            {
                properties = new PropertyInfo[0];
            }
            return properties;
        }

        private void GetPropertiesOfDll(System.Windows.Controls.ListBox listBox, bool addMore)
        {
            if (!addMore) methods.Items.Clear();
            var lbType = (Type)listBox.SelectedItem;
            var propertiesOfClass = GetProperties(lbType);
            foreach (PropertyInfo type in propertiesOfClass)
            {
                methods.Items.Add(type);
            }
        }

        private void GetDllContetntOfSelectedType(string selectedType)
        {
            switch (selectedType)
            {
                case "Methods":
                    GetMethodsOfDll(classes, false);
                    Content.Text = "Methods";
                    break;
                case "Properties":
                    GetPropertiesOfDll(classes, false);
                    Content.Text = "Properties";
                    break;
                case "Fields":
                    GetFieldsOfDll(classes, false);
                    Content.Text = "Fields";
                    break;
                case "All":
                    GetMethodsOfDll(classes, false);
                    GetPropertiesOfDll(classes, true);
                    GetFieldsOfDll(classes, true);
                    Content.Text = "All Content";
                    break;
            }
        }

        private void chooseProperties_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (classes.Items.Count == 0) return;
            var selectedFilter = ((ComboBoxItem)(e.AddedItems[0])).Content.ToString();
            GetDllContetntOfSelectedType(selectedFilter);
        }

        private void dlls_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            methods.Items.Clear();
            GetClassesOfDll(dlls);
        }

        private void classes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            methods.IsEnabled = true;
            GetMethodsOfDll(classes, false);
            GetPropertiesOfDll(classes, true);
            GetFieldsOfDll(classes, true);
        }
    }
}