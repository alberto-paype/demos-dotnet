using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace br.com.paype.Models.TI
{
    [Table("TI_USUARIO")]
    public class Usuario
    {
        [Key]
        public int Handle { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

    }
}
