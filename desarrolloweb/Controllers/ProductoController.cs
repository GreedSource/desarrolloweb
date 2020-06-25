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

namespace desarrolloweb.Controllers
{
    public class ProductoController : Controller
    {

        desarrollowebContext db = new desarrollowebContext();
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductoController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            

            //return Json(encodedTxt);
            return View(db.TbProducto);
        }

        public IActionResult Create()
        {
            return View();
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

        public IActionResult Edit(int? id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(IFormFile file)
        {
            return View();
        }
    }
}