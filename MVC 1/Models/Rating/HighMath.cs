using MVC_1.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1.Models.Rating
{
    public class HighMath
    {
        public int Id { get; set; }
        [Display(Name = "Оценки за ср-ки")]
        public string SR { get; set; }

        public Student Student { get; set; }
    }
}
