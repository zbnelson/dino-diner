/*  EntreeSelection.xaml.cs
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        private Entree entree;
        
        /// <summary>
        /// Constructor for EntreeSelection.xaml
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        public EntreeSelection(Entree e)
        {
            InitializeComponent();
            entree = e;
        }

        /// <summary>
        /// button click event for Brontowurst
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnBrontowurstClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst b = new Brontowurst();
                order.Add(b);
                NavigationService.Navigate(new BrontowurstCustomization(b));
            }
        }

        /// <summary>
        /// button click event for Dino Nuggets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDinoNuggetClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets nug = new DinoNuggets();
                order.Add(nug);
                NavigationService.Navigate(new DinoNuggetCustomization(nug));
            }
        }

        /// <summary>
        /// button click event for pbj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnPrehistoricPBJClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new PBJCustomization(pbj));
            }
        }

        /// <summary>
        /// button click event for steakosaurus burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSteakosaurusBurgerClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger burger = new SteakosaurusBurger();
                order.Add(burger);
                NavigationService.Navigate(new SteakosaurusBurgerCustomization(burger));
            }
        }

        /// <summary>
        /// button click event for trex burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnTrexKingBurgerClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger burger = new TRexKingBurger();
                order.Add(burger);
                NavigationService.Navigate(new TRexKingBurgerCustomization(burger));
            }
        }

        /// <summary>
        /// button click event for velociwrap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnVelociWrapClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                VelociWrap wrap = new VelociWrap();
                order.Add(wrap);
                NavigationService.Navigate(new VelociWrapCustomization(wrap));
            }
        }

        /// <summary>
        /// button click event for wings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnPterodactylWingsClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// Click action to navigate to MenuCategorySelection.xaml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectBack(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
