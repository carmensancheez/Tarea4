using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarea4.Models;

namespace Tarea4.Controllers
{
    public class ConversorController : Controller
    {
        // GET: Conversor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Formulario()
        {
            return View();
        }
        public ActionResult Datos()
        {
            return View();
        }
    }
}