/*  VelociWrapCustomization.xaml.cs
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
    /// Interaction logic for VelociWrapCustomization.xaml
    /// </summary>
    public partial class VelociWrapCustomization : Page
    {

        private bool isCombo = false;
        /// <summary>
        /// private backing variable for velociwrap
        /// </summary>
        private VelociWrap wrap;

        /// <summary>
        /// constructor for VelociwrapCustomization
        /// </summary>
        /// <param name="v">velociwrap</param>
        public VelociWrapCustomization(VelociWrap v)
        {
            InitializeComponent();
            wrap = v;
        }

        public VelociWrapCustomization(VelociWrap v, bool combo)
        {
            InitializeComponent();
            wrap = v;
            isCombo = combo;
        }

        public VelociWrapCustomization(CretaceousCombo combo)
        {
            InitializeComponent();
            wrap = (VelociWrap)combo.Entree;
        }

        /// <summary>
        /// onclick event for holding lettuce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldlettuceClick(object sender, RoutedEventArgs e)
        {
            wrap.HoldLettuce();
        }

        /// <summary>
        /// onclick event for holding Dressing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldDressingClick(object sender, RoutedEventArgs e)
        {
            wrap.HoldDressing();
        }

        /// <summary>
        /// onclick event for holding Cheese
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldCheeseClick(object sender, RoutedEventArgs e)
        {
            wrap.HoldCheese();
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
