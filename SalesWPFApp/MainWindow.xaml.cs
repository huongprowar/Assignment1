﻿using System;
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

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMember_Click(object sender, RoutedEventArgs e)
        {
            WindowMembers windowMember = new();
            windowMember.Show();
            this.Close();
        }

        private void btnProduct_Click(object sender, RoutedEventArgs e)
        {
            WindowProducts windowProduct = new();
            windowProduct.Show();
            this.Close();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            WindowOrders windowOrder = new();
            windowOrder.Show();
            this.Close();
        }
    }
}
