using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UI_layer.Models
{
    public class Adminmodel
    {
        [Key]
        [Required()]
        [EmailAddress]
        public string EmailId { get; set; }
        [Required()]
        public string Password { get; set; }
    }

}