using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace br.com.paype.Models.TI
{
    [Table("TI_PERFIL")]
    public class Perfil
    {
        [Key]
        public int Handle { get; set; }

        [Required]
        public string Nome { get; set; }

    }
}
