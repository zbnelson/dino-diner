/*  MainWindow.xaml.cs
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor for MainWindow
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Order order = new Order();
            //order.Items.Add(new PrehistoricPBJ());
            //order.Items.Add(new Sodasaurus());
            //order.Items.Add(new Fryceritops());
            //SteakosaurusBurger sb = new SteakosaurusBurger();
            //sb.HoldPickle();
            //sb.HoldMustard();
            //order.Items.Add(sb);
            DataContext = order;
            OrderUI.Navigate(new MenuCategorySelection());
            OrderInterface.NavigationService = OrderUI.NavigationService;
        }

        /// <summary>
        /// 
        /// </summary>
        private void PassDataContentToPage()
        {
            if(OrderUI.Content is Page page)
            {
                page.DataContext = OrderUI.DataContext;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            PassDataContentToPage();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            PassDataContentToPage();
        }
    }
}
