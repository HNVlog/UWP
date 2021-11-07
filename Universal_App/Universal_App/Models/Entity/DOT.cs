using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_App.Models.Entity
{
    // home
    public class home
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public int price { get; set; }
    }

    public class homes
    {
        public string message { get; set; }
        public List<home> data { get; set; }
    }

    //eat in
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
    }

    public class Food
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public int price { get; set; }
    }

    public class Eat
    {
        public Category category { get; set; }
        public List<Food> foods { get; set; }
    }

    public class Eats
    {
        public string message { get; set; }
        public Eat data { get; set; }
    }

    //detail

    public class Burger
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public int price { get; set; }
    }

    public class Burgers
    {
        public string message { get; set; }
        public Burger data { get; set; }
    }

}