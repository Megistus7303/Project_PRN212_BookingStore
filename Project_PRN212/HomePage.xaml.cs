using Project_PRN212.Models;
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

namespace Project_PRN212
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public HomePage()
        {
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

            BookDetail bookDetail = new BookDetail(bookFound[3].Trim());
            this.Close();
            bookDetail.Show();
            //bookFound[1];
        }

        private void btnCart_Click(object sender, RoutedEventArgs e)
        {
            ShoppingCart cart = new ShoppingCart("USER001");
            this.Close();
            cart.Show();
        }
    }
}
