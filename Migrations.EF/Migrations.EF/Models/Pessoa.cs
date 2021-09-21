using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Migrations.EF.Models
{
    [Table("FS_PESSOA")]
    public class Pessoa
    {
        [Key]
        public string handle { get; set; }
        public string razao { get; set; }
        public string apelido { get; set; }
        public string tipo { get; set; }
        public string identificacao { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string cliente { get; set; }

    }
}
