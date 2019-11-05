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
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : UserControl
    {
        public NavigationService NavigationService { get; set; }
        public OrderList()
        {
            InitializeComponent();
        }

            /// <summary>
            ///  removes an item from order
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="args"></param>
        private void RemoveItem(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(sender is FrameworkElement element)
                {
                    if(element.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }

        /// <summary>
        /// navigates based on selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectionChanged(object sender, EventArgs args)
        {
            if(OrderItems.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection(side));
            }

            if (OrderItems.SelectedItem is Drink drink)
            {
                NavigationService?.Navigate(new DrinkSelection(drink));
            }

            if (OrderItems.SelectedItem is DinoNuggets nug)
            {
                NavigationService?.Navigate(new DinoNuggetCustomization(nug));
            }

            if (OrderItems.SelectedItem is Brontowurst b)
            {
                NavigationService?.Navigate(new BrontowurstCustomization(b));
            }

            if (OrderItems.SelectedItem is PrehistoricPBJ pbj)
            {
                NavigationService?.Navigate(new PBJCustomization(pbj));
            }

            if (OrderItems.SelectedItem is SteakosaurusBurger burger)
            {
                NavigationService?.Navigate(new SteakosaurusBurgerCustomization(burger));
            }

            if (OrderItems.SelectedItem is TRexKingBurger tb)
            {
                NavigationService?.Navigate(new TRexKingBurgerCustomization(tb));
            }

            if (OrderItems.SelectedItem is VelociWrap wrap)
            {
                NavigationService?.Navigate(new VelociWrapCustomization(wrap));
            }

            if (OrderItems.SelectedItem is PterodactylWings wings)
            {
                NavigationService?.Navigate(new EntreeSelection(wings));
            }

            if (OrderItems.SelectedItem is CretaceousCombo combo)
            {
                NavigationService?.Navigate(new CustomizeComboSelection(combo));
            }
        }
    }
}
