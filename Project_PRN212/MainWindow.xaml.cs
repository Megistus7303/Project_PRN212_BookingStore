using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Project_PRN212
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string _currentPage;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            CurrentPage = "Home"; // Set trang khởi đầu
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
