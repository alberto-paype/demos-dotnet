using Microsoft.EntityFrameworkCore;
using Migrations.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Migrations.EF.Utils
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> options)
            : base(options)
        { }

        public DbSet<Pessoa> Pessoas { get; set; }

    }


}
