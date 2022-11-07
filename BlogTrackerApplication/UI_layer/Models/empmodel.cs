using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UI_layer.Models
{
    public class empmodel
    {
        [Key]
        [Required()]
        [EmailAddress]
        public string EmailId { get; set; }
        [Required()]
        [MaxLength(50, ErrorMessage = "Maximum 50 Characters only")]
        public string Name { get; set; }
        [Required()]
        public DateTime DateOfJoining { get; set; }
        [Required()]
        public int PassCode { get; set; }

    }

}