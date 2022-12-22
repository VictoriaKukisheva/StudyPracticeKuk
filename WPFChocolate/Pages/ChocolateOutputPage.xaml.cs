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
    /// Логика взаимодействия для ChocolateOutputPage.xaml
    /// </summary>
    public partial class ChocolateOutputPage : Page
    {
        List<Product> productsList = new List<Product>();

        public ChocolateOutputPage()
        {
            InitializeComponent();
            try
            {
                ShowAdminFunction();
                SetSortItems();
                SetFilterItems();

                lvProducts.ItemsSource = FindProducts();
            }
            catch
            {
                MessageBox.Show("Не работает", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        Product[] FindProducts()
        {
            List<Product> products = AppConnection.model.Product.ToList();

            var productsAll = products;

            if(tbFilter.Text != null)
            {
                products = products.Where(x => x.Name.ToLower().Contains(tbFilter.Text.ToLower())).ToList();

                switch (cbSort.SelectedIndex)
                {
                    case 1:
                        products = products.OrderBy(x => x.Name).ToList();
                        break;
                    case 2:
                        products = products.OrderByDescending(x => x.Name).ToList();
                        break;
                }
            }
            if(cbFitter.SelectedIndex > 0)
            {
                products = products.Where(x => x.Type.Name == cbFitter.SelectedItem.ToString()).ToList();
            }


            if (products.Count != 0)
            {
                tblFinderProduct.Text = "Показано товаров: " + products.Count + " из " + productsAll.Count;
            }
            else
            {
                tblFinderProduct.Text = "Не найдено";
            }

            return products.ToArray();
        }

        private void SetFilterItems()
        {
            cbFitter.Items.Add("<Все типы>");

            foreach(var item in AppConnection.model.Type)
            {
                cbFitter.Items.Add(item.Name);
            }

            cbFitter.SelectedIndex = 0;
        }

        private void SetSortItems()
        {
            cbSort.Items.Add("Без сортировки");
            cbSort.Items.Add("По возрастанию");
            cbSort.Items.Add("По убыванию");

            cbSort.SelectedIndex = 0;
        }

        private void ShowAdminFunction()
        {
            if(SelectedUser.user == null || SelectedUser.user.IDRole != 1)
            {
                AddData.Visibility = Visibility.Hidden;
                changeToOrderPage.Visibility = Visibility.Hidden;
            }
        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lvProducts.SelectedItem != null && SelectedUser.user != null && SelectedUser.user.IDRole == 1)
            {
                Product product = lvProducts.SelectedItem as Product;
                NavigationService.Navigate(new AddEditChocolate(product));
            }
        }

        private void AddData_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditChocolate((sender as Button).DataContext as Product));
        }

        private void tbFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            lvProducts.ItemsSource = FindProducts();
        }

        private void cbFitter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lvProducts.ItemsSource = FindProducts();
        }

        private void cbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lvProducts.ItemsSource = FindProducts();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            AppConnection.model.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
            lvProducts.ItemsSource = FindProducts();
        }

        private void addToOrder_Click(object sender, RoutedEventArgs e)
        {
            productsList.Add(lvProducts.SelectedItem as Product);
            //productsList[productsList.Count -1].ItemCounter++;
            toOrder.Visibility = Visibility.Visible;
        }

        private void toOrder_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frame.Navigate(new OrderPage(productsList));

            if(productsList.Count == 0)
            {
                toOrder.Visibility = Visibility.Hidden;
            }
        }

        private void changeToOrderPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrdersPage());
        }
    }
}
