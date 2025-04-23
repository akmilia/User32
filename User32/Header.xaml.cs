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

        /*
namespace diplom.Components
{

    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
        }
        private void CloseWindow()
        {
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.Close();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NavigationWindow window = (NavigationWindow)Application.Current.MainWindow;
                window.Navigate(new Uri("schedule.xaml", UriKind.Relative));
            }
            catch
            {
                MessageBox.Show("Возникла неизвестная проблема. Пожалуйста, попробуйте позднее");
            }
*/
        private void CloseWindow()
        {
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.Close();
            }
        }
        private void transport_Click(object sender, RoutedEventArgs e)
        {
            // Получаем доступ к Frame из MainWindow
            try
            {
                NavigationWindow window = (NavigationWindow)Application.Current.MainWindow;
                window.Navigate(new Uri("TransportWindow.xaml", UriKind.Relative));
            }
            catch
            {
                MessageBox.Show("Возникла неизвестная проблема. Пожалуйста, попробуйте позднее");
            }
        }

        private void clients_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NavigationWindow window = (NavigationWindow)Application.Current.MainWindow;
                window.Navigate(new Uri("ClientWindow.xaml", UriKind.Relative));
            }
            catch
            {
                MessageBox.Show("Возникла неизвестная проблема. Пожалуйста, попробуйте позднее");
            }
           
        }

        private void discount_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NavigationWindow window = (NavigationWindow)Application.Current.MainWindow;
                window.Navigate(new Uri("DiscountWindow.xaml", UriKind.Relative));
            }
            catch
            {
                MessageBox.Show("Возникла неизвестная проблема. Пожалуйста, попробуйте позднее");
            }
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.CloseWindow();
        }

        private void manager_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NavigationWindow window = (NavigationWindow)Application.Current.MainWindow;
                window.Navigate(new Uri("ManagerWindow.xaml", UriKind.Relative));
            }
            catch
            {
                MessageBox.Show("Возникла неизвестная проблема. Пожалуйста, попробуйте позднее");
            }
        }
    }
}
