/*  CustomizeComboSelection.xaml.cs
*   Author: Zachary Nelson
*/
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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeComboSelection.xaml
    /// </summary>
    public partial class CustomizeComboSelection : Page
    {
        private bool isCombo = true;
        private CretaceousCombo combo;
        /// <summary>
        /// Constructor for CustomizeComboSelection.xaml
        /// </summary>
        public CustomizeComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// constructor to include a combo
        /// </summary>
        /// <param name="c"></param>
        public CustomizeComboSelection(CretaceousCombo c)
        {
            InitializeComponent();
            combo = c;
        }

        /// <summary>
        /// Click action to navigate to SideSelection.xaml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(combo));
        }

        /// <summary>
        /// Click action to navigate to CustomizeComboSelection.xaml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectEntree(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is Brontowurst brot)
                NavigationService.Navigate(new BrontowurstCustomization(brot, isCombo));
            else if (combo.Entree is DinoNuggets nug)
                NavigationService.Navigate(new DinoNuggetCustomization(nug, isCombo));
            else if (combo.Entree is PrehistoricPBJ pbj)
                NavigationService.Navigate(new PBJCustomization(pbj, isCombo));
            else if (combo.Entree is SteakosaurusBurger burger)
                NavigationService.Navigate(new SteakosaurusBurgerCustomization(burger, isCombo));
            else if (combo.Entree is TRexKingBurger burg)
                NavigationService.Navigate(new TRexKingBurgerCustomization(burg, isCombo));
            else if (combo.Entree is VelociWrap wrap)
                NavigationService.Navigate(new VelociWrapCustomization(wrap, isCombo));
            else
                NavigationService.Navigate(new CustomizeComboSelection(combo));
        }

        /// <summary>
        /// Click action to navigate to DrinkSelection.xaml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(combo));
        }

        void OnSmallClick(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Small;
        }

        void OnMediumClick(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Medium;
        }

        void OnLargeClick(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Large;
        }

        /// <summary>
        /// Click action to navigate to ComboSelection.xaml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectBack(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new ComboSelection());
        }
    }
}
