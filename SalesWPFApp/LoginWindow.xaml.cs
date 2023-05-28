using Microsoft.Extensions.Configuration;
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
using System.Windows.Shapes;

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        private IConfiguration GetConfiguration()
        {

            IConfiguration config = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
          .Build();
            return config;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtAcc.Text.Length == 0 && txtPass.Text.Length == 0)
            {
                IConfiguration config = GetConfiguration();
                txtAcc.Text = config.GetSection("DefaultAccount:Account").Value;
                txtPass.Text = config.GetSection("DefaultAccount:Password").Value;
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid User\nLogin without account and password to use default account");
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
