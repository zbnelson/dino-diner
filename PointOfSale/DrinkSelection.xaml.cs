/*  DrinkSelection.xaml.cs
*   Author: Zachary Nelson
*/
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
        /// <summary>
        /// Constructor for DrinkSelection.xaml
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            Flavor.IsEnabled = false;
            Lemon.IsEnabled = false;
            Ice.IsEnabled = false;
        }
        /// <summary>
        /// Click action to navigate to FlavorSelection.xaml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        /// <summary>
        /// Enables flavor and ice buttons for soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectSoda(object sender, RoutedEventArgs args)
        {
            Flavor.IsEnabled = true;
            Lemon.IsEnabled = false;
            Ice.IsEnabled = true;
        }

        /// <summary>
        /// enables flavor and lemon for tea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectTea(object sender, RoutedEventArgs args)
        {
            Flavor.IsEnabled = true;
            Lemon.IsEnabled = true;
            Ice.IsEnabled = false;
        }

        /// <summary>
        /// enables flavor and ice for Java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectJava(object sender, RoutedEventArgs args)
        {
            Flavor.IsEnabled = true;
            Lemon.IsEnabled = false;
            Ice.IsEnabled = true;
        }

        /// <summary>
        /// enables lemon and ice for water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectWater(object sender, RoutedEventArgs args)
        {
            Flavor.IsEnabled = false;
            Lemon.IsEnabled = true;
            Ice.IsEnabled = true;
        }
    }
}
