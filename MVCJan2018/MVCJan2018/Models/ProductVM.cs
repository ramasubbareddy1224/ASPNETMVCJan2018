using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCJan2018.Models
{
    public class ProductVM
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "enter product name")]
        [MinLength(5, ErrorMessage = "minimum 5 character require")]
        public string Name { get; set; }

        [Required(ErrorMessage = "enter product price")]

        public decimal Price { get; set; }
    }
}