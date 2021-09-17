using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Clientes.Models
{
    class Menu
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string ds_titulo { get; set; }
        public string ds_icone { get; set; }        
        public virtual List<SubMenu> Sub_menus { get; set; }

    }
}
