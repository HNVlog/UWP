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
using T2010A_UWP.Models.Entity;
using T2010A_UWP.Services;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2010A_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Categories : Page
    {
        public Categories()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Category category = e.Parameter as Category;
            CategoryName.Text = category.name;
            // Da co category -> lay api du lieu ve
            RenderFoods(category);
        }
        //new
        private async void RenderFoods(Category category)
        {
            Apiservice service = new Apiservice();
            CategoryDetail categoryDetail = await service.CategoryDetail(category);
            if (categoryDetail != null)
            {
                foreach (var f in categoryDetail.data.foods)
                {
                    Products.Items.Add(f);
                }
            }
        }
    }
}