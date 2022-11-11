using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace TravelAPI.Models
{
    public class Admin
    {
       
        [Key]
        public int AdminId { get; set; } 
        [Required]
        [EmailAddress]
        public string AdminEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string AdminPassword { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

    }
}