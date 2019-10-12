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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
            Flavor.IsEnabled = false;
            Lemon.IsEnabled = false;
            Ice.IsEnabled = false;
        }

        void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
        void SelectSoda(object sender, RoutedEventArgs args)
        {
            Flavor.IsEnabled = true;
            Lemon.IsEnabled = false;
            Ice.IsEnabled = true;
        }
        void SelectTea(object sender, RoutedEventArgs args)
        {
            Flavor.IsEnabled = true;
            Lemon.IsEnabled = true;
            Ice.IsEnabled = false;
        }
        void SelectJava(object sender, RoutedEventArgs args)
        {
            Flavor.IsEnabled = true;
            Lemon.IsEnabled = false;
            Ice.IsEnabled = true;
        }
        void SelectWater(object sender, RoutedEventArgs args)
        {
            Flavor.IsEnabled = false;
            Lemon.IsEnabled = true;
            Ice.IsEnabled = true;
        }
    }
}
