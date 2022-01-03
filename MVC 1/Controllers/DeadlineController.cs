using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_1.Models.Database;
using MVC_1.Models.Deadline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1.Controllers
{
    [Authorize]
    public class DeadlineController : Controller
    {
        IBTSMContext db;
        public DeadlineController(IBTSMContext context)
        {
            db = context;
        }

        public IActionResult Subjects()
        {
            return View(db.DeadLines.Include(d => d.Homework).ToList());
        }

        public IActionResult Homework(int? id)
        {
            if(id != null)
            {
                DeadLine deadLine = db.DeadLines.Include(d => d.Homework).FirstOrDefault(d => d.Id == id);
                if(deadLine != null) {
                    Homework homework = deadLine.Homework;
                    return View(homework);
                }
            }
            return RedirectToAction("Subjects");
        }

        [Authorize(Roles = "mainAdmin,admin")]
        [HttpGet]
        public IActionResult Update(int? id)
        {
            if(id != null)
            {
                DeadLine deadLine = db.DeadLines.Include(d => d.Homework).FirstOrDefault(d => d.Id == id);
                if (deadLine != null)
                    return View(deadLine);
            }
            return RedirectToAction("Subjects");
        }
        [Authorize(Roles = "mainAdmin,admin")]
        [HttpPost]
        public async Task<IActionResult> Update(DeadLine deadLine)
        {
            if (ModelState.IsValid)
            {
                db.Update(deadLine);
                await db.SaveChangesAsync();
            }
            return RedirectToAction("Subjects");
        }

        [Authorize(Roles = "mainAdmin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                DeadLine deadLine = db.DeadLines.Include(d => d.Homework).FirstOrDefault(d => d.Id == id);
                if (deadLine != null)
                {
                    db.DeadLines.Remove(deadLine);
                    await db.SaveChangesAsync();
                }
            }
            else
                ModelState.AddModelError("", "Некорректные данные");
            return RedirectToAction("Subjects");
        }

    }
}
