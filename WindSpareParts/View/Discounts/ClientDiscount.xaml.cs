﻿using System;
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

namespace WindSpareParts.View.Discounts
{
    /// <summary>
    /// Interaction logic for ClientDiscount.xaml
    /// </summary>
    public partial class ClientDiscount : Window
    {
        public ClientDiscount()
        {
            InitializeComponent();
        }

        private void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            Get.BackToMain(this);
        }
    }
}
