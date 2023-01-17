using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTB.Eshop.Web.Models.Entities
{
    [Table(nameof(Coupon))]
    public class Coupon
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Range(0, 100)]
        public int Sale { get; set; }

        [Required]
        [Range(0, 1, ErrorMessage = "Must be 0 or 1 only.")]
        public string Status { get; set; }
    }
}
