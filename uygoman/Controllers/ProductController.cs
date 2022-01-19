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
    public class ProductController : Controller
    {
        private readonly AppDBContext _db;

        public ProductController(AppDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> objList = _db.Products;
            return View(objList);
        }

        //get create
        public IActionResult Create()
        {
          
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product obj)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Add(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
                return View(obj);


        }



        

        //get - delete 
        public IActionResult Delete(string idnum)
        {
            if (idnum == null)
            {
                return NotFound();
            }
            var obj = _db.Products.Where(a => a.ProductName.Equals(idnum)).FirstOrDefault();
            //var obj = _db.CompanyRegs.Find(idnum);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
      
        //Post for delete  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Deletepost(string ProductName)
        {
            var obj = _db.Products.Where(a => a.ProductName.Equals(ProductName)).FirstOrDefault();
            var obj2= _db.CrKeys.Where(a=>a.Product_Name.Equals(ProductName)).FirstOrDefault();
            if (obj2 == null)
            {
                _db.Products.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "The ID and password is incorrect");
                return View(obj2);
            }
            



            //return RedirectToAction("Index");


        }




    }
}