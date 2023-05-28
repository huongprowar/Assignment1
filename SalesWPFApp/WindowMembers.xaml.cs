using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Linq;
using System.Windows;

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for WindowMembers.xaml
    /// </summary>
    public partial class WindowMembers : Window
    {
        MemberRepository memberRepository = new MemberRepository();
        public WindowMembers()
        {
            InitializeComponent();
            LoadMembers();
        }
        private void LoadMembers()
        {
            lvMembers.ItemsSource = memberRepository.GetMembers().ToList();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            LoadMembers();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Member member = new Member
                {
                    Email = txtEmail.Text.Trim(),
                    CompanyName = txtCompanyName.Text.Trim(),
                    City = txtCity.Text.Trim(),
                    Country = txtCountry.Text.Trim(),
                    Password = txtPassword.Text.Trim()
                };
                memberRepository.Add(member);
                LoadMembers();
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
                Member member = new Member
                {
                    MemberId = Int32.Parse(txtMemberId.Text),
                    Email = txtEmail.Text.Trim(),
                    CompanyName = txtCompanyName.Text.Trim(),
                    City = txtCity.Text.Trim(),
                    Country = txtCountry.Text.Trim(),
                    Password = txtPassword.Text.Trim()
                };
                memberRepository.Update(member);
                LoadMembers();
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
                Member deleteMember = memberRepository.GetMember(Int32.Parse(txtMemberId.Text));
                memberRepository.Delete(deleteMember);
                LoadMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
