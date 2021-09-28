using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace br.com.paype.Models.TI
{
    [Table("TI_PERFIL_PAPEL")]
    public class PerfilPapel
    {
        [Key]
        public int Handle { get; set; }

        [Required]
        public int PerfilHandle { get; set; }

        public Perfil Perfil { get; set; }

        [Required]
        public int PapelHandle { get; set; }

        public Papel Papel { get; set; }

    }
}
