using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_1.Models.Abstract
{
    public class Person
    {
        [Display(Name = "На бютжете?")]
        public bool OnBudget { get; set; } = true;
        [Display(Name = "На степе?")]
        public bool OnStepa { get; set; } = false;
        [Display(Name = "Псевдоним")]
        public string Pseudonym {get;set;}
        [Display(Name = "Возраст")]
        [Required(ErrorMessage = "Напишите Ваш возраст")]
        public short Age { get; set; } = 18;
        public int Id { get; set; }
        [EmailAddress]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Напишите Ваш Email")]
        public string Email { get; set; }

        public Student Student { get; set; }
    }
}
