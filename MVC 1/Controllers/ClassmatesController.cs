using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_1.Models.Abstract;
using MVC_1.Models.Data;
using MVC_1.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace MVC_1.Controllers
{
    public class ClassmatesController : Controller
    {
        IBTSMContext db;
        public ClassmatesController(IBTSMContext context)
        {
            db = context;
        }

        public IActionResult Information(int id) => View(new ClassmatesAndContext(db.People.ToList()[id],db.Students.ToList()[id]));
        
    }
    public class ClassmatesAndContext
    {
        public Person Person { get; set; }
        public Student Student { get; set; }
        public ClassmatesAndContext(Person Person, Student Student)
        {
            this.Person = Person;
            this.Student = Student;
        }
    }
}
