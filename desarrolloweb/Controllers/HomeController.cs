using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using desarrolloweb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;

namespace desarrolloweb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public const string SessionKeyName = "_Name";

        public const string SessionKeyQ = "_Q";
        Array arraytable = new string[] { };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Sopa()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Test(IEnumerable<string> row, IEnumerable<string> search)
        {
            var rows = row.ToList<string>();
            var _search = search.ToArray();
            sopa obj = new sopa(rows,_search);
            List<string> result = obj.datos();
            Dictionary<string, List<string>> openWith = new Dictionary<string, List<string>>();
            openWith.Add("Resultado", result);
            openWith.Add("sopa", rows);
            return Json(openWith);
        }

        public IActionResult Calificaciones()
        {
            return View();
        }

        public IActionResult Dados()
        {
            int[] d1 = new int[6] { 1, 2, 3, 4, 5, 6 };
            int[] d2 = new int[6] { 1, 2, 3, 4, 5, 6 };

            string Combinaciones = "";

            for (int i = 0; i < d1.Length; i++)
            {
                for (int j = 0; j < d2.Length; j++)
                {
                    Combinaciones += "<div class='row'>Combinación: " + d1[i] + "," + d2[j] + "</div>";

                }
            }

            ViewBag.Combinaciones = Combinaciones;

            return View();
        }

        [HttpPost]
        public IActionResult Page_view(string nombre, string calificacion)
        {
            HttpContext.Session.SetString(SessionKeyName, nombre);
            HttpContext.Session.SetString(SessionKeyQ, calificacion);
            var Nombre = HttpContext.Session.GetString(SessionKeyName);
            var Q = HttpContext.Session.GetString(SessionKeyQ);
            ViewBag.Nombre = Nombre;
            var rest = 5 - Convert.ToInt32(Q);
            ViewBag.Q = "" + rest + "," + Q + "";
            ViewBag.ID = "q" + Q;

            return View();
        }

        public IActionResult Triangulo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Triangulo(Triangulo ejercicio4)
        {
            double LadoA = ejercicio4.LadoA;
            double LadoB = ejercicio4.LadoB;
            double LadoC = ejercicio4.LadoC;

            if (((LadoA + LadoB) > LadoC) && ((LadoA + LadoC) > LadoB) & ((LadoB + LadoC) > LadoA))
            {

                if (LadoA == LadoB && LadoA == LadoC)
                {
                    ViewBag.Message = "un triangulo equilatero";
                }
                else if (LadoA == LadoB || LadoB == LadoC || LadoA == LadoC)
                {
                    ViewBag.Message = "un triangulo isoceles";
                }
                else
                {
                    ViewBag.Message = "un triangulo escaleno";
                }

            }
            else
            {
                ViewBag.Message = "no es un triangulo";
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
