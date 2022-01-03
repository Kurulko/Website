using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_1.Models.Data;
using MVC_1.Models.Rating;
using MVC_1.Models.Abstract;
using MVC_1.Models.Database;
using Microsoft.EntityFrameworkCore;
using MVC_1.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;

namespace MVC_1.Controllers
{
    [Authorize]
    public class RatingController : Controller
    {
        IBTSMContext db;
        public RatingController(IBTSMContext context)
        {
            db = context;
        }
        public IActionResult Subjects(int page = 1)
        {
            int count = db.Students.Count();
            const int sizePage = 6;
            ViewBag.SizePage = sizePage;
            Page p = new Page(count, sizePage, page);

            List<Student> students = db.Students
                .Include(s => s.Person)
                .Include(s => s.HighMath)
                .Include(s => s.KompBaza)
                .Include(s => s.Metrologia)
                .Include(s => s.OTK)
                .Include(s => s.Philosophy)
                .Skip((page - 1) * sizePage).Take(sizePage).ToList();
            StudentsAndPage studentsAndPage = new StudentsAndPage()
            {
                Students = students,
                Page = p
            };
            return View(studentsAndPage);
        }
        [Authorize(Roles = "mainAdmin,admin")]
        [HttpGet]
        public IActionResult Update(int? id)
        {
            if (id != null)
            {
                Student student = db.Students
                        .Include(s => s.Person)
                        .Include(s => s.HighMath)
                        .Include(s => s.KompBaza)
                        .Include(s => s.Metrologia)
                        .Include(s => s.OTK)
                        .Include(s => s.Philosophy)
                        .FirstOrDefault(a => a.Id == id);
                if (student != null)
                {
                    return View(student);
                }
            }
            return RedirectToAction("Subjects");
        }
        [Authorize(Roles = "mainAdmin,admin")]
        [HttpPost]
        public async Task<IActionResult> Update(Student student)
        {
            if (/*ModelState.IsValid*/student != null)
            {
                db.HighMathScores.Update(student.HighMath);
                db.PhilosophyScores.Update(student.Philosophy);
                db.KompBazaScores.Update(student.KompBaza);
                db.MetrologiaScores.Update(student.Metrologia);
                db.OTKScores.Update(student.OTK);

                await db.SaveChangesAsync();
            }
            else
                ModelState.AddModelError("", "Некорректные данные");

            return RedirectToAction("Subjects");
        }
        [Authorize(Roles = "mainAdmin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Student student = db.Students
                    .Include(s => s.Person)
                    .Include(s => s.HighMath)
                    .Include(s => s.KompBaza)
                    .Include(s => s.Metrologia)
                    .Include(s => s.OTK)
                    .Include(s => s.Philosophy)
                    .FirstOrDefault(a => a.Id == id);
                if (student != null)
                    db.Students.Remove(student);

                await db.SaveChangesAsync();
            }
            return RedirectToAction("Subjects");
        }
    }
}
