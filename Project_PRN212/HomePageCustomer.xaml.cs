﻿using Microsoft.VisualBasic.ApplicationServices;
using PRN212_Assignment.Models;
using PRN212_Assignment;
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
using User = PRN212_Assignment.Models.User;
namespace PRN212_Assignment
{
    /// <summary>
    /// Interaction logic for HomePageCustomer.xaml
    /// </summary>
    public partial class HomePageCustomer : Window
    {
        User userFound= new User();
        public HomePageCustomer(User user)
        {
            InitializeComponent();
            userFound= user;
            btnUserProfile.Content = "Hello, " + user.Username;
            using (Prn212AssignmentBookShoppingContext context = new Prn212AssignmentBookShoppingContext())
            {
                lvBookList.ItemsSource = context.Books.Select(e => new {
                    BookImage = e.Image1,
                    BookId = e.BookId,
                    BookName = e.BookName,
                    AuthorName = e.Author.AuthorName.ToString(),
                    GenreName = e.Genre.GenreName,
                    Quantity = e.Quantity,
                    Price = e.PriceOutput
                }).ToList();
            }

        }


        private void lvBookList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String a = lvBookList.SelectedItem.ToString();
            String[] bookFound = a.Split(new char[] { '[', '=', ',' });

            BookDetailCustomer bookDetail = new BookDetailCustomer(bookFound[3].Trim(), userFound);
            this.Close();
            bookDetail.Show();
        }

        private void btnCart_Click(object sender, RoutedEventArgs e)
        {
            ShoppingCart cart = new ShoppingCart(userFound.UserId);
            this.Close();
            cart.Show();
        }

        private void btnUserProfile_Click(object sender, RoutedEventArgs e)
        {
            userProfile userProfile = new userProfile(userFound);
            userProfile.Show();
            this.Close();

        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
