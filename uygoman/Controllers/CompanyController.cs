using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using uygoman.DATA;
using uygoman.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace uygoman.Controllers
{
    public class CompanyController : Controller
    {

        private readonly AppDBContext _db;
        //private readonly IWebHost _iwebhost;
        private readonly IHostingEnvironment _iwebhost;

        public CompanyController(AppDBContext db, IHostingEnvironment iwebhost)
        {
            _db = db;
            _iwebhost = iwebhost;
        }
        public IActionResult Index()
        {
            IEnumerable<CompanyReg> objList = _db.CompanyRegs;

            return View(objList);
        }

        //Search functionality

        [HttpGet]
        public IActionResult Index(string search)
        {
            ViewData["CompanyDetails"] = search;
            var Cmpquery = from x in _db.CompanyRegs select x;
            if (!string.IsNullOrEmpty(search))
            {
                Cmpquery = Cmpquery.Where(x => x.CmpName.Contains(search) || x.Email.Contains(search));

            }


            return View(Cmpquery);
        }


        //get for create 
        public IActionResult Create()
        {

            return View();
        }
        //Post for create 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormFile ifile,CompanyReg obj)
        {
            
            



            if (ModelState.IsValid)
            {
                //  image file
                if (ifile != null)
                {
                    string imgget = Path.GetExtension(ifile.FileName);
                    if (imgget == ".jpg" || imgget == ".gif")
                    {
                        var saveimg = Path.Combine(_iwebhost.ContentRootPath, "wwwroot/images", ifile.FileName);
                        var stream = new FileStream(saveimg, FileMode.Create);
                        ifile.CopyToAsync(stream);

                        //obj.Upload = ifile.FileName;
                        obj.Upload = saveimg;

                    }
                }
                //End of image file

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