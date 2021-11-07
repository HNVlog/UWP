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
using Windows.UI.Xaml.Media.Imaging;
using Universal_App.Services;
using Universal_App.Models.Entity;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Universal_App.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProductDetails : Page
    {
        public ProductDetails()
        {
            this.InitializeComponent();
            RenderCategoriestoburger();
        }
        public async void RenderCategoriestoburger()
        {
            Apiservice apiService = new Apiservice();
            Burger eatburger = await apiService.GetDetailBurger();
            if (eatburger != null)
            {
               
              Products.Items.Add(new Product() { id = eatburger.id, name = eatburger.name, Img = new BitmapImage(new Uri(eatburger.image)), description = eatburger.description, price = eatburger.price });
               
            }
        }
    }
}
