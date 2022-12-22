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

namespace WPFChocolate.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditOrderPage.xaml
    /// </summary>
    public partial class AddEditOrderPage : Page
    {
        List<Product> _product = new List<Product>();
        public AddEditOrderPage(List<Product> products)
        {
            InitializeComponent();
            _product = products;    

        }

        private void AddOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var order = new Sale
                {
                    Date = date.SelectedDate.Value,
                    Client = tbClient.Text
                };

                Entities.GetContext().Sale.Add(order);

                foreach(Product product in _product)
                {
                    var productSale = new ProductSale
                    {
                        IDSale = order.ID,
                        IDProduct = product.ID,
                        Count = product.Count
                    };
                    Entities.GetContext().ProductSale.Add(productSale);
                }
                Entities.GetContext().SaveChanges();
                NavigationService.Navigate(new ChocolateOutputPage());
            }
            catch(Exception ex)
            {
                MessageBox.Show("asd" + ex, "", MessageBoxButton.OK);
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ChocolateOutputPage());
        }
    }
}
