using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace br.com.paype.Models.Fiscal
{
    [Table("FS_EMPRESA")]
    public class Empresa
    {
        [Key]
        public int Handle { get; set; }

        public string Nome { get; set; }

        public string Sigla { get; set; }

        public string Logo { get; set; }

        public string CertificadoDigital { get; set; }

        public string SenhaCertificado { get; set; }

        public DateTime VencimentoCertificado { get; set; }

        public int RegimeEstadualHandle { get; set; }

        public EmpresaRegime RegimeEstadual { get; set; }

        public int RegimeFederalHandle { get; set; }

        public EmpresaRegime RegimeFederal { get; set; }
    }

}
