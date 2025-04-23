using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation; 
using System.Windows.Data;
using System.Text.RegularExpressions;
using System.Windows.Controls;
namespace User32
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        User32Entities entities = new User32Entities(); 
        public MainWindow()
        {
            InitializeComponent();
        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                var login = Login.Text;
                var pass = Password.Password;

                var user = entities.Manager.FirstOrDefault(u => u.login == login && u.password == pass);

                bool check = Valid(login, pass);
                if (!check) { return; }

                if (user != null)
                {
                    NavigationWindow window = (NavigationWindow)Application.Current.MainWindow;
                    window.Navigate(new Uri("ManagerWindow.xaml", UriKind.Relative));
                }

                else MessageBox.Show("User not found");
            }
            catch
            {
                MessageBox.Show("try later");
            }
        }

        public bool Valid(string login, string pas)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(pas))
    {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return false;
            }

            if (login.Length > 100 ||  pas.Length > 100)
    {
                MessageBox.Show("Слишком много букв");
                return false;
            }

            return true;

        }
    } 
    }
