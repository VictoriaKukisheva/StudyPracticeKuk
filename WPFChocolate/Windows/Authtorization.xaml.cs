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
using System.Windows.Shapes;
using WPFChocolate.AppConnect;
using WPFChocolate.ApplicationData;

namespace WPFChocolate.Windows
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
            try
            {
                AppConnection.model = new Entities();
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить соединение с базой данных", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public static bool enterAuth(string login, string password)
        {
            try
            {
                var userObj = Entities.GetContext().User.FirstOrDefault(x => x.Login == login && x.Password == password);

                if (userObj == null)
                {
                    return false;
                }
                else if (userObj.Login == login && password == null)
                {
                    return false;
                }
                else
                {
                    SelectedUser.user = userObj;

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = AppConnection.model.User.FirstOrDefault(x => x.Login == loginTb.Text && x.Password == passwordTb.Password);

                if(userObj == null)
                {
                    MessageBox.Show("Не удалось найти пользователя", "Уведомление", MessageBoxButton.OK, 
                        MessageBoxImage.Warning);
                }
                else if (userObj.Login == loginTb.Text && passwordTb.Password == null)
                {
                    MessageBox.Show("Не удалось найти пользователя", "Уведомление", MessageBoxButton.OK, 
                        MessageBoxImage.Warning);
                }
                else
                {
                    SelectedUser.user = userObj;

                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                }
            }
            catch 
            {
                MessageBox.Show("Не удалось выполнить соединение с базой данных", "Уведомление", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Regist_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Registration registration = new Registration();
                registration.Show();
                Close();
            }
            catch
            {
                MessageBox.Show("Не удалось перейти в окно регистрации", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EnterAsGuest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SelectedUser.user = null;

                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            catch
            {
                MessageBox.Show("Не удалось перейти в окно вывода", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
