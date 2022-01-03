using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_1.Models.Abstract;
using MVC_1.Models.Data;
using MVC_1.Models.Database;
using Microsoft.EntityFrameworkCore;
using MVC_1.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;

namespace MVC_1.Controllers
{
    [Authorize]
    public class ClassmatesController : Controller
    {
        IBTSMContext db;
        public ClassmatesController(IBTSMContext context)
        {
            db = context;
        }

        public IActionResult Information(int id)
        {
            Student student = db.Students.Include(s => s.Person).FirstOrDefault(p => p.Id == id);
            return View(student);
        }

        [Authorize(Roles = "mainAdmin,admin")]
        [HttpGet]
        public IActionResult Update(int? id)
        {
            if(id != null)
            {
                Student student = db.Students
                    .Include(s => s.HighMath)
                    .Include(s => s.KompBaza)
                    .Include(s => s.Metrologia)
                    .Include(s => s.OTK)
                    .Include(s => s.Philosophy)
                    .Include(s => s.Person).FirstOrDefault(p => p.Id == id);
                
                if(student != null)
                    return View(student);
            }
            return RedirectToAction("Information",new {id = id });
        }
        [Authorize(Roles = "mainAdmin,admin")]
        [HttpPost]
        public async Task<IActionResult> Update(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Update(student);
                await db.SaveChangesAsync();
            }
            else
                ModelState.AddModelError("", "Некорректные данные");

            return RedirectToAction("Information", new { id = student.Id });
        }

        [Authorize(Roles = "mainAdmin")]
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Student student = db.Students
                    .Include(s => s.HighMath)
                    .Include(s => s.KompBaza)
                    .Include(s => s.Metrologia)
                    .Include(s => s.OTK)
                    .Include(s => s.Philosophy)
                    .Include(s => s.Person)
                    .FirstOrDefault(p => p.Id == id);

                if (student != null)
                {
                    db.Students.Remove(student);
                    await db.SaveChangesAsync();
                }
            }
            return RedirectToAction("Information", new { id = id });
        }
    }
}
