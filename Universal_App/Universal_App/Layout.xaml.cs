using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Universal_App.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Universal_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Layout : Page
    {
        public Layout()
        {
            this.InitializeComponent();

            MainFrame.Navigate(typeof(Pages.Home));
            var item1 = new MenuItem() { Name = "Home", MenuPage = "Home", Icon = "\uE80F" };
            var item2 = new MenuItem() { Name = "Eat in", MenuPage = "Eat in", Icon = "\uE715" };
            var item3 = new MenuItem() { Name = "Colection", MenuPage = "Colection", Icon = "\uE826" };
            var item4 = new MenuItem() { Name = "Delivery", MenuPage = "Delivery", Icon = "\uE77B" };
            var item5 = new MenuItem() { Name = "Take Away", MenuPage = "Take Away", Icon = "\uE715" };
            var item6 = new MenuItem() { Name = "Driver Payment", MenuPage = "Driver Payment", Icon = "\uE826" };
            var item7 = new MenuItem() { Name = "Customers", MenuPage = "Customers", Icon = "\uE77B" };
            Menu.Items.Add(item1);
            Menu.Items.Add(item2);
            Menu.Items.Add(item3);
            Menu.Items.Add(item4);
            Menu.Items.Add(item5);
            Menu.Items.Add(item6);
            Menu.Items.Add(item7);
        }
        private void IconClick_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SPI.IsPaneOpen = !SPI.IsPaneOpen;
        }


        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selected = (MenuItem)Menu.SelectedItem;// item mà được chọn để nhấn vào
            switch (selected.MenuPage)
            {
                case "Home": MainFrame.Navigate(typeof(Pages.Home)); break;
                case "Eat in": MainFrame.Navigate(typeof(Pages.EatIn)); break;
                case "Colection": MainFrame.Navigate(typeof(Pages.Colection)); break;
                case "Delivery": MainFrame.Navigate(typeof(Pages.Delivery)); break;
                case "Take Away": MainFrame.Navigate(typeof(Pages.TakeAway)); break;
                case "Driver Payment": MainFrame.Navigate(typeof(Pages.DriverPayment)); break;
                case "Customers": MainFrame.Navigate(typeof(Pages.Customers)); break;
            }
        }
    }
}
