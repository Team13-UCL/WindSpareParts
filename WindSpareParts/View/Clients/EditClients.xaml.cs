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
using WindSpareParts.ViewModel;

namespace WindSpareParts.View.Clients
{
    /// <summary>
    /// Interaction logic for EditClients.xaml
    /// </summary>
    public partial class EditClients : Window
    {
        public EditClients()
        {
            InitializeComponent();
        }

        private void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            Get.BackToMain(this);
        }

        private void btnNewPerson__Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDeletePerson_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
