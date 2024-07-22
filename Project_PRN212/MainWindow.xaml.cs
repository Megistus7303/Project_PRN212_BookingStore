using PRN212_Assignment.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace PRN212_Assignment
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string _currentPage;
         private User _loggedInUser;

        public MainWindow(User loggedInUser)
        {
            InitializeComponent();
            DataContext = this;
            CurrentPage = "Home"; // Set trang khởi đầu
            _loggedInUser = loggedInUser;

        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            _loggedInUser = null;
            var loginWindow = new Login();
            loginWindow.Show();
            this.Close();
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

        
    }
}
