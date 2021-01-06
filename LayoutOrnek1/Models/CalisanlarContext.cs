using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LayoutOrnek1.Models
{
    public class CalisanlarContext : DbContext
    {
        public CalisanlarContext()
        {
            Database.Connection.ConnectionString = @"Data Source = MADAMEPOLAT\SQLEXPRESS; Initial Catalog = CalisanlarDB;Integrated Security = True";
        }

        public DbSet<Calisan> Calisanlar { get; set; }

      
    }
}