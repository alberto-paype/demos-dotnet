using Microsoft.EntityFrameworkCore;
using br.com.paype.Models;
using br.com.paype.Models.Fiscal;
using br.com.paype.Models.TI;

namespace br.com.paype.Data
{
    public class DataContextDB : DbContext
    {
        public DataContextDB(DbContextOptions<DataContextDB> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        
        public DbSet<ProductImages> ProductImages { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Pessoa> Pessoa { get; set; }

        public DbSet<Empresa> Empresa { get; set; }

        public DbSet<EmpresaRegime> EmpresaRegime { get; set; }

        public DbSet<Papel> Papel { get; set; }

        public DbSet<PerfilPapel> PerfilPapel { get; set; }

        public DbSet<PapelUsuario> PapelUsuario { get; set; }

        public DbSet<Permissao> Permissao { get; set; }

        public DbSet<Perfil> Perfil { get; set; }

    }
}
