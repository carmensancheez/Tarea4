using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tarea4.Controllers
{
    public class FiltroController : Controller
    {
        // GET: Filtro
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Noticias()
        {
            return View();
        }
        public ActionResult Musica()
        {
            return View();
        }
        public ActionResult Peliculas()
        {
            return View();
        }
    }
}