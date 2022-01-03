using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using MVC_1.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace MVC_1.Models.Rating
{
    public class Philosophy
    {
        public int Id { get; set; }
        [Display(Name = "Оценки за семинары")]
        public string Seminar { get; set; }
        public Student Student { get; set; }
    }
}
