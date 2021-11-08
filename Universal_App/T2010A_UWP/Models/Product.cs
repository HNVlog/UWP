using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace T2010A_UWP.Models
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public BitmapImage Img { get; set; }
    }
}
