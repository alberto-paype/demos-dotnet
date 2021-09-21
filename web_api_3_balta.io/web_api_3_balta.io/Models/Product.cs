using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web_api_3_balta.io.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Título obrigatório")]
        [MaxLength(60, ErrorMessage = "O título precisa ser de no Máximo 20 caracteres")]
        [MinLength(3, ErrorMessage = "O título precisa ser de no minimo 3 caracteres")]
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "O título precisa ser de no Máximo 1024 caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Preço obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O Preço precisa ser maior que 0.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Categoria obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Categoria Obrigatório")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public List<ProductImages> Images { get; set; }

    }
}
