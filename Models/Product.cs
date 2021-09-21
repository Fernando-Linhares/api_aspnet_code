using System;
using System.ComponentModel.DataAnnotations;

namespace ApiAspnetCore.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }

        [MaxLength(255)]
        public string name { get; set; }

        public decimal price { get; set; }

        public Category category { get; set; }

        public DateTime created_at { get; set; }

        public DateTime updated_at { get; set; }
    }
}