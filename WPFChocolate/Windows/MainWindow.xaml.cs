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
using WPFChocolate.AppConnect;
using WPFChocolate.ApplicationData;
using WPFChocolate.Pages;
using WPFChocolate.Windows;

namespace WPFChocolate
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                AppConnection.model = new Entities();
                AppFrame.frame = frmMain;

                AppFrame.frame.Navigate(new ChocolateOutputPage());

                if(SelectedUser.user == null)
                {
                    userName.Text = "Гость";
                }
                else
                {
                    userName.Text = SelectedUser.user.Login.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить соединение с базой данных", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void quitBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SelectedUser.user = null;

                Auth auth = new Auth();
                auth.Show();
                Close();
            }
            catch
            {
                MessageBox.Show("Не удалось перейти в окно авторизации", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
