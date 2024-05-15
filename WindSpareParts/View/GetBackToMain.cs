using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace WindSpareParts.View
{
    public static class Get
    {
        public static void BackToMain(Window currentWindow) 
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            currentWindow.Close();
        }
    }
}
