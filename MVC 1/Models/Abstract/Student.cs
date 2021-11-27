using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_1.Models.Abstract
{
    public class Student
    {
        [Required(ErrorMessage = "Need to write Id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Need to write Id")]
        [StringLength(50, ErrorMessage = "Need to Name less 50")]
        public string FirstName { get; set; }
        [StringLength(50, ErrorMessage = "Need to LastName less 50")]
        public string LastName { get; set; }
    }
}
