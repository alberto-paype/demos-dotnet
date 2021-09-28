using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using br.com.paype.Models.Validations.PessoaValidator;

namespace br.com.paype.Models.Fiscal
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

        [Required(ErrorMessage = "O documento de indentificação é obrigatório.")]
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


        [Display(Name = "Naturalidade")]
        [TipoPessoa]
        public string Naturalidade { get; set; }

        [Display(Name = "Estado civil")]
        [RegularExpression("S|C|D", ErrorMessage = "Informe se a pessoa é solteira, casada ou divorciada.")] //Solteiro, Casado, Divorciado
        [TipoPessoa]
        public string EstadoCivil { get; set; }

        [RegularExpression("F|M|NI", ErrorMessage = "Informe o gênero da pessoa.")] //Feminino, Masculino, Não Informado
        [TipoPessoa]
        public string Genero { get; set; }

        [Display(Name = "Data de nascimento")]
        [TipoPessoa]
        public DateTime? DataNascimento { get; set; }

        [Display(Name = "Quantidade de dependentes")]
        [TipoPessoa]
        public int Dependentes { get; set; }

        [Display(Name = "Nome do pai")]
        [TipoPessoa]
        public string NomePai { get; set; }

        [Display(Name = "Nome da mãe")]
        [TipoPessoa]
        public string NomeMae { get; set; }

        [Display(Name = "Registro geral (RG)")]
        [TipoPessoa]
        public string RG { get; set; }

        [Display(Name = "Órgão Emissor")]
        [TipoPessoa]
        public string OrgaoEmissor { get; set; }

        [Display(Name = "Data de emissão")]
        [TipoPessoa]
        public DateTime? DataEmissao { get; set; }

        [Display(Name = "INSS")]
        [TipoPessoa]
        public string INSS { get; set; }

        [Display(Name = "RNTRC")]
        [TipoPessoa]
        public string RNTRC { get; set; }

        [Display(Name = "Categoria RNTRC")]
        [RegularExpression("TAC|ETC|CTC")]
        [TipoPessoa]
        public string CategoriaRNTRC { get; set; }


    }
}
