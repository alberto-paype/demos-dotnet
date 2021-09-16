using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CRUD_Clientes.Models
{
    class Cliente
    {
        [Key]
        public int id { get; set; }
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage="CPF Inválido")]
        public string nm_cpf { get; set; }
        public string ds_endereco { get; set; }
    }

}
