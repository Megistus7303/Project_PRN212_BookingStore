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
    /// Interaction logic for EditBookWindow.xaml
    /// </summary>
    public partial class EditBookWindow : Window
    {
        private Book _book;
        public EditBookWindow(Book book)
        {
            InitializeComponent();
            _book = book;

            tbBookName.Text = book.BookName;
            tbBookQuantity.Text = book.Quantity.ToString();
            tbBookPriceIn.Text = book.PriceInput.ToString();
            tbBookPriceOut.Text = book.PriceOutput.ToString();
            tbGenreName.Text = book.GenreId;
            tbAuthorName.Text = book.AuthorId;
            tbBookDetail.Text = book.Detailbook.ToString();
            
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            using (Prn212AssignmentBookShoppingContext context = new Prn212AssignmentBookShoppingContext())
            {
                var bookToUpdate = context.Books.FirstOrDefault(b => b.BookId == _book.BookId);
                if (bookToUpdate != null)
                {
                    bookToUpdate.BookName = tbBookName.Text;
                    bookToUpdate.Quantity = int.Parse(tbBookQuantity.Text);
                    bookToUpdate.PriceInput = double.Parse(tbBookPriceIn.Text);
                    bookToUpdate.PriceOutput = double.Parse(tbBookPriceOut.Text);
                    bookToUpdate.GenreId = tbGenreName.Text;
                    bookToUpdate.AuthorId = tbAuthorName.Text;
                    bookToUpdate.Detailbook = tbBookDetail.Text;

                    context.SaveChanges();
                }
            }
            this.Close();
        }
    }
}


