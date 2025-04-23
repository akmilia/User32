using System;
using System.Collections.Generic;
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

namespace User32
{
    /// <summary>
    /// Логика взаимодействия для Header.xaml
    /// </summary>
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
        }
        private void transport_Click(object sender, RoutedEventArgs e)
        {
            // Получаем доступ к Frame из MainWindow
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.MainFrame.Navigate(new TransportWindow());
        }

        private void clients_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.MainFrame.Navigate(new ClientWindow());
        }

        private void discount_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.MainFrame.Navigate(new DiscountWindow());
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); // Корректное закрытие приложения
        }

        private void manager_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.MainFrame.Navigate(new ManagerWindow());
        }
    }
}
