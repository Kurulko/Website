using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using MVC_1.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace MVC_1.Models.Rating
{
    public class OTK
    {
        public int Id { get; set; }

        [Display(Name = "Оценки за дз-шки")]
        public string DZ { get; set; }
        [Display(Name = "Оценки за кр-ки")]
        public string KR { get; set; }
        [Display(Name = "Оценки за лаьы")]
        public string Laba { get; set; }

        public Student Student { get; set; }
    }
}
