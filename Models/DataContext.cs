using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace UrunYonetimi.Models
{
    public class DataContext:DbContext
    {
        public DataContext() : base("datacontext") { }//(localdb)MSSqlLocalDB

        public DbSet<Product> Product { get; set; }

    }
}