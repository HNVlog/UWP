using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_App.Models
{
    class MenuItem
    {
        public string Name { get; set; } //abtract property -- khi nao nap data vào thì mới tốn ô nhớ ->thích hợp dùng cho các model

        public string MenuPage { get; set; }

        public string Icon { get; set; }
    }
}