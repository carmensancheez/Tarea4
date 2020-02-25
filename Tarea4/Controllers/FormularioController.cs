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
       public ActionResult Resultados(Estudiante dat, HttpPostedFileBase foto, HttpPostedFileBase curriculum)
        {
            if (ModelState.IsValid)
            {
                string nombre = foto.FileName;
                foto.SaveAs(Server.MapPath("/img/" + nombre));
                ViewBag.pic = nombre;

                string nombre2 = curriculum.FileName;
                curriculum.SaveAs(Server.MapPath("/pdf/" + nombre2));
                ViewBag.cv = nombre2;


                return View(dat);


            }
            else
            {
                return View("Formulario");
            }
        }
    }
}