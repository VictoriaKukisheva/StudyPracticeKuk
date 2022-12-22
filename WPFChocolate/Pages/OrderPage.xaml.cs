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
using WPFChocolate.ApplicationData;

namespace WPFChocolate.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        List<Product> _products = new List<Product>();
        public OrderPage(List<Product> products)
        {
            InitializeComponent();
            _products = products;
            lvProducts.ItemsSource = _products;
        }

        private void AddToOrder_Click(object sender, RoutedEventArgs e)
        {
            List<Product> productsToGo = new List<Product>();

            foreach(Product product in lvProducts.Items)
            {
                productsToGo.Add(product);
            }
            NavigationService.Navigate(new AddEditOrderPage(productsToGo));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
