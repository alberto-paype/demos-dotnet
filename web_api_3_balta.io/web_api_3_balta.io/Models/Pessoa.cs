using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using web_api_3_balta.io.Models.Validations.PessoaValidator;

namespace web_api_3_balta.io.Models
{
    
    [Table("FS_PESSOA")]
    public class Pessoa
    {
        [Key]
        public int Handle { get; set; }

        [Required(ErrorMessage = "Razão Social é obrigatória")]
        public string Razao { get; set; }

        [Required(ErrorMessage = "O Apelido é obrigatória")]
        public string Apelido { get; set; }

        [Required(ErrorMessage = "O Tipo de pessoa é obrigatório.")]
        [RegularExpression("F|J|E", ErrorMessage = "A pessoa pode ser Física, Jurídica ou Estrangeira somente.")] //Físico, Jurídico, Extrangeiro
        public string Tipo { get; set; }

        [IdentificacaoDocumento]
        public string Identificacao { get; set; }

        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }
            
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe se a pessoa é ou não cliente.")]
        public bool Cliente { get; set; }

        [Required(ErrorMessage = "Informe se a pessoa é ou não funcionário.")]
        public bool Funcionário { get; set; }

        [Required(ErrorMessage = "Informe se a pessoa é ou não motorista.")]
        public bool Motorista { get; set; }

        [Required(ErrorMessage = "Informe se a pessoa é ou não transportador.")]
        public bool Transportador { get; set; }

        [Required(ErrorMessage = "Informe se a pessoa é ou não fornecedor.")]
        public bool Fornecedor { get; set; }
        



    }
}
