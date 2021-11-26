using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace T2010A_WAD.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        public string CategoryName
        {
            get; set; 
        }
        public string CategoryImage
        {
            get; set;
        }
        public virtual ICollection<Product> Products { get; set; }
    }
}