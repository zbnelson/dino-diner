﻿/*  ComboSelection.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// Constructor for ComboSelection.xaml
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click action to navigate to CustomizeComboSelection.xaml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectCustomize(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeComboSelection());
        }

        /// <summary>
        /// Click action to navigate to MenuCategorySelection.xaml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectBack(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
