/*  ComboSelection.xaml.cs
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {

        /// <summary>
        /// Constructor for ComboSelection.xaml
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click action to navigate to CustomizeComboSelection.xaml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectCustomize(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeComboSelection());
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
                CretaceousCombo combo = new CretaceousCombo(b);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeComboSelection(combo));
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
                CretaceousCombo combo = new CretaceousCombo(nug);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeComboSelection(combo));
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
                CretaceousCombo combo = new CretaceousCombo(pbj);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeComboSelection(combo));
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
                CretaceousCombo combo = new CretaceousCombo(burger);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeComboSelection(combo));
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
                CretaceousCombo combo = new CretaceousCombo(burger);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeComboSelection(combo));
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
                CretaceousCombo combo = new CretaceousCombo(wrap);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeComboSelection(combo));
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
                PterodactylWings wings = new PterodactylWings();
                CretaceousCombo combo = new CretaceousCombo(wings);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeComboSelection(combo));
            }
        }

        /// <summary>
        /// Click action to navigate to MenuCategorySelection.xaml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectBack(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
