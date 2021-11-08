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
using T2010A_UWP.Models;
using T2010A_UWP.Services;
using T2010A_UWP.Models.Entity;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2010A_UWP
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
            var item1 = new MenuItem() { Name = "Home", MenuPage = "homepage", Icon = "\uE80F" };
            var item2 = new MenuItem() { Name = "Infomation", MenuPage = "infomation", Icon = "\uE946" };
            var item3 = new MenuItem() { Name = "Demo", MenuPage = "demo", Icon = "\uE946" };

            Menu.Items.Add(item1);
            Menu.Items.Add(item2);
            Menu.Items.Add(item3);
            RenderCategoriesToMenu();
        }
        public async void RenderCategoriesToMenu()
        {
            // chi viec goi object cuar ApiService vao dung
            Apiservice apiService = new Apiservice();
            Categories categories = await apiService.GetCategories();
            if (categories != null)
            {
                foreach (var c in categories.data)
                {
                    Menu.Items.Add(new MenuItem() { Name = c.name, Icon = "\uE946", MenuPage = "category", Category = c });
                }
            }
        }

        private void IconClick_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SP.IsPaneOpen = !SP.IsPaneOpen;
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selected = (MenuItem)Menu.SelectedItem;//Item ma' duoc chon de nhan vao
            switch (selected.MenuPage)
            {
                case "homepage":
                    MainFrame.Navigate(typeof(Pages.Home));
                    break;
                case "infomation":
                    MainFrame.Navigate(typeof(Pages.DemoForm));
                    break;
                case "demo":
                    MainFrame.Navigate(typeof(Pages.Demo));
                    break;
                    //new
                case "category": MainFrame.Navigate(typeof(Pages.Categories), selected.Category); break;

            }
        }
    }
}