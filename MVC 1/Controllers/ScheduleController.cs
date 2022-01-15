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
using Microsoft.EntityFrameworkCore;

namespace MVC_1.Controllers
{
    [Authorize]
    public class ScheduleController : Controller
    {
        IBTSMContext db;
        public ScheduleController(IBTSMContext context)
        {
            db = context;
        }
        public IActionResult Subjects()
        {
            PlacesAndTime placesAndTime = new PlacesAndTime
            {
                NameLinks = db.NameLinks
                .Include(nl => nl.Place)
                .ToList(),
                Time = db.Time.ToList()
            };
            return View(placesAndTime);
        }
    }
}
