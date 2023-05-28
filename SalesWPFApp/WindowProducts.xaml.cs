using BusinessObject.Models;
using DataAccess.Repository;
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

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for WindowProducts.xaml
    /// </summary>
    public partial class WindowProducts : Window
    {
        ProductRepository productRepository = new ProductRepository();
        public WindowProducts()
        {
            InitializeComponent();
            LoadProduct();
        }
        void LoadProduct()
        {
            lvProducts.ItemsSource = productRepository.GetProducts().ToList();
        }
        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product product = new Product
                {                    
                    CategoryId = Int32.Parse(txtCategoryId.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = Int32.Parse(txtUnitInStock.Text)
                };
                productRepository.Add(product);
                LoadProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product product = new Product
                {
                    ProductId = Int32.Parse(txtProductId.Text),
                    CategoryId = Int32.Parse(txtCategoryId.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = Int32.Parse(txtUnitInStock.Text)
                };
                productRepository.Update(product);
                LoadProduct();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product product = productRepository.GetProduct(Int32.Parse(txtProductId.Text));                
                productRepository.Delete(product);
                LoadProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            LoadProduct();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
