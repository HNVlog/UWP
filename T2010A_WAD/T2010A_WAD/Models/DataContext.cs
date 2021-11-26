using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace T2010A_WAD.Models
{
    public class DataContext : DbContext
    {
        public DataContext(): base("T2010A") { }

        public DbSet<Category> Categories { get; set; }
    }
}