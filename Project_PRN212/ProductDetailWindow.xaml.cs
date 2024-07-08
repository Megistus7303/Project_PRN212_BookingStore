using Project_PRN212.Models;
using System.Windows;

namespace Project_PRN212
{
    public partial class ProductDetailWindow : Window
    {
        public ProductDetailWindow(dynamic selectedBook)
        {
            InitializeComponent();

            tbBookId.Text = selectedBook.BookId.ToString();
            tbBookName.Text = selectedBook.BookName;
            tbAuthorName.Text = selectedBook.AuthorName;
            tbGenreName.Text = selectedBook.GenreName;
            tbBookQuantity.Text = selectedBook.Quantity.ToString();
            tbBookPriceIn.Text = selectedBook.PriceInput.ToString("C");
            tbBookPriceOut.Text = selectedBook.PriceOutput.ToString("C");
        }
    }
}
