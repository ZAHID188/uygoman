using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using uygoman.DATA;
using uygoman.Models;

namespace uygoman.Controllers
{
    public class SecurityController : Controller
    {

        private readonly AppDBContext _db;

        private readonly IDataProtector _dataProtector;
        public SecurityController(IDataProtectionProvider data, AppDBContext db)
        {
            this._dataProtector = data.CreateProtector("thisissecretkey");
            _db = db;

        }
        

        public IActionResult Create()
        {
            ViewBag.Product_Name = new SelectList(_db.Products, "ProductName", "ProductName");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CrKey obj)
        {

            if (ModelState.IsValid)
            {
                string encryptkey = this._dataProtector.Protect(obj.Keys);
                string decrypt = this._dataProtector.Unprotect(encryptkey);
                obj.Keys = encryptkey;
                _db.CrKeys.Add(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
                return View(obj);


        }

        public IActionResult Index()
        {
            
            IEnumerable<CrKey> objList = _db.CrKeys;
            foreach(var item in objList)
            {
                var item2 = item.Keys;
               string decrypt = this._dataProtector.Unprotect(item.Keys);
                item.Keys=decrypt;

            }
           
            return View(objList);
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
        public IActionResult Deletepost(int? ID)
        {
            var obj = _db.CrKeys.Find(ID);
            _db.CrKeys.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");


        }
    }
}