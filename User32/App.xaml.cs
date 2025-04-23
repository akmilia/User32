using System;
using System.Windows;
using System.Windows.Navigation; 

namespace User32
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationWindow window = new NavigationWindow
            {
                Source = new Uri("MainWindow.xaml", UriKind.Relative),
                WindowState = WindowState.Maximized
            };
            window.Show();
        }
    }
}
 
