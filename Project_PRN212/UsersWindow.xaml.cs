using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Project_PRN212
{
    public partial class UsersWindow : Window, INotifyPropertyChanged
    {
        private string _currentPage;

        public UsersWindow()
        {
            InitializeComponent();
            DataContext = this;
            CurrentPage = "Users"; // Set trang khởi đầu
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

        private void SortComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
