using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp1
{

    class Usuario
    {
        public string nm_usuario { get; set; }
        [Key]
        public int idade { get; set; }
        public string ds_login { get; set; }
        
    }
}
