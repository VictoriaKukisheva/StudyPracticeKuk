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

namespace WPFChocolate.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : Page
    {
        public OrdersPage()
        {
            InitializeComponent();
            try
            {
                lvOrders.ItemsSource = AppConnection.model.Sale.ToList();
            }
            catch
            {
                MessageBox.Show("asd", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddToOrder_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выберите товары для корзины.", "", MessageBoxButton.OK);
            NavigationService.Navigate(new ChocolateOutputPage());
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
