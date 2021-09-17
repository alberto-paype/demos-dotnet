using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Clientes.Models
{
    class SubMenu
    {
        [Key]
        public int id { get; set; }
        public string ds_titulo { get; set; }
        public string ds_icone { get; set;  }
        public int int_ordem { get; set; }
        public Menu menu { get; set; }
    }
}
