using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using desarrolloweb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace desarrolloweb.Controllers
{
    public class ProductoController : Controller
    {

        desarrollowebContext db = new desarrollowebContext();
        private readonly IWebHostEnvironment _webHostEnvironment;
        const string SessionPath = "_Path";
        const string SessionLogged = "_Logged";
        public ProductoController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [ResponseCache(CacheProfileName = "Default30")]
        public async Task<IActionResult> Index(int? pageNumber)
        {
            //return Json(encodedTxt);
            //return View(db.TbProducto);

            var product = from s in db.TbProducto where s.Activo == 1 select s;

            int pageSize = 10;
            if (pageNumber <= 0)
            {
                return StatusCode(404);
            }

            ViewBag.logged = TempData["logged"];

            return View(await PaginatedList<TbProducto>.CreateAsync(product.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        public IActionResult Create()
        {
            if (HttpContext.Session.GetInt32(SessionLogged) != null && HttpContext.Session.GetInt32(SessionLogged) == 1)
            {
                return View();
            }
            return StatusCode(403);
            
        }

        [HttpPost]
        public IActionResult Create(IFormFile file, TbProducto product)
        {
            DateTime dt = DateTime.Now;
            string input = dt.ToString("ddMMyyyyHHmmss");
            string encodedTxt = "";
            using (var algorithm = SHA512.Create()) //or MD5 SHA256 etc.
            {
                var hashedBytes = algorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

                encodedTxt = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
            string webRootPath = _webHostEnvironment.WebRootPath;
            string extension = Path.GetExtension(file.FileName);
            string filename = encodedTxt + extension;
            string path = Path.Combine(webRootPath, "storage", filename);
            product.Img = "~/storage/" + filename;
            
            if (extension.ToLower() == ".jpg" || extension.ToLower() == ".jpeg" || extension.ToLower() == ".png")
            {
                db.TbProducto.Add(product);
                if (db.SaveChanges() > 0)
                {
                    var fileStream = new FileStream(path, FileMode.Create);
                    file.CopyToAsync(fileStream);
                    ViewBag.msg = "Record added";
                    ModelState.Clear();
                }
            }
            return View();
        }

        public IActionResult List()
        {
            if (HttpContext.Session.GetInt32(SessionLogged) != null && HttpContext.Session.GetInt32(SessionLogged) == 1)
            {
                var product = from s in db.TbProducto where s.Activo == 1 select s;
                return View(product);
            }
            return StatusCode(403);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return StatusCode(500);
            }
            var tb = db.TbProducto.Find(id);
            //HttpContext.Session.SetString(SessionPath, tb.Img);

            if (tb == null)
            {
                return StatusCode(404);
            }

            return View(tb);
        }

        public IActionResult Edit(int? id)
        {
            if (HttpContext.Session.GetInt32(SessionLogged) != null && HttpContext.Session.GetInt32(SessionLogged) == 1)
            {
                if (id == null)
                {
                    return StatusCode(500);
                }
                var tb = db.TbProducto.Find(id);
                HttpContext.Session.SetString(SessionPath, tb.Img);

                if (tb == null)
                {
                    return StatusCode(404);
                }

                return View(tb);
            }
            return StatusCode(403);
            
        }

        [HttpPost]
        public IActionResult Edit(IFormFile file, TbProducto tb)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    DateTime dt = DateTime.Now;
                    string input = dt.ToString("ddMMyyyyHHmmss");
                    string encodedTxt = "";
                    using (var algorithm = SHA512.Create()) //or MD5 SHA256 etc.
                    {
                        var hashedBytes = algorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

                        encodedTxt = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                    }
                    string webRootPath = _webHostEnvironment.WebRootPath;
                    string extension = Path.GetExtension(file.FileName);
                    string filename = encodedTxt + extension;
                    string path = Path.Combine(webRootPath, "storage", filename);
                    tb.Img = "~/storage/" + filename;
                    tb.Activo = 1;
                    if (extension.ToLower() == ".jpg" || extension.ToLower() == ".jpeg" || extension.ToLower() == ".png")
                    {
                        //db.TbImg.Add(tb);
                        db.Entry(tb).State = EntityState.Modified;
                        string oldPath = HttpContext.Session.GetString(SessionPath);
                        if (db.SaveChanges() > 0)
                        {
                            oldPath = Path.Combine(webRootPath, oldPath); ;
                            if (System.IO.File.Exists(oldPath))
                            {
                                System.IO.File.Delete(oldPath);
                            }
                            var fileStream = new FileStream(path, FileMode.Create);
                            file.CopyToAsync(fileStream);
                            TempData["msg"] = "Record updated";
                            ModelState.Clear();
                        }
                    }
                    return RedirectToAction("List");
                }
                else
                {
                    tb.Img = HttpContext.Session.GetString(SessionPath);
                    tb.Activo = 1;
                    db.Entry(tb).State = EntityState.Modified;
                    if (db.SaveChanges() > 0)
                    {
                        TempData["msg"] = "Record updated";
                    }
                    return RedirectToAction("List");
                }
            }
            TempData["msg"] = "Error";
            return RedirectToAction("List");
            //return View(tb);
        }

        public IActionResult Delete(int? id)
        {
            if (HttpContext.Session.GetInt32(SessionLogged) != null && HttpContext.Session.GetInt32(SessionLogged) == 1)
            {
                if (id == null)
                {
                    return StatusCode(500);
                }
                var tb = db.TbProducto.Find(id);
                //HttpContext.Session.SetString(SessionPath, tb.Img);

                if (tb == null)
                {
                    return StatusCode(404);
                }

                return View(tb);
            }
            return StatusCode(403);
            
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var tb = db.TbProducto.Find(id);
            tb.Activo = 0;
            db.Entry(tb).State = EntityState.Modified;
            if (db.SaveChanges() > 0)
            {
                ViewBag.msg = "Deleted";
            }
            return RedirectToAction("List");
        }

        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "password")
            {
                HttpContext.Session.SetInt32(SessionLogged, 1);
                return RedirectToAction("List");
            }
            else
            {
                TempData["logged"] = false;
                return RedirectToAction("Index");
            }
            
        }
    }
}