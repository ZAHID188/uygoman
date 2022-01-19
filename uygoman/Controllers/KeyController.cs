using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using uygoman.DATA;
using uygoman.Models;

namespace uygoman.Controllers
{
    public class KeyController : Controller
    {
        private readonly AppDBContext _db;

        public KeyController(AppDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<CrKey> objList = _db.CrKeys;
            return View(objList);
        }

        public IActionResult Create()
        {
            ViewBag.Product_Name = new SelectList(_db.Products,"ProductName", "ProductName");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CrKey obj)
        {
            if (ModelState.IsValid)
            {
                _db.CrKeys.Add(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
                return View(obj);


        }

        //get - delete 
        public IActionResult Delete(int? idnum)
        {
            if (idnum == null || idnum == 0)
            {
                return NotFound();
            }
            var obj = _db.CrKeys.Find(idnum);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        //Post for delete  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Deletepost(int?ID)
        {
            var obj = _db.CrKeys.Find(ID);
            _db.CrKeys.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");


        }

    }
}