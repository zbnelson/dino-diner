/*  DrinkSelection.xaml.cs
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
using DDSize = DinoDiner.Menu.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// holds the drink type
        /// </summary>
        private Drink drink;

        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for DrinkSelection.xaml
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            Flavor.IsEnabled = false;
            Lemon.IsEnabled = false;
            Ice.IsEnabled = false;
        }

        /// <summary>
        /// constructor for a selected drink
        /// </summary>
        /// <param name="drink"></param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            if(drink is Sodasaurus)
            {
                Flavor.IsEnabled = true;
                Lemon.IsEnabled = false;
                Ice.IsEnabled = true;
            }
            else if(drink is Tyrannotea)
            {
                Flavor.IsEnabled = true;
                Lemon.IsEnabled = true;
                Ice.IsEnabled = false;
            }
            else if(drink is JurassicJava)
            {
                Flavor.IsEnabled = true;
                Lemon.IsEnabled = false;
                Ice.IsEnabled = true;
            }
            else
            {
                Flavor.IsEnabled = false;
                Lemon.IsEnabled = true;
                Ice.IsEnabled = true;
            }
            this.drink = drink;
        }

        public DrinkSelection(CretaceousCombo c)
        {
            InitializeComponent();
            if (drink is Sodasaurus)
            {
                Flavor.IsEnabled = true;
                Lemon.IsEnabled = false;
                Ice.IsEnabled = true;
            }
            else if (drink is Tyrannotea)
            {
                Flavor.IsEnabled = true;
                Lemon.IsEnabled = true;
                Ice.IsEnabled = false;
            }
            else if (drink is JurassicJava)
            {
                Flavor.IsEnabled = true;
                Lemon.IsEnabled = false;
                Ice.IsEnabled = true;
            }
            else
            {
                Flavor.IsEnabled = false;
                Lemon.IsEnabled = true;
                Ice.IsEnabled = true;
            }
            combo = c;
        }

        /// <summary>
        /// Click action to navigate to FlavorSelection.xaml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectFlavor(object sender, RoutedEventArgs args)
        {
            if (combo == null)
            {
                if (drink is JurassicJava java)
                {
                    java.MakeDecaf();
                }
                else if (drink is Tyrannotea tea)
                {
                    tea.AddSweetener();
                }
                else
                {
                    Sodasaurus soda = (Sodasaurus)drink;
                    NavigationService.Navigate(new FlavorSelection(soda));
                }
            }
            else
            {
                if (combo.Drink is JurassicJava java)
                {
                    java.MakeDecaf();
                }
                else if (combo.Drink is Tyrannotea tea)
                {
                    tea.AddSweetener();
                }
                else
                {
                    Sodasaurus soda = (Sodasaurus)combo.Drink;
                    NavigationService.Navigate(new FlavorSelection(soda));
                }
            }
        }

        /// <summary>
        /// Enables flavor and ice buttons for soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectSoda(object sender, RoutedEventArgs args)
        {
            if (combo == null)
            {
                if (DataContext is Order order)
                {
                    drink = new Sodasaurus();
                    order.Add(drink);
                }
                Flavor.IsEnabled = true;
                Lemon.IsEnabled = false;
                Ice.IsEnabled = true;
            }
            else
            {
                combo.Drink = new Sodasaurus();
                Flavor.IsEnabled = true;
                Lemon.IsEnabled = false;
                Ice.IsEnabled = true;
            }
            
        }

        /// <summary>
        /// enables flavor and lemon for tea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectTea(object sender, RoutedEventArgs args)
        {
            if (combo == null)
            {
                if (DataContext is Order order)
                {
                    drink = new Tyrannotea();
                    order.Add(drink);
                }
                Flavor.IsEnabled = true;
                Lemon.IsEnabled = true;
                Ice.IsEnabled = false;
            }
            else
            {
                combo.Drink = new Tyrannotea();
                Flavor.IsEnabled = true;
                Lemon.IsEnabled = true;
                Ice.IsEnabled = false;
            }
        }

        /// <summary>
        /// enables flavor and ice for Java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectJava(object sender, RoutedEventArgs args)
        {
            if (combo == null)
            {
                if (DataContext is Order order)
                {
                    drink = new JurassicJava();
                    order.Add(drink);
                }
                Flavor.IsEnabled = true;
                Lemon.IsEnabled = false;
                Ice.IsEnabled = true;
            }
            else
            {
                combo.Drink = new JurassicJava();
                Flavor.IsEnabled = true;
                Lemon.IsEnabled = false;
                Ice.IsEnabled = true;
            }
        }

        /// <summary>
        /// enables lemon and ice for water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectWater(object sender, RoutedEventArgs args)
        {
            if (combo == null)
            {
                if (DataContext is Order order)
                {
                    drink = new Water();
                    order.Add(drink);
                }
                Flavor.IsEnabled = false;
                Lemon.IsEnabled = true;
                Ice.IsEnabled = true;
            }
            else
            {
                combo.Drink = new Water();
                Flavor.IsEnabled = false;
                Lemon.IsEnabled = true;
                Ice.IsEnabled = true;
            }
        }

        /// <summary>
        /// adds or holds ice depending on drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnIceClick(object sender, RoutedEventArgs args)
        {
            if (combo == null)
            {
                if (drink is JurassicJava java)
                {
                    java.AddIce();
                }
                else
                    drink.HoldIce();
            }
            else
            {
                if (combo.Drink is JurassicJava java)
                {
                    java.AddIce();
                }
                else
                    combo.Drink.HoldIce();
            }
            
        }

        /// <summary>
        /// click event for adding a lemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnLemonClick(object sender, RoutedEventArgs args)
        {
            if (combo == null)
            {
                if (drink is Tyrannotea tea)
                {
                    tea.AddLemon();
                }
                else
                {
                    Water water = (Water)drink;
                    water.AddLemon();
                }
            }
            else
            {
                if (combo.Drink is Tyrannotea tea)
                {
                    tea.AddLemon();
                }
                else
                {
                    Water water = (Water)combo.Drink;
                    water.AddLemon();
                }
            }
        }

        /// <summary>
        /// sets or changes the size of the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (combo == null)
            {
                if (drink == null)
                {
                    return;
                }
                if (sender is FrameworkElement element)
                {
                    drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                }
            }
            else
            {
                if (sender is FrameworkElement element)
                {
                    combo.Drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                }
            }
        }

        /// <summary>
        /// a on click event for done button to navigate back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDoneClick(object sender, RoutedEventArgs args)
        {
            if (combo == null)
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
            else
            {
                NavigationService.Navigate(new CustomizeComboSelection(combo));
            }
        }
    }
}
