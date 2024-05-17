using System;
using System.Collections.Generic;
using System.DirectoryServices;
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
using WindSpareParts.Model;

namespace WindSpareParts.View.Products
{
    /// <summary>
    /// Interaction logic for ViewProducts.xaml
    /// </summary>
    public partial class ViewProducts : Window
    {
        private ProductRepository productRepository;

        public ViewProducts()
        {
            InitializeComponent();
            productRepository = new ProductRepository();
            PrintAllProducts();
        }

        private void PrintAllProducts()
        {
            
                productRepository.ReadFromFile();
                ProductListBox.Items.Clear(); 
                foreach (List<string> line in productRepository.products) // går igenne hver linje i dataen
                {
                    var itemText = string.Join(", ", line); // joiner linjerne sammen
                    ProductListBox.Items.Add(new ListBoxItem { Content = itemText }); // tilføjer linjerne til listboxen
                }
                        
        }
        private void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            Get.BackToMain(this);
        }
    }
}
