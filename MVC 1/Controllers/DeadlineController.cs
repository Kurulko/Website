using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1.Controllers
{
    public class DeadlineController : Controller
    {
        public IActionResult Subjects() => View();
    }
}
