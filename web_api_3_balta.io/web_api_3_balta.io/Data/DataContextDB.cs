using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api_3_balta.io.Models;

namespace web_api_3_balta.io.Data
{
    public class DataContextDB : DbContext
    {
        public DataContextDB(DbContextOptions<DataContextDB> options) : base(options) { }

        public DbSet<Product> products { get; set; }
        
        public DbSet<ProductImages> productImages { get; set; }

        public DbSet<Category> categories { get; set; }

        public DbSet<Usuario> usuario { get; set; }

    }
}
