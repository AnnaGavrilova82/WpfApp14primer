using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp14primer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Хлеб",
                Price = 50,
                Priority = 1,
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Фен",
                Price = 7550,
                Priority = 2,
                ProductType = ProductTypes.Technics
            });
            products.Add(new Product()
            {
                ProductName = "Пылесос",
                Price = 27550,
                Priority = 3,
                ProductType = ProductTypes.Technics
            });
            lstBox.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product()
            {
                ProductName = "Масло сливочное",
                Price = 550,
                Priority = 4,
                ProductType = ProductTypes.Food
            });
        }
    }
}
