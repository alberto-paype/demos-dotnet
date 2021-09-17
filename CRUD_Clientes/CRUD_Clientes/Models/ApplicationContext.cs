using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CRUD_Clientes.Models
{
    class ApplicationContext : DbContext
    {
        public ApplicationContext(): base("Data Source=HOMOLOGAESCALA;Initial Catalog=teste_demo3;User ID=sa;Password=#escalasoft123") { }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<SubMenu> SubMenu { get; set; }
    }
}
