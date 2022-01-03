using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using MVC_1.Models.ViewModel;
using MVC_1.Models.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace MVC_1.Controllers
{
    [Authorize]
    public class NewsController : Controller
    {
        IBTSMContext db;
        public NewsController(IBTSMContext context)
        {
            db = context;
        }
        public IActionResult News(int page = 1)
        {
            int count = db.News.Count();
            const int sizePage = 4;
            Page p = new Page(count, sizePage, page);

            List<News> news = db.News.Skip((page - 1) * sizePage).Take(sizePage).ToList();
            NewsAndPage newsAndPage = new NewsAndPage()
            {
                News = news,
                Page = p
            };
            return View(newsAndPage);
        }
        public IActionResult ConcreteNews(int? id)
        {
            if(id != null)
            {
                News news = db.News.FirstOrDefault(n => n.Id == id);
                if (news != null)
                    return View(news);
            }
            return RedirectToAction("News");
        }

        [Authorize(Roles = "mainAdmin,admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if(id != null)
            {
                News news  = db.News.FirstOrDefault(n => n.Id == id);
                if (news != null)
                {
                    db.Remove(news);
                    await db.SaveChangesAsync();
                }
            }
            return RedirectToAction("News");
        }
        [Authorize(Roles = "mainAdmin,admin")]
        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if(id != null)
            {
                News news = await db.News.FirstOrDefaultAsync(n => n.Id == id);
                if (news != null)
                    return View(news);
            }
            return RedirectToAction("News");
        }
        [Authorize(Roles = "mainAdmin,admin")]
        [HttpPost]
        public async Task<IActionResult> Update(News news)
        {
            if (ModelState.IsValid)
            {
                db.News.Update(news);
                await db.SaveChangesAsync();
            }
            else
                ModelState.AddModelError("", "Некорректные данные");

            return RedirectToAction("News");
        }

        [Authorize(Roles = "mainAdmin,admin")]
        [HttpGet]
        public IActionResult Create() => View();
        [Authorize(Roles = "mainAdmin,admin")]
        [HttpPost]
        public async Task<IActionResult> Create(News news)
        {
            if(news != null)
            {
                db.News.Add(news);
                await db.SaveChangesAsync();
            }
            return RedirectToAction("news");
        }
    }
}
