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
    public class IdentificacaoDocumento : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var pessoa = (Pessoa)validationContext.ObjectInstance;
            if (pessoa.Tipo == "E")
                return ValidationResult.Success;

            var identificacao = value as string;
            if (pessoa.Tipo == "F")
            {
                Regex r = new(@"^([0-9]){3}\.([0-9]){3}\.([0-9]){3}-([0-9]){2}$");
                return r.IsMatch(identificacao) ? ValidationResult.Success : new ValidationResult("CPF para pessoa física inválido!");
            }

            if (pessoa.Tipo == "J")
            {
                Regex r = new(@"\d{2,3}.\d{3}.\d{3}/\d{4}-\d{2}");
                return r.IsMatch(identificacao) ? ValidationResult.Success : new ValidationResult("CNPJ para pessoa jurídica inválido!");
            }

            return ValidationResult.Success;
            
        }
    }
}
