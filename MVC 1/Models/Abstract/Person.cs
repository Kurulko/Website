using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_1.Models.Abstract
{
    public class Person
    {
        public bool OnBudget { get; set; } = true;
        public bool OnStepa { get; set; } = false;
        public string Pseudonym {get;set;}
        [Required(ErrorMessage = "Need to write Age")]
        public short Age { get; set; } = 18;
        public int Id { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
