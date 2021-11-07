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
using Universal_App.Models.Entity;
using Universal_App.Models;
using Windows.UI.Xaml.Media.Imaging;
using Universal_App.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Universal_App.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
            RenderCategoriesToHome();
        }
        public async void RenderCategoriesToHome()
        {
            Apiservice apiService = new Apiservice();
            homes categories = await apiService.GetHome();
            if (categories != null)
            {
                foreach (var c in categories.data)
                {
                    Products.Items.Add(new Product() {id=c.id, name = c.name, Img=new BitmapImage(new Uri(c.image)), description =c.description, price = c.price });
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // MainFrame.Navigate(typeof(Pages.Home));
            next.Navigate(typeof(Pages.ProductDetails));
        }
    }
}
