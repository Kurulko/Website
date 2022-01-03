using MVC_1.Models.Rating;
using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_1.Models.Abstract
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Напишите Ваше имя")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Напишите Вашу фамилию")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }

        public int HighMathId { get; set; }
        public HighMath HighMath { get; set; }
        public int KompBazaId { get; set; }
        public KompBaza KompBaza { get; set; }
        public int MetrologiaId { get; set; }
        public Metrologia Metrologia { get; set; }
        public int OTKId { get; set; }
        public OTK OTK { get; set; }
        public int PhilosophyId { get; set; }
        public Philosophy Philosophy { get; set; }
    }
}
