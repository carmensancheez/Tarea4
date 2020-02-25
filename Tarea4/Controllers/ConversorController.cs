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
        [HttpPost]  
        public ActionResult Longitud()
        {


            return View();
        }
        public ActionResult Temperatura()
        {
            return View();
        }
        public ActionResult Masa()
        {
            return View();
        }
        public ActionResult Datos()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Conversiones(Conversor conversor)
        {

            double dato1 = conversor.Valor1;

            //longitud

            if (conversor.Longitud == Longit.Centimetro)
            {

                if (conversor.Longitud2 == Longit2.Kilometros)
                {
                    conversor.Resultado = dato1 / 100000;

                }
                else if (conversor.Longitud2 == Longit2.Metros)
                {
                    conversor.Resultado = dato1 / 100;
                }
                else if (conversor.Longitud2 == Longit2.Millas)
                {
                    conversor.Resultado = dato1 / 160934;
                }
                else if (conversor.Longitud2 == Longit2.Pies)
                {
                    conversor.Resultado = dato1 / 30.48;
                }
                else if (conversor.Longitud2 == Longit2.Pulgadas)
                {
                    conversor.Resultado = dato1 / 2.54;
                }

            }
            else if (conversor.Longitud == Longit.Kilometros)
            {

                if (conversor.Longitud2 == Longit2.Centimetro)
                {
                    conversor.Resultado = dato1 * 100000;

                }
                else if (conversor.Longitud2 == Longit2.Metros)
                {
                    conversor.Resultado = dato1 * 1000;
                }
                else if (conversor.Longitud2 == Longit2.Millas)
                {
                    conversor.Resultado = dato1 / 1.609;
                }
                else if (conversor.Longitud2 == Longit2.Pies)
                {
                    conversor.Resultado = dato1 * 3281;
                }
                else if (conversor.Longitud2 == Longit2.Pulgadas)
                {
                    conversor.Resultado = dato1 * 39370;
                }

            }
            else if (conversor.Longitud == Longit.Metros)
            {

                if (conversor.Longitud2 == Longit2.Centimetro)
                {
                    conversor.Resultado = dato1 * 100;

                }
                else if (conversor.Longitud2 == Longit2.Kilometros)
                {
                    conversor.Resultado = dato1 / 1000;
                }
                else if (conversor.Longitud2 == Longit2.Millas)
                {
                    conversor.Resultado = dato1 / 1609;
                }
                else if (conversor.Longitud2 == Longit2.Pies)
                {
                    conversor.Resultado = dato1 * 3.281;
                }
                else if (conversor.Longitud2 == Longit2.Pulgadas)
                {
                    conversor.Resultado = dato1 * 39.37;
                }
            }
            else if (conversor.Longitud == Longit.Millas)
            {

                if (conversor.Longitud2 == Longit2.Centimetro)
                {
                    conversor.Resultado = dato1 * 160934;

                }
                else if (conversor.Longitud2 == Longit2.Kilometros)
                {
                    conversor.Resultado = dato1 * 1.609;
                }
                else if (conversor.Longitud2 == Longit2.Metros)
                {
                    conversor.Resultado = dato1 * 1609;
                }
                else if (conversor.Longitud2 == Longit2.Pies)
                {
                    conversor.Resultado = dato1 * 5280;
                }
                else if (conversor.Longitud2 == Longit2.Pulgadas)
                {
                    conversor.Resultado = dato1 * 63360;
                }

            }
            else if (conversor.Longitud == Longit.Pies)
            {

                if (conversor.Longitud2 == Longit2.Centimetro)
                {
                    conversor.Resultado = dato1 * 30.48;

                }
                else if (conversor.Longitud2 == Longit2.Kilometros)
                {
                    conversor.Resultado = dato1 / 3281;
                }
                else if (conversor.Longitud2 == Longit2.Millas)
                {
                    conversor.Resultado = dato1 / 5280;
                }
                else if (conversor.Longitud2 == Longit2.Metros)
                {
                    conversor.Resultado = dato1 / 3.281;
                }
                else if (conversor.Longitud2 == Longit2.Pulgadas)
                {
                    conversor.Resultado = dato1 * 12;
                }

                else if (conversor.Longitud == Longit.Pulgadas)
                {

                    if (conversor.Longitud2 == Longit2.Centimetro)
                    {
                        conversor.Resultado = dato1 * 2.54;

                    }
                    else if (conversor.Longitud2 == Longit2.Kilometros)
                    {
                        conversor.Resultado = dato1 / 39370;
                    }
                    else if (conversor.Longitud2 == Longit2.Millas)
                    {
                        conversor.Resultado = dato1 / 63360;
                    }
                    else if (conversor.Longitud2 == Longit2.Metros)
                    {
                        conversor.Resultado = dato1 / 63360;
                    }
                    else if (conversor.Longitud2 == Longit2.Pies)
                    {
                        conversor.Resultado = dato1 / 12;
                    }

                }

            }
            // masa
             if (conversor.Masa == Mass.Gramo)
            { 
                if(conversor.Masa2 == Mass2.Kilogramo)
                {
                    conversor.Resultado = dato1 / 1000;
                }
                else if (conversor.Masa2 == Mass2.Libra)
                {
                    conversor.Resultado = dato1 / 454;
                }
                else if (conversor.Masa2 == Mass2.Onza)
                {
                    conversor.Resultado = dato1 / 28.35;
                }
            }
            else if (conversor.Masa == Mass.Kilogramo)
            {
                if (conversor.Masa2 == Mass2.Gramo)
                {
                    conversor.Resultado = dato1 * 1000;
                }
                else if (conversor.Masa2 == Mass2.Libra)
                {
                    conversor.Resultado = dato1 * 2.205;
                }
                else if (conversor.Masa2 == Mass2.Onza)
                {
                    conversor.Resultado = dato1 * 35.274;
                }
            }
            else if (conversor.Masa == Mass.Libra)
            {
                if (conversor.Masa2 == Mass2.Kilogramo)
                {
                    conversor.Resultado = dato1 / 2.205;
                }
                else if (conversor.Masa2 == Mass2.Gramo)
                {
                    conversor.Resultado = dato1 * 454;
                }
                else if (conversor.Masa2 == Mass2.Onza)
                {
                    conversor.Resultado = dato1 * 16;
                }
            }
            else if (conversor.Masa == Mass.Onza)
            {
                if (conversor.Masa2 == Mass2.Kilogramo)
                {
                    conversor.Resultado = dato1 / 35.274;
                }
                else if (conversor.Masa2 == Mass2.Libra)
                {
                    conversor.Resultado = dato1 / 16;
                }
                else if (conversor.Masa2 == Mass2.Gramo)
                {
                    conversor.Resultado = dato1 * 28.35;
                }
            }

            //Temperatura

            if (conversor.Temperatura == Temperature.Celcius)
            {
                if (conversor.Temperatura2 == Temperature2.Farenheit)
                {
                    conversor.Resultado = (dato1 * 9/5) + 32;
                }
                else if (conversor.Temperatura2 == Temperature2.Kelvin)
                {
                    conversor.Resultado = dato1 + 273.15;
                }
            }
            else if (conversor.Temperatura == Temperature.Farenheit)
            {
                if (conversor.Temperatura2 == Temperature2.Celcius)
                {
                    conversor.Resultado = (dato1 - 32 ) * 5/9;
                }
                else if (conversor.Temperatura2 == Temperature2.Kelvin)
                {
                    conversor.Resultado = (dato1 - 32) * 5 / 9 + 273.15;
                }
            }
           else if (conversor.Temperatura == Temperature.Kelvin)
            {
                if (conversor.Temperatura2 == Temperature2.Farenheit)
                {
                    conversor.Resultado = (dato1 - 273.15) * 9/5 + 32;
                }
                else if (conversor.Temperatura2 == Temperature2.Celcius)
                {
                    conversor.Resultado = dato1 - 273.15;
                }
            }

            //Datos

            if(conversor.Datos == Data.Bit)
            {
                if(conversor.Datos2 == Data2.Byte)
                {
                    conversor.Resultado = dato1 / 8;
                }
                else if (conversor.Datos2 == Data2.Gigabyte)
                {
                    conversor.Resultado = dato1 / 8e+9;
                }
                else if (conversor.Datos2 == Data2.Kilobyte)
                {
                    conversor.Resultado = dato1 / 1000;
                }
                else if (conversor.Datos2 == Data2.Megabyte)
                {
                    conversor.Resultado = dato1 / 8e+6;
                }
                else if (conversor.Datos2 == Data2.Terabyte)
                {
                    conversor.Resultado = dato1 / 8e+2;
                }
                
                
            }

            else if (conversor.Datos == Data.Byte)
            {
                if (conversor.Datos2 == Data2.Bit)
                {
                    conversor.Resultado = dato1 * 8;
                }
                else if (conversor.Datos2 == Data2.Gigabyte)
                {
                    conversor.Resultado = dato1 / 1e+9;
                }
                else if (conversor.Datos2 == Data2.Kilobyte)
                {
                    conversor.Resultado = dato1 / 1000;
                }
                else if (conversor.Datos2 == Data2.Megabyte)
                {
                    conversor.Resultado = dato1 / 1e+6;
                }
                else if (conversor.Datos2 == Data2.Terabyte)
                {
                    conversor.Resultado = dato1 / 16+12;
                }


            }

            else if (conversor.Datos == Data.Gigabyte)
            {
                if (conversor.Datos2 == Data2.Bit)
                {
                    conversor.Resultado = dato1 * 8e+9;
                }
                else if (conversor.Datos2 == Data2.Byte)
                {
                    conversor.Resultado = dato1 * 1e+9;
                }
                else if (conversor.Datos2 == Data2.Kilobyte)
                {
                    conversor.Resultado = dato1 * 1e+6;
                }
                else if (conversor.Datos2 == Data2.Megabyte)
                {
                    conversor.Resultado = dato1 * 1000;
                }
                else if (conversor.Datos2 == Data2.Terabyte)
                {
                    conversor.Resultado = dato1 / 1000;
                }


            }
            else if (conversor.Datos == Data.Kilobyte)
            {
                if (conversor.Datos2 == Data2.Bit)
                {
                    conversor.Resultado = dato1 * 8000;
                }
                else if (conversor.Datos2 == Data2.Byte)
                {
                    conversor.Resultado = dato1 * 1000;
                }
                else if (conversor.Datos2 == Data2.Gigabyte)
                {
                    conversor.Resultado = dato1 / 1e+6;
                }
                else if (conversor.Datos2 == Data2.Megabyte)
                {
                    conversor.Resultado = dato1 / 1000;
                }
                else if (conversor.Datos2 == Data2.Terabyte)
                {
                    conversor.Resultado = dato1 / 1e+9;
                }


            }
            else if (conversor.Datos == Data.Megabyte)
            {
                if (conversor.Datos2 == Data2.Bit)
                {
                    conversor.Resultado = dato1 * 8e+6;
                }
                else if (conversor.Datos2 == Data2.Byte)
                {
                    conversor.Resultado = dato1 / 1e+6;
                }
                else if (conversor.Datos2 == Data2.Gigabyte)
                {
                    conversor.Resultado = dato1 / 1000;
                }
                else if (conversor.Datos2 == Data2.Kilobyte)
                {
                    conversor.Resultado = dato1 * 1000;
                }
                else if (conversor.Datos2 == Data2.Terabyte)
                {
                    conversor.Resultado = dato1 / 1e+6;
                }


            }
            else if (conversor.Datos == Data.Terabyte)
            {
                if (conversor.Datos2 == Data2.Bit)
                {
                    conversor.Resultado = dato1 * 8e+12;
                }
                else if (conversor.Datos2 == Data2.Byte)
                {
                    conversor.Resultado = dato1 * 1e+6;
                }
                else if (conversor.Datos2 == Data2.Gigabyte)
                {
                    conversor.Resultado = dato1 * 1000;
                }
                else if (conversor.Datos2 == Data2.Kilobyte)
                {
                    conversor.Resultado = dato1 * 1e+9;
                }
                else if (conversor.Datos2 == Data2.Megabyte)
                {
                    conversor.Resultado = dato1 * 1e+6;
                }


            }
            return View(conversor);
        }
    }
}