/*  PBJCustomization.xaml.cs
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
    /// Interaction logic for PBJCustomization.xaml
    /// </summary>
    public partial class PBJCustomization : Page
    {

        private bool isCombo = false;
        /// <summary>
        /// backing varibale for prehistoricpbj
        /// </summary>
        private PrehistoricPBJ pbj;
        
        /// <summary>
        /// constructor for pbjCustomization
        /// </summary>
        /// <param name="p">a prehistoricpbj</param>
        public PBJCustomization(PrehistoricPBJ p)
        {
            InitializeComponent();
            pbj = p;
        }

        public PBJCustomization(PrehistoricPBJ p, bool combo)
        {
            InitializeComponent();
            pbj = p;
            isCombo = combo;
        }

        /// <summary>
        /// holds Peanut Butter from Prehistoricpbj object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldPeanutButterClick(object sender, RoutedEventArgs e)
        {
            pbj.HoldPeanutButter();
        }

        /// <summary>
        /// holds Jelly from Prehistoricpbj object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldJellyClick(object sender, RoutedEventArgs e)
        {
            pbj.HoldJelly();
        }

        /// <summary>
        /// navigates to menuselection when done with prehistoricpbj customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDoneClick(object sender, RoutedEventArgs e)
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
