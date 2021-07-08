using System;
using System.Windows;

namespace I32O64B
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
