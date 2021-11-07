using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace Universal_App.Models
{
    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public BitmapImage Img { get; set; }
        public string description { get; set; }
        public int price { get; set; }
    }
}
