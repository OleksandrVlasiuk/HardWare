using BLL.Abstract;
using BLL.Concrate;
using DAL.Concrate;
using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace ROZETKA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ProductRepository pt = new ProductRepository();
            IProductService productService = new ProductService(pt);
            var products = productService.GetAll().Select(t=>new {
                Id =t.Id,
                Name =t.Name,
                ImageF =new BitmapImage(new Uri(Environment.CurrentDirectory+"/"+t.images.ImageF)),
                ImageS = new BitmapImage(new Uri(Environment.CurrentDirectory + "/" + t.images.ImageS)),
                ImagesT = new BitmapImage(new Uri(Environment.CurrentDirectory + "/" + t.images.ImageT)),
            }).ToList();
            DataGridProducts.ItemsSource = products;

            CategoryRepository ct = new CategoryRepository();
            ICategoryService categoryService = new CategoryService(ct);
            var data= categoryService.GetCategories();
            DataGridCategories.ItemsSource = data;

        }

        private void TextBox_MouseClick(object sender, MouseButtonEventArgs e)
        {
            Search.Text = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < DataGridProducts.Items.Count; i++)
            {
                string cellContent = Search.Text;
                try
                {
                    if (cellContent != null && DataGridProducts.Items[i].ToString()==cellContent)
                    {
                        DataGridProducts.Items.Clear();
                       //...
                        break;
                    }
                }
                catch { }
            }
        }
    }
}
