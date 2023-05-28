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
    /// Interaction logic for WindowOrders.xaml
    /// </summary>
    public partial class WindowOrders : Window
    {
        OrderRepository repository = new OrderRepository();
        public WindowOrders()
        {
            InitializeComponent();
            LoadOrder();
        }

        void LoadOrder()
        {
            lvOrders.ItemsSource = repository.GetOrders().ToList();
        }
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            LoadOrder();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Order order = new Order
                {                    
                    MemberId = Int32.Parse(txtMemberId.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text)
                };
                repository.Add(order);
                LoadOrder();
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
                Order order = new Order
                {
                    OrderId = Int32.Parse(txtOrderId.Text),
                    MemberId = Int32.Parse(txtMemberId.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text)
                };
                repository.Update(order);
                LoadOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Category");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Order deleteOrder = repository.GetOrder(Int32.Parse(txtOrderId.Text));
                repository.Delete(deleteOrder);
                LoadOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Category");
            }
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
