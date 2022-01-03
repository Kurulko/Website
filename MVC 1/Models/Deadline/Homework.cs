using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1.Models.Deadline
{
    public class Homework
    {
        [Display(Name = "На когда")]
        public string LastTime { get; set; }
        [Display(Name = "Само задание")]
        public string Task { get; set; }
        public int Id { get; set; }
        public DeadLine Deadline { get; set; }
        [Display(Name = "Доп ссылка")]
        public string Link { get; set; }

    }
}
