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

namespace Refleksja_test001
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VendorClass publicSample;
        VendorClass privateSample;

        public MainWindow()
        {
            InitializeComponent();

            publicSample = new VendorClass();
            privateSample = new VendorClass();
        }

        private string CalculateTime(long elapsedMs)
        {
            return elapsedMs + " m/s";
        }
    }
}
