﻿/*  BrontowurstCustomization.xaml.cs
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
    /// Interaction logic for BrontowurstCustomization.xaml
    /// </summary>
    public partial class BrontowurstCustomization : Page
    {
        private bool isCombo = false;

        private CretaceousCombo combo;
        /// <summary>
        /// private holder for brontowurst
        /// </summary>
        private Brontowurst b;

        /// <summary>
        /// constructor for brontowurst
        /// </summary>
        /// <param name="brontowurst"></param>
        public BrontowurstCustomization(Brontowurst brontowurst)
        {
            InitializeComponent();
            b = brontowurst;
        }

        public BrontowurstCustomization(Brontowurst brontowurst, bool comboBool)
        {
            InitializeComponent();
            b = brontowurst;
            isCombo = comboBool;
        }

        /// <summary>
        /// holds onion from brontowurst object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldOnionClick(object sender, RoutedEventArgs e)
        {
            b.HoldOnion();
        }

        /// <summary>
        /// holds Peppers from brontowurst object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldPepperClick(object sender, RoutedEventArgs e)
        {
            b.HoldPeppers();
        }

        /// <summary>
        /// holds bun from brontowurst object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldBunClick(object sender, RoutedEventArgs e)
        {
            b.HoldBun();
        }

        /// <summary>
        /// navigates to menuselection when done with brontowurst customization
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
