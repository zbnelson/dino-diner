/*  SteakosaurusBurgerCustomization.xaml.cs
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
    /// Interaction logic for SteakosaurusBurgerCustomization.xaml
    /// </summary>
    public partial class SteakosaurusBurgerCustomization : Page
    {
        private bool isCombo = false;
        /// <summary>
        /// private backing variable for steakosaurusburger
        /// </summary>
        private SteakosaurusBurger burger;

        /// <summary>
        /// constructor for steakosaurusburgercustomization
        /// </summary>
        /// <param name="b"></param>
        public SteakosaurusBurgerCustomization(SteakosaurusBurger b)
        {
            InitializeComponent();
            burger = b;
        }

        public SteakosaurusBurgerCustomization(SteakosaurusBurger b, bool combo)
        {
            InitializeComponent();
            burger = b;
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
