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
using _2024_10_11.Model;

namespace _2024_10_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            List<ItemModel> items = new List<ItemModel>
        {
            new ItemModel { Name = "Teams", Url = "pack://application:,,,/Resources/1.png", IsChecked = true },
            new ItemModel { Name = "Lenovo Display Control Center", Url = "pack://application:,,,/Resources/2.png", IsChecked = false },
            new ItemModel { Name = "Lenovo Accessories and Display Manager", Url = "pack://application:,,,/Resources/3.png", IsChecked = false },
            new ItemModel { Name = "联想智会软件", Url = "pack://application:,,,/Resources/4.jpg", IsChecked = false }
        };

            this.DataContext = items;

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            // 关闭当前窗口
            this.Close();
        }

    }
}