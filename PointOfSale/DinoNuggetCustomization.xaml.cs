/*  DinoNuggetCustomization.xaml.cs
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
    /// Interaction logic for DinoNuggetCustomization.xaml
    /// </summary>
    public partial class DinoNuggetCustomization : Page
    {

        private bool isCombo = false;
        /// <summary>
        /// private backing variable for DinoNuggets
        /// </summary>
        private DinoNuggets nug;

        /// <summary>
        /// Contstructor for DinoNuggetCustomization
        /// </summary>
        /// <param name="nuggets"></param>
        public DinoNuggetCustomization(DinoNuggets nuggets)
        {
            InitializeComponent();
            nug = nuggets;
        }

        public DinoNuggetCustomization(DinoNuggets nuggets, bool combo)
        {
            InitializeComponent();
            nug = nuggets;
            isCombo = combo;
        }

        /// <summary>
        /// Adds a nugget to DinoNuggets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddNuggetClick(object sender, RoutedEventArgs e)
        {
            nug.AddNugget();
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
