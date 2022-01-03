using MVC_1.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1.Models.ViewModel
{
    public class StudentsAndPage
    {
        public List<Student> Students { get; set; }
        public Page Page { get; set; }
    }
}
