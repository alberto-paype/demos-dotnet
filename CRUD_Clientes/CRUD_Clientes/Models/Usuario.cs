using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CRUD_Clientes.Models
{
    class Usuario
    {
        [Key]
        public int id { get; set; }
        public string nm_usuario { get; set; }
        public string ds_login { get; set; }
        public string ds_senha { get; set; }
        
        [EmailAddress(ErrorMessage="E-mail do usuário inválido")]
        public string nm_email { get; set; }
        public bool fl_ativo { get; set; }
    }

}
