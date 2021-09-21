using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web_api_3_balta.io.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Título obrigatório")]
        [MaxLength(60, ErrorMessage = "O título precisa ser de no Máximo 20 caracteres")]
        [MinLength(3, ErrorMessage = "O título precisa ser de no minimo 3 caracteres")]
        public string Title { get; set; }

        public virtual List<Product> Products { get; set; }


    }
}
