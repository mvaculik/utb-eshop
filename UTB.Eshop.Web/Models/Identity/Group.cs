using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTB.Eshop.Web.Models.Identity
{
    public class Group
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Must be 0 or 100 only.")]
        public int Sale { get; set; }

    }
}
