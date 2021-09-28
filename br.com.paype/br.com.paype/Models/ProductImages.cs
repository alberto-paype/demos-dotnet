using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace br.com.paype.Models
{
    public class ProductImages
    {
        [Key]
        public int Id { get; set; }

        public string Path { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

    }
}
