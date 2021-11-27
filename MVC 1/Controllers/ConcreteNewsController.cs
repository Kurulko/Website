using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1.Controllers
{
    public class ConcreteNewsController : Controller
    {
        public IActionResult ConcreteNews1() => View();
        public IActionResult ConcreteNews2() => View();        
    }
}
