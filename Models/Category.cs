using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ApiAspnetCore.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }

        [MaxLength(255)]
        public string name { get; set; }

        public List<Product> products { get; set; }
    }
}