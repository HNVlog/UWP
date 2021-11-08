using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2010A_UWP.Models.Entity;

namespace T2010A_UWP.Models
{
    class MenuItem
    {
       // private string name;// attribute + fiel private public protected defaul
       // public string Name { get => name; set => name = value;}// property

        public string Name { get; set; } //abtract property -- khi nao nap data vào thì mới tốn ô nhớ ->thích hợp dùng cho các model

        public string MenuPage { get; set; }

        public string Icon { get; set; }
        //new
        public Category Category { get; set; }

    }
}
