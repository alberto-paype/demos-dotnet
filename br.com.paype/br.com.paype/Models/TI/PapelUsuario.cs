using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace br.com.paype.Models.TI
{
    [Table("TI_PAPEL_USUARIO")]
    public class PapelUsuario
    {
        [Key]
        public int Handle { get; set; }

        [Required]
        public int PapelHandle { get; set; }

        public Papel Papel { get; set; }

        [Required]
        public int UsuarioHandle { get; set; }

        public Usuario Usuario { get; set; }


    }
}
