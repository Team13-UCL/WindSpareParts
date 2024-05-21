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
using WindSpareParts.ViewModel;

namespace WindSpareParts.View.Discounts
{
    /// <summary>
    /// Interaction logic for CreateDiscount.xaml
    /// </summary>
    public partial class CreateDiscount : Window
    {
        public CreateDiscount()
        {
            InitializeComponent();
        }

        private void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            Get.BackToMain(this);
        }
    }
}
