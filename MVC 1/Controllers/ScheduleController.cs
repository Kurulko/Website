using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_1.Models.Data.Schedule;
using MVC_1.Models.Abstract.Schedule;
using MVC_1.Models.Database;
using MVC_1.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;

namespace MVC_1.Controllers
{
    [Authorize]
    public class ScheduleController : Controller
    {
        IBTSMContext db;
        Dictionary<string, Place> Links = new Dictionary<string, Place>();
        public ScheduleController(IBTSMContext context)
        {
            db = context;
            Links.Add("math", db.Links.ToList()[0]);
            Links.Add("otk_lection", db.Links.ToList()[1]);
            Links.Add("otk_seminar", db.Links.ToList()[2]);
            Links.Add("metrologia_lection", db.Links.ToList()[3]);
            Links.Add("metrologia_laba", db.Links.ToList()[4]);
            Links.Add("philosophy", db.Links.ToList()[5]);
            Links.Add("komb_baza", db.Links.ToList()[6]);
            Links.Add("komb_baza_laba", db.Links.ToList()[7]);
            Links.Add("", db.Links.ToList()[8]);
        }
        public IActionResult Subjects() => View(new ContextAndLinks(Links,db));
    }
}
