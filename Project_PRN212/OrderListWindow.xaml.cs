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

namespace PRN212_Assignment
{
    /// <summary>
    /// Interaction logic for OrderListWindow.xaml
    /// </summary>
    public partial class OrderListWindow : Window
    {
        public OrderListWindow()
        {
            InitializeComponent();
            Sidebar sidebar = (Sidebar)this.FindName("SidebarControl");
            if (sidebar != null)
            {
                sidebar.CurrentPage = "Orders";
            }
        }

        private void SortComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
