/*  FlavorSelection.xaml.cs
*   Author: Zachary Nelson
*/
using DinoDiner.Menu;
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        /// <summary>
        /// backing variable for soda
        /// </summary>
        private Sodasaurus soda;

        /// <summary>
        /// Constructor for FlavorSelection.xaml
        /// </summary>
        public FlavorSelection()
        {
            InitializeComponent();
        }

        public FlavorSelection(Sodasaurus s)
        {
            InitializeComponent();
            soda = s;
        }

        /// <summary>
        /// Click action to navigate to DrinkSelection.xaml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectBack(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnCherryClick(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Cherry;
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// adds cola to flavor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnColaClick(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Cola;
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// adds orange to flavor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnOrangeClick(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Orange;
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// adds vanilla to flavor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnVanillaClick(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Vanilla;
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// adds chocolate to flavor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnChocolateClick(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Chocolate;
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// adds root beer to flavor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnRootBeerClick(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.RootBeer;
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// adds lime to flavor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnLimeClick(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Lime;
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
