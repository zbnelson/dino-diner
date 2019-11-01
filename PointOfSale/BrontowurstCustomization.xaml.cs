/*  BrontowurstCustomization.xaml.cs
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

        private Brontowurst b;
        public BrontowurstCustomization(Brontowurst brontowurst)
        {
            InitializeComponent();
            b = brontowurst;
        }

        private void OnHoldOnionClick(object sender, RoutedEventArgs e)
        {
            b.HoldOnion();
        }

        private void OnHoldPepperClick(object sender, RoutedEventArgs e)
        {
            b.HoldPeppers();
        }

        private void OnHoldBunClick(object sender, RoutedEventArgs e)
        {
            b.HoldBun();
        }

        void OnDoneClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
