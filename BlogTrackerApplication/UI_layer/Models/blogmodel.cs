using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UI_layer.Models
{
    public class blogmodel
    {
        [Key]
        [Required()]
        public int BlogId { get; set; }
        [Required()]

        [MaxLength(20, ErrorMessage = "Maximum 50 Characters only")]
        public string Title { get; set; }
        [Required()]
        [MaxLength(50, ErrorMessage = "Maximum 50 Characters only")]
        public string Subject { get; set; }
        [Required()]

        public DateTime DateOfCreation { get; set; }
        [Required()]

        public string BlogUrl { get; set; }
        [Required()]
       
        public string EmpEmailId { get; set; }
    }

}