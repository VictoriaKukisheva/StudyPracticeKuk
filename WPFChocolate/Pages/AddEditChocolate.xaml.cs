using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AddEditChocolate.xaml
    /// </summary>
    public partial class AddEditChocolate : Page
    {
        private Product _product = new Product();
        private string namePicture = String.Empty;
        private byte[] _mainImageData = null;

        public AddEditChocolate(Product product)
        {
            InitializeComponent();
            try
            {
                SetTypeItem();
                SetSupplierItem();

                if(product != null)
                {
                    _product = product;

                    FindTypeItem();
                    FindSupplierItem();
                }
                else
                {
                    AddEditData.Content = "Добавть";
                    DeleteData.Visibility = Visibility.Hidden;
                }

                DataContext = _product;
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить соединение с базой данных", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void FindSupplierItem()
        {
            var item = AppConnection.model.Supplier.FirstOrDefault(x => x.ID == _product.IDSupplier);

            cbSupplier.SelectedIndex = item.ID;
        }

        private void FindTypeItem()
        {
            var item = AppConnection.model.Type.FirstOrDefault(x => x.ID == _product.IDType);

            cbType.SelectedIndex = item.ID;
        }

        private void SetSupplierItem()
        {
            cbSupplier.Items.Add("< Все производители >");
            foreach(var item in AppConnection.model.Supplier)
            {
                cbSupplier.Items.Add(item.Name);
            }
        }

        private void SetTypeItem()
        {
            cbType.Items.Add("< Все типы >");
            foreach (var item in AppConnection.model.Type)
            {
                cbType.Items.Add(item.Name);
            }
        }
        String imgName = null;
        private void AddImage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                if (!(bool)openFileDialog1.ShowDialog())
                {
                    return;
                }
                    
                openFileDialog1.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files(*.png)|*.png";
                openFileDialog1.DefaultExt = ".jpeg";

                _product.Image = openFileDialog1.SafeFileName;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message.ToString(), "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddEditData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FindSupplierSelectedItem();
                FindTypeSelectedItem();

                if (_product.ID == 0)
                {
                    Entities.GetContext().Product.Add(_product);
                }
                Entities.GetContext().SaveChanges();
                AppConnection.model.SaveChanges();

                MessageBox.Show("Данные успешно сохранены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

                AppFrame.frame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message.ToString(), "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void FindSupplierSelectedItem()
        {
            try
            {
                var item = AppConnection.model.Type.FirstOrDefault(x => x.Name == cbType.SelectedItem.ToString());
                _product.IDType = item.ID;
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить соединение с базой данных", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void FindTypeSelectedItem()
        {
            try
            {
                var item = AppConnection.model.Supplier.FirstOrDefault(x => x.Name == cbSupplier.SelectedItem.ToString());
                _product.IDSupplier = item.ID;
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить соединение с базой данных", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteData_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Вы уверены?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                AppConnection.model.Product.Remove(_product);
                AppConnection.model.SaveChanges();
                NavigationService.GoBack();
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
