using Project_PRN212.Models;
using System.Windows;

namespace Project_PRN212
{
    public partial class ProductDetailWindow : Window
    {
        public ProductDetailWindow(Book selectedBook)
        {
            InitializeComponent();
            DataContext = selectedBook;
        }
    }
}
