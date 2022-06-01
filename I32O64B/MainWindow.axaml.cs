using System;
using System.Runtime.InteropServices;
using Avalonia.Input;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace I32O64B
{
    public partial class MainWindow : Window
    {
        public string Decoration = "None";
        public MainWindow()
        {
            InitializeComponent();
            
            sysArchText.Content = (System.Environment.Is64BitOperatingSystem ? "64" : "32") + " Bits";
        }
        private void ExitApp(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0x0);
        }
    }
}
