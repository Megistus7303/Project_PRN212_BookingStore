using Project_PRN212.Models;
using System.ComponentModel;
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
            CurrentPage = "Products"; // Set trang khởi đầu
            LoadBook();
           
        }

        public void LoadBook()
        {
            using (Prn212AssignmentBookShoppingContext context = new Prn212AssignmentBookShoppingContext())
            {
                //var rs = context.Authors.ToList();
                //bookAuthor.ItemsSource = rs.Select(e => e.AuthorName);

                var rs2 = context.Books.ToList();
                lvBooks.ItemsSource = rs2.Select(e => new {
                    bookId = e.BookId,
                    bookName = e.BookName,
                    bookQuantity =e.Quantity,
                    bookPriceIn = e.PriceInput,
                    bookPriceOut = e.PriceOutput,
                    bookGenre = e.Genre,
                    bookAuthor = e.AuthorId,

                   authorName = context.Authors.FirstOrDefault(a => a.AuthorId == e.AuthorId).AuthorName,
                   genreName = context.Genres.FirstOrDefault(a => a.GenreId == e.GenreId).GenreName,


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



    }
}
