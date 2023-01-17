﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;
using UTB.Eshop.Domain.Implementation.Validations;

namespace UTB.Eshop.Web.Models.Entities
{
    [Table(nameof(Product))]
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Range(0, double.MaxValue)]
        public double Price { get; set; }

        [NotMapped]
        [FileContent("image")]
        [FileSize(5000000)]
        public virtual IFormFile Image { get; set; }

        [Required]
        [StringLength(255)]
        public string ImageSrc { get; set; }

        public string ImageAlt { get; set; }

    }
}