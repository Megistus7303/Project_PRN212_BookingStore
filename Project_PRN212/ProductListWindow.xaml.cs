using PRN212_Assignment.Models;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace Project_PRN212
{
    public partial class ProductListWindow : Window, INotifyPropertyChanged
    {
        private string _currentPage;

        public ProductListWindow()
        {
            InitializeComponent();
            DataContext = this;
            CurrentPage = "Products"; // Set initial page
            LoadBook();
        }

        public void LoadBook()
        {
            using (Prn212AssignmentBookShoppingContext context = new Prn212AssignmentBookShoppingContext())
            {
                var books = context.Books.ToList();
                lvBooks.ItemsSource = books.Select(e => new
                {
                    Book = e, // Include the Book object
                    e.BookId,
                    e.BookName,
                    e.Quantity,
                    e.PriceInput,
                    e.PriceOutput,
                    AuthorName = context.Authors.FirstOrDefault(a => a.AuthorId == e.AuthorId)?.AuthorName,
                    GenreName = context.Genres.FirstOrDefault(g => g.GenreId == e.GenreId)?.GenreName
                }).ToList();
            }
        }

        public string CurrentPage
        {
            get { return _currentPage; }
            set
            {
                if (_currentPage != value)
                {
                    _currentPage = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void SortComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        private void DetailsButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedBook = ((FrameworkElement)sender).DataContext;
            ProductDetailWindow detailWindow = new ProductDetailWindow(selectedBook);
            detailWindow.ShowDialog();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                var selectedBook = button.DataContext as dynamic;
                if (selectedBook != null)
                {
                    Book book = selectedBook.Book;
                    EditBookWindow editWindow = new EditBookWindow(book);
                    editWindow.ShowDialog();
                    LoadBook(); // Reload the book list to reflect changes
                }
                else
                {
                    MessageBox.Show("Selected book is null.");
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                var selectedBook = button.DataContext as dynamic; // Use dynamic to access anonymous type properties
                if (selectedBook != null)
                {
                    Book book = selectedBook.Book; // Access the Book object
                    MessageBoxResult result = MessageBox.Show($"Are you sure you want to delete {book.BookName}?", "Delete Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (result == MessageBoxResult.Yes)
                    {
                        using (Prn212AssignmentBookShoppingContext context = new Prn212AssignmentBookShoppingContext())
                        {
                            var bookToDelete = context.Books.FirstOrDefault(b => b.BookId == book.BookId);
                            if (bookToDelete != null)
                            {
                                context.Books.Remove(bookToDelete);
                                context.SaveChanges();
                            }
                        }
                        LoadBook(); // Reload the book list to reflect changes
                    }
                }
                else
                {
                    MessageBox.Show("Selected book is null.");
                }
            }
        }

        private void AddNewBookButton_Click(object sender, RoutedEventArgs e)
        {
            AddBookWindow addBookWindow = new AddBookWindow();
            addBookWindow.ShowDialog();
            LoadBook(); // Reload the book list to reflect the new book
        }
    }
}
