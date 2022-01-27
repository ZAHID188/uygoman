using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace uygoman.Controllers
{
    public class AdminLteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}