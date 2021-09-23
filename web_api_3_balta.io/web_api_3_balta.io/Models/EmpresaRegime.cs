using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace web_api_3_balta.io.Models
{
    [Table("FS_EMPRESAREGIME")]
    public class EmpresaRegime
    {
        [Key]
        public int Handle { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }


    }
}
