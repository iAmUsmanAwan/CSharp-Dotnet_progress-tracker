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

namespace Lecture36
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new MessageViewModel();
        }

        /// through the code-behind (Events), tight coupling
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show(txtMessage.Text);
        //}
    }
}