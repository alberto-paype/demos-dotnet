using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace br.com.paype.Models.TI
{
    [Table("TI_PERMISSAO")]
    public class Permissao
    {
        [Key]
        public int Handle { get; set; }

        [Required]
        public string Role { get; set; }

    }
}
