using BLL.Abstract;
using BLL.Concrate;
using BLL.Models;
using DAL.Concrate;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProductWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class PPWindow : Window
    {
        public int Id;
        public PPWindow(int Id)
        {
            InitializeComponent();
            this.Id = Id;
            ProductRepository pt = new ProductRepository();
            IProductService productService = new ProductService(pt);
            var products = productService.GetAll().FirstOrDefault(t => t.Id == Id);
            SpecialDTO product = new SpecialDTO()
            {
                Id = products.Id,
                Name = products.Name,
                Price = products.Price,
                Description = products.Decription,
                ImageF = new BitmapImage(new Uri(Environment.CurrentDirectory + "/" + products.images.ImageF)),
                ImageS = new BitmapImage(new Uri(Environment.CurrentDirectory + "/" + products.images.ImageS)),
                ImageT = new BitmapImage(new Uri(Environment.CurrentDirectory + "/" + products.images.ImageT)),
            };
            productGrid.DataContext = product;
                
            
        }
    }
}
