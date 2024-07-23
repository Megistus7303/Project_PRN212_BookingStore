﻿using PRN212_Assignment.Models;
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

namespace PRN212_Assignment
{
    /// <summary>
    /// Interaction logic for BookDetailCustomer.xaml
    /// </summary>
    public partial class BookDetailCustomer : Window
    {
        private String bookIDAdd;
        private User UserFound;
        public BookDetailCustomer()
        {
            InitializeComponent();
        }
            public BookDetailCustomer(String bookID,User user)
            {
                UserFound=user;
                this.bookIDAdd = bookID;
                InitializeComponent();
                LoadDetailBooks(bookID);
            }
            private void LoadDetailBooks(String bookID)
            {
                using (Prn212AssignmentBookShoppingContext context = new Prn212AssignmentBookShoppingContext())
                {
                    Book bookFound = context.Books.FirstOrDefault(e => e.BookId == bookID);
                    lblNameBook.Content = "Name Book: " + bookFound.BookName;
                    lblDescription.Content = "Description: " + bookFound.Detailbook;
                    Genre GenreFound = context.Genres.FirstOrDefault(e => e.GenreId == bookFound.GenreId);
                    lblGenre.Content = "Genre: " + GenreFound.GenreName;
                    lblNumber.Content = "Number: " + bookFound.Quantity.ToString();
                    imgImage.Source = new BitmapImage(new Uri(bookFound.Image1));
                    lvCommentList.ItemsSource = context.Comments.Where(e => e.BookId == bookID).Select(e => new
                    {
                        CommentID = e.CommentId,
                        Name = e.User.FirstName + " " + e.User.LastName,
                        Description = e.Comment1
                    }).ToList();
                }
            }
            private void btnAddtoCart_Click(object sender, RoutedEventArgs e)
            {

                int QuantityBuy = int.Parse(txtQuantity.Text);
                String quantityString = lblNumber.Content.ToString().Substring(8).Trim();
                int Quantity = int.Parse(quantityString);
                if (QuantityBuy <= 0 || QuantityBuy > Quantity)
                {
                    MessageBox.Show("You input wrong number");
                }
                else
                {
                    ShoppingCart shoppingCart = new ShoppingCart(bookIDAdd, UserFound.UserId, QuantityBuy);
                    this.Close();
                    shoppingCart.Show();

                }
            }

            private void btnHomePage_Click(object sender, RoutedEventArgs e)
            {
                HomePage homePage = new HomePage();
                this.Close();
                homePage.Show();
            }

            private void btnCart_Click(object sender, RoutedEventArgs e)
            {
                ShoppingCart cart = new ShoppingCart(UserFound.UserId);
                this.Close();
                cart.Show();
            }
            private String generateNextCommentID()
            {
                using (Prn212AssignmentBookShoppingContext context = new Prn212AssignmentBookShoppingContext())
                {
                    // Get the maximum numeric part of the CartId
                    int maxNumericPart = context.Comments.AsEnumerable()
                        .Select(e => int.Parse(e.CommentId.Substring(3)))
                        .Max();

                    // Format the result back to the CRTxxx format
                    string maxCartID = $"CMT{maxNumericPart + 1:D3}";
                    return maxCartID;
                }
            }
            private void btnSend_Click(object sender, RoutedEventArgs e)
            {
                String Comment = tbxComment.Text;
                Comment CommentAdd = new Comment
                {
                    CommentId = generateNextCommentID(),
                    BookId = bookIDAdd,
                    UserId = UserFound.UserId,
                    Comment1 = Comment,
                };
                using (Prn212AssignmentBookShoppingContext context = new Prn212AssignmentBookShoppingContext())
                {
                    context.Comments.Add(CommentAdd);
                    context.SaveChanges();
                    LoadDetailBooks(bookIDAdd);

                }
            }

            private void btnRemove_Click(object sender, RoutedEventArgs e)
            {
                Button button = sender as Button;
                if (button != null)
                {
                    // Get the DataContext of the button, which is the CartItem
                    String CommentID = button.DataContext.ToString();
                    using (Prn212AssignmentBookShoppingContext context = new Prn212AssignmentBookShoppingContext())
                    {
                        Comment commentFound = context.Comments.FirstOrDefault(e => e.CommentId == CommentID);
                        if (commentFound != null && commentFound.UserId.Equals(UserFound.UserId))
                        {
                            context.Comments.Remove(commentFound);
                            context.SaveChanges();
                            LoadDetailBooks(bookIDAdd);
                        }
                        else
                        {
                            MessageBox.Show("You can't remove this comment");
                        }
                    }
                }
            }
        }
    }