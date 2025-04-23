using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
namespace User32
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User32Entities entities = new User32Entities(); 
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new TransportWindow());
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
                    MainFrame.Navigate(new ManagerWindow());
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
