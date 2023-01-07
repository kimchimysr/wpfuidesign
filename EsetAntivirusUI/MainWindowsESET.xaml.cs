using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EsetAntivirusUI
{
    /// <summary>
    /// Interaction logic for MainWindowsESET.xaml
    /// </summary>
    public partial class MainWindowsESET : Window
    {
        public MainWindowsESET()
        {
            InitializeComponent();
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnMinimize":
                    WindowState = WindowState.Minimized;
                    break;
                case "btnMaximize":
                    WindowState = WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
                    btnMaximize.Content = WindowState == WindowState.Normal ? FindResource("Maximize") : FindResource("Restore");
                    break;
                case "btnClose":
                    this.Close();
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
