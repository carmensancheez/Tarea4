using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarea4.Models;

namespace Tarea4.Controllers
{
    public class FormularioController : Controller
    {
        // GET: Formulario
        public ActionResult Formulario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Resultados(Estudiante dat, HttpPostedFileBase foto)
        {
            if (ModelState.IsValid)
            {
                string nombre = foto.FileName;
                foto.SaveAs(Server.MapPath("/img/" + nombre));
                ViewBag.pic = nombre;
                return View(dat);
            }
            else
            {
                return View("Formulario");
            }
        }
    }
}