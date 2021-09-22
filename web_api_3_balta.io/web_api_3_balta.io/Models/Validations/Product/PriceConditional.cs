using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Produto = web_api_3_balta.io.Models.Product;

namespace web_api_3_balta.io.Models.Validations.Product
{
    public class RequireWhenTitleAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var product = (web_api_3_balta.io.Models.Product)validationContext.ObjectInstance;
            if (product.Title == "test")
                return ValidationResult.Success;

            var price = value as decimal?;

            return price < 10
                ? new ValidationResult("O preço nao pode ser menor que 10 quando o titulo é diferente test.")
                : ValidationResult.Success;
        }
    }

}
