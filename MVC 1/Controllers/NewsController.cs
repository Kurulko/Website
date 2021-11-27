using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult News() => View();
    }
}
