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
    public sealed partial class EatIn : Page
    {
        public EatIn()
        {
            this.InitializeComponent();
            RenderCategoriestoEat();
            RenderCategoriestofood();
        }

        public async void RenderCategoriestoEat()
        {
            Apiservice apiService = new Apiservice();
            Eat eats = await apiService.GetEat();
            if (eats != null)
            {
                foreach (var c in eats.foods)
                {
                    Products.Items.Add(new Product() { id = c.id, name = c.name, Img = new BitmapImage(new Uri(c.image)), description = c.description, price = c.price });
                }
            }
        }

        public async void RenderCategoriestofood()
        {
            Apiservice apiService = new Apiservice();
            Eat eats = await apiService.GetEat();
            if (eats != null)
            {
                foreach (var c in eats.foods)
                {
                    Products.Items.Add(new Product() { id = c.id, name = c.name, Img = new BitmapImage(new Uri(c.image)), description = c.description, price = c.price });
                }
            }
        }
    }
}
