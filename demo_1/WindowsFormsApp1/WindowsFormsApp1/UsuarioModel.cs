using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApp1
{
    class UsuarioModel : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
    }
}
