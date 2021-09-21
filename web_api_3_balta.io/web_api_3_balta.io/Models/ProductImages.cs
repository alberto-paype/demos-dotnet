using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web_api_3_balta.io.Models
{
    public class ProductImages
    {
        [Key]
        public int Id { get; set; }

        public string path { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

    }
}
