using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_1.Models.Account;
using MVC_1.Models.Database;
using MVC_1.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1.Controllers
{
    [Authorize(Roles = "mainAdmin")]
    public class RolesController : Controller
    {
        IBTSMContext db;
        public RolesController(IBTSMContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Users.Include(u => u.Role).ToList());
        }

        [HttpGet]
        public IActionResult Update(int? id)
        {
            if (ModelState.IsValid && id != null)
            {
                User user = db.Users.Include(u => u.Role).FirstOrDefault(u => u.Id == id);
                if (user != null)
                    return View(new UserAndListRoles { User = user, Roles = db.Roles.ToList() });
            }
            ModelState.AddModelError("", "Некорректные данные!");
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Update(User user)
        {
            if (user != null)
            {
                db.Users.Update(user);
                await db.SaveChangesAsync();
            }
            else
                ModelState.AddModelError("", "Некорректные данные!");

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (ModelState.IsValid && id != null)
            {
                User user = db.Users.Include(u => u.Role).FirstOrDefault(u => u.Id == id);
                if (user != null)
                {
                    db.Users.Remove(user);
                    await db.SaveChangesAsync();
                }
                else
                    ModelState.AddModelError("", "Некорректные данные!");
            }
            else
                ModelState.AddModelError("", "Некорректные данные!");

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new UserAndListRoles { User = null, Roles = db.Roles.ToList() });
        }
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (user != null)
            {
                db.Users.Add(user);
                await db.SaveChangesAsync();
            }
            else
                ModelState.AddModelError("", "Некорректные данные!");

            return RedirectToAction("Index");
        }
    }
}
