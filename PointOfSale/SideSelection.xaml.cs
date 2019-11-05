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
using DDSize = DinoDiner.Menu.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {

        private CretaceousCombo combo;
        private Side side;
        /// <summary>
        /// Constructor for SideSelection.xaml
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        public SideSelection(CretaceousCombo c)
        {
            InitializeComponent();
            combo = c;
        }

        /// <summary>
        /// constuctor with a side passed in.
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }

        /// <summary>
        /// /// <summary>
        /// button click event for fryceritops
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {
            if (combo == null)
            {
                if (DataContext is Order order)
                {
                    side = new Fryceritops();
                    order.Add(side);
                }
            }
            else
            {
                combo.Side = new Fryceritops();
            }

        }

        /// <summary>
        /// button click event for Mac and Cheese
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            if (combo == null)
            {
                if (DataContext is Order order)
                {
                    side = new MeteorMacAndCheese();
                    order.Add(side);
                }
            }
            else
            {
                combo.Side = new MeteorMacAndCheese();
            }
        }

        /// <summary>
        /// button click event for Mezzorella sticks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            if (combo == null)
            {
                if (DataContext is Order order)
                {
                    side = new MezzorellaSticks();
                    order.Add(side);
                }
            }
            else
            {
                combo.Side = new MezzorellaSticks();
            }
        }

        /// <summary>
        /// button click event for triceritots
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTriceritots(object sender, RoutedEventArgs args)
        {
            if (combo == null)
            {
                if (DataContext is Order order)
                {
                    side = new Triceritots();
                    order.Add(side);
                }
            }
            else
            {
                combo.Side = new Triceritots();
            }
        }

        /// <summary>
        /// Changes the side of the side and navigates back to menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (combo == null)
            {
                if (side == null)
                {
                    return;
                }
                if (sender is FrameworkElement element)
                {
                    side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
            else
            {
                if (sender is FrameworkElement element)
                {
                    combo.Side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                    NavigationService.Navigate(new CustomizeComboSelection(combo));
                }
            }
        }

        /// <summary>
        /// onclick event to navigate back a page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
