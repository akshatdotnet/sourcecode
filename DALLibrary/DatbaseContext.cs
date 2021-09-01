using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DALLibrary
{
    public class DatbaseContext : DbContext
    {
        /*
         * Enables these commonly used commands:
            Add-Migration
            Drop-Database
            Get-DbContext
            Get-Migration
            Remove-Migration
            Scaffold-DbContext
            Script-Migration
            Update-Database
         * "Data Source = VAISHNAV\SQLEXPRESS; Initial Catalog = DNDBWEB; Integrated Security=True"
         * var connectionString = "Data Source=.\\SQLExpress;Initial Catalog=SmallBakery;Integrated Security=True";
           var providerName = "System.Data.SqlClient";
           var db = Database.OpenConnectionString(connectionString, providerName);
         */
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source = VAISHNAV\SQLEXPRESS; Initial Catalog = DNDBWEB; Integrated Security=True");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
