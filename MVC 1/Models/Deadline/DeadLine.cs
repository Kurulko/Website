using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1.Models.Deadline
{
    public class DeadLine
    {
        [Display(Name = "Имя предмета")]
        [Required(ErrorMessage = "Введите имя предмета")]
        public string NameSubject { get; set; }
        public int HomeworkId { get; set; }
        public Homework Homework { get; set; }
        public int Id { get; set; }
    }
}
