using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.Web.Models
{
    public class Customer
    {
        [Key]
        [Column(Order = 1)]
        public Guid CustomerID { get; set; }

        [Required]
        [MaxLength(128)]
        public string CustomerName { get; set; }

        [Required]
        [MaxLength(128)]
        public string CustomerSurName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
