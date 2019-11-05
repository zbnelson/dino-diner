/*  TRexKingBurgerCustomization.xaml.cs
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
    /// Interaction logic for TRexKingBurgerCustomization.xaml
    /// </summary>
    public partial class TRexKingBurgerCustomization : Page
    {
        private bool isCombo = false;

        private TRexKingBurger burger;
        public TRexKingBurgerCustomization(TRexKingBurger tb)
        {
            InitializeComponent();
            burger = tb;
        }

        public TRexKingBurgerCustomization(TRexKingBurger tb, bool combo)
        {
            InitializeComponent();
            burger = tb;
            isCombo = combo;
        }

        /// <summary>
        /// holds pickles from steakosaurusburger object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldPickleClick(object sender, RoutedEventArgs e)
        {
            burger.HoldPickle();
        }

        /// <summary>
        /// holds bun from steakosaurusburger object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldBunClick(object sender, RoutedEventArgs e)
        {
            burger.HoldBun();
        }

        /// <summary>
        /// holds ketchup from steakosaurusburger object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldKethcupClick(object sender, RoutedEventArgs e)
        {
            burger.HoldKetchup();
        }

        /// <summary>
        /// holds mustard from steakosaurusburger object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldMustardClick(object sender, RoutedEventArgs e)
        {
            burger.HoldMustard();
        }

        /// <summary>
        /// holds lettuce from steakosaurusburger object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldLettuceClick(object sender, RoutedEventArgs e)
        {
            burger.HoldLettuce();
        }

        /// <summary>
        /// holds onion from steakosaurusburger object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldOnionClick(object sender, RoutedEventArgs e)
        {
            burger.HoldOnion();
        }

        /// <summary>
        /// holds tomato from steakosaurusburger object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldTomatoClick(object sender, RoutedEventArgs e)
        {
            burger.HoldTomato();
        }

        /// <summary>
        /// holds mayo from steakosaurusburger object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldMayoClick(object sender, RoutedEventArgs e)
        {
            burger.HoldMayo();
        }

        /// <summary>
        /// navigates to menuselection when done with nugget customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnDoneClick(object sender, RoutedEventArgs args)
        {
            if (isCombo)
            {
                NavigationService.GoBack();
            }
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
