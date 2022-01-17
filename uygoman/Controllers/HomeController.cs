using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using uygoman.DATA;
using uygoman.Models;

namespace uygoman.Controllers
{
    public class HomeController : Controller
    {
        

        private readonly AppDBContext _db;

        public HomeController(AppDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {

            return View();
        }


        //Post for create 
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public IActionResult Login(Admin obj)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        return RedirectToAction("Company");
        //    }

        //    else
        //    {
        //        return View(obj);
        //    }

        //}

        public ActionResult Login(Admin Alogin)
        {
            if (ModelState.IsValid)
            {

                {
                    var obj = _db.Admins.Where(a => a.UserID.Equals(Alogin.UserID) && a.Password.Equals(Alogin.Password)).FirstOrDefault();
                    if (obj != null)
                    {

                        return RedirectToAction("Company");


                    }
                    else
                    {
                        ModelState.AddModelError("", "The username and password is incorrect");
                    }

                }
            }
            return View(Alogin);

        }



        public IActionResult Company()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
