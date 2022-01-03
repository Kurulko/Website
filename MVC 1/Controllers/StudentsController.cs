using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_1.Models.Abstract;
using MVC_1.Models.Data;
using MVC_1.Models.Database;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace MVC_1.Controllers
{
    [Authorize]
    public class StudentsController : Controller
    {
        IBTSMContext db;
        public StudentsController(IBTSMContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index() => View(await db.Students.ToListAsync());
    }
}
