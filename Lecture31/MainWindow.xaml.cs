using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lecture31.Models;

namespace Lecture31
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// if we make a list then this list will not be updated on runtime, so instead we will make a ObservableCollection
        //List<User> userList = new List<User>();

        // ObservableCollection is a collection that provides notifications when items get added, removed, or when the whole list is refreshed.
        ObservableCollection<User> userList = new ObservableCollection<User>();

        public MainWindow()
        {
            InitializeComponent();
            userList.Add(new User() { Name = "Ali", Age = 25 });
            userList.Add(new User() { Name = "Abbass", Age = 25 });
            userList.Add(new User() { Name = "Haider", Age = 25 });
            lstUser.ItemsSource = userList;
        }

        private void BtnAddUser_Click(object sender, RoutedEventArgs e)
        {
            userList.Add(new User() { Name = "New User", Age = 39 });

        }

        private void btnUpdateUser_Click(object sender, RoutedEventArgs e)
        {
            if(lstUser.SelectedItem != null)
            {
                User selectedUser = (User)lstUser.SelectedItem;
                selectedUser.Name = "Updated User";
                selectedUser.Age = 30;
            }
        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if(lstUser.SelectedItem != null)
            {
                userList.Remove((User)lstUser.SelectedItem);
            }
        }
    }
}