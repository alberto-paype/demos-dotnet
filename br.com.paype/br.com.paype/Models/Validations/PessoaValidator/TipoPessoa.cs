using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using br.com.paype.Models;
using br.com.paype.Models.Fiscal;

namespace br.com.paype.Models.Validations.PessoaValidator
{
    public class TipoPessoa : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var pessoa = (Pessoa)validationContext.ObjectInstance;

            if (pessoa.Tipo == "F")
            {

                if(validationContext.MemberName == "INSS" && pessoa.Motorista)
                {
                    return string.IsNullOrEmpty(value as string) ?
                        new ValidationResult(errorMessage: $"O INSS é obrigatório para motoristas.") :
                        ValidationResult.Success;
                }

                return string.IsNullOrEmpty(value as string) ?
                    new ValidationResult(string.Format("A propriedade '{0}' é obrigatória.", validationContext.DisplayName)) :
                    ValidationResult.Success;
            }
            else if(pessoa.Tipo == "J" && (validationContext.MemberName == "RNTRC" || validationContext.MemberName == "CategoriaRNTRC"))
            {
                return string.IsNullOrEmpty(value as string) ?
                    new ValidationResult(string.Format("A propriedade '{0}' é obrigatória.", validationContext.DisplayName)) :
                    ValidationResult.Success;
            }

            return ValidationResult.Success;

        }
    }
}
