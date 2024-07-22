using Microsoft.EntityFrameworkCore;
using PRN212_Assignment.Models;
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

namespace PRN212_Assignment
{
    public partial class UserAuthorization : Window
    {
        private readonly Prn212AssignmentBookShoppingContext context;
        public UserAuthorization()
        {
            InitializeComponent();
            context = new Prn212AssignmentBookShoppingContext();
            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = context.Users
                .Where(user => user.UserRole != "Manager").
                Select(user => new
                {
                    UserId = user.UserId,
                    Username = user.Username,
                    Role = user.UserRole,
                    Email = user.UserEmail
                }).ToList();
            UserListView.ItemsSource = users;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = SearchUserTextBox.Text.Trim();

            var filteredUsers = context.Users
                .Where(user => user.UserRole != "Manager" && user.Username.Contains(searchTerm))
                .Select(user => new
                {
                    UserId = user.UserId,
                    Username = user.Username,
                    Role = user.UserRole,
                    Email = user.UserEmail
                })
                .ToList();

            UserListView.ItemsSource = filteredUsers;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;

            var user = button.DataContext as User;
            if (user == null) return;

            MessageBoxResult result = MessageBox.Show($"Are you sure you want to delete user {user.Username}?", "Confirm Delete", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                context.Users.Remove(user);
                context.SaveChanges();

                LoadUsers();
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
