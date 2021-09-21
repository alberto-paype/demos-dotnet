using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_2.Models
{
    public class Pessoa
    {
        [Key]
        public int id_pessoa { get; set; }
        
        [Required]
        public string nm_completo { get; set; }
        public int idade { get; set; }               
        public int altura { get; set; }
    }


    public class PessoaDbContext: DbContext
    {
        public PessoaDbContext(DbContextOptions builder) : base(builder) { }

        public DbSet<Pessoa> pessoas { get; set; }
    }
}
