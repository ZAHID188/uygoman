using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using uygoman.DATA;
using uygoman.Models;

namespace uygoman.Controllers
{
    public class CompanyController : Controller
    {

        private readonly AppDBContext _db;

        public CompanyController(AppDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<CompanyReg> objList = _db.CompanyRegs;

            return View(objList);
        }
        //get for create 
        public IActionResult Create()
        {

            return View();
        }
        //Post for create 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CompanyReg obj)
        {
            if (ModelState.IsValid)
            {
                _db.CompanyRegs.Add(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
                return View(obj);


        }



        //get - Edit 
        public IActionResult Edit(int? idnum)
        {
            if (idnum == null || idnum == 0)
            {
                return NotFound();
            }
            var obj = _db.CompanyRegs.Find(idnum);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        //Post for edit  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CompanyReg obj)
        {
            if (ModelState.IsValid)
            {
                _db.CompanyRegs.Update(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }
        }

        //get - delete 
        public IActionResult Delete(int? idnum)
        {
            if (idnum == null || idnum == 0)
            {
                return NotFound();
            }
            var obj = _db.CompanyRegs.Find(idnum);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        //Post for delete  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Deletepost(int? ID)
        {
            var obj = _db.CompanyRegs.Find(ID);
            _db.CompanyRegs.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");


        }



    }
}