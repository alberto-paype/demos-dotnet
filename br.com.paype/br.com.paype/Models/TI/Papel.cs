using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace br.com.paype.Models.TI
{
    [Table("TI_PAPEL")]
    public class Papel
    {
        [Key]
        public int Handle { get; set; }

        [Required]
        public string Policy { get; set; }

        [ForeignKey("Permissao")]
        public int PermissaoHandle { get; set; }

        public Permissao Permissao { get; set; }

    }
}
