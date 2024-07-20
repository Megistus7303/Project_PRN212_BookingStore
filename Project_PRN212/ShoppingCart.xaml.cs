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
    /// Interaction logic for ShoppingCart.xaml
    /// </summary>
    public partial class ShoppingCart : Window
    {
        public ShoppingCart()
        {
            InitializeComponent();
        }
        public ShoppingCart(String UserID)
        {
            InitializeComponent();
            LoadedCart(UserID);
        }
        public ShoppingCart(String BookID, String UserID, int Quantity)
        {
            InitializeComponent();
            using (Prn212AssignmentBookShoppingContext context = new Prn212AssignmentBookShoppingContext())
            {
                Book book = context.Carts.Where(e => e.UserId == UserID && e.BookId == BookID).Select(e => e.Book).FirstOrDefault();
                if (book == null)
                {
                    Book bookFound = context.Books.FirstOrDefault(e => e.BookId == BookID);
                    Cart cart = new Cart
                    {
                        CartId = generatenextCartID(),
                        BookId = BookID,
                        UserId = UserID,
                        BookName = bookFound.BookName,
                        Quantity = Quantity,
                        BookPrice = Quantity * (bookFound.PriceOutput),
                        BookImg = bookFound.Image1
                    };
                    context.Carts.Add(cart);
                    context.SaveChanges();
                }
                else
                {
                    Cart cart = context.Carts.FirstOrDefault(e => e.UserId == UserID && e.BookId == BookID);
                    cart.BookPrice = cart.BookPrice + Quantity * book.PriceOutput;
                    cart.Quantity = cart.Quantity + Quantity;
                    context.SaveChanges();
                }

            }
            LoadedCart(UserID);
        }

        private void LoadedCart(String UserID)
        {
            using (Prn212AssignmentBookShoppingContext context = new Prn212AssignmentBookShoppingContext())
            {
                var list = context.Carts.Where(e => e.UserId == UserID).ToList();
                lvCartList.ItemsSource = list;
                double totalcost = 0;
                foreach (var item in list)
                {
                    totalcost = totalcost + item.BookPrice;
                }
                lblTotalPrice.Content = "Total: " + totalcost;
            }

        }

        private String generatenextCartID()
        {
            using (Prn212AssignmentBookShoppingContext context = new Prn212AssignmentBookShoppingContext())
            {
                // Get the maximum numeric part of the CartId
                int maxNumericPart = context.Carts.AsEnumerable()
                    .Select(e => int.Parse(e.CartId.Substring(3)))
                    .Max();

                // Format the result back to the CRTxxx format
                string maxCartID = $"CRT{maxNumericPart + 1:D3}";
                return maxCartID;
            }
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            // Get the button that was clicked
            Button button = sender as Button;
            if (button != null)
            {
                // Get the DataContext of the button, which is the CartItem
                String cartID = button.DataContext.ToString();
                using (Prn212AssignmentBookShoppingContext context = new Prn212AssignmentBookShoppingContext())
                {
                    Cart cart = context.Carts.FirstOrDefault(e => e.CartId == cartID);
                    if (cart != null)
                    {
                        context.Carts.Remove(cart);
                        context.SaveChanges();
                        LoadedCart(cart.UserId);
                    }
                }
            }
        }

        private void btnHomePage_Click(object sender, RoutedEventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Close();
            homePage.Show();
        }
    }
}
