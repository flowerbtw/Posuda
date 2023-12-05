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
using Posuda.db;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Posuda.pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            LoginTextBox.Text = string.Empty;
        }

        private void PasswordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordTextBox.Text = string.Empty;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string enteredLogin = LoginTextBox.Text;
            string enteredPassword = PasswordTextBox.Text;

            User user = DbConnect.dB.Users.FirstOrDefault(p => p.Login == enteredLogin && p.Password == enteredPassword);

            if (user != null)
            {
                bool isAdmin = user.Role == "Администратор";
                /*bool isManager = userProfile != null && userProfile.Role == "Менеджер";*/

                if (isAdmin)
                {
                    NavigationService?.Navigate(new AdminCatalogPage());
                }
                /*else if (isManager)
                {
                    NavigationService?.Navigate(new ManagerCatalogPage());
                }*/
                else
                {
                    NavigationService?.Navigate(new ClientCatalogPage());
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
