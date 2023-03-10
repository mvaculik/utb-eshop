using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using UTB.Eshop.Domain.Implementation.Validations;

namespace UTB.Eshop.Web.Models.Entities
{
    [Table(nameof(CarouselItem))]
    public class CarouselItem
    {
        [Key]
        public int ID { get; set; }


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
