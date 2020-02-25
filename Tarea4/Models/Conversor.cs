using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea4.Models
{
    public class Conversor
    {

        public Longit Longitud { get; set; }
        public Mass Masa { get; set; }
        public Temperature Temperatura { get; set; }
        public Data Datos { get; set; }
        public Longit2 Longitud2 { get; set; }
        public Mass2 Masa2 { get; set; }
        public Temperature2 Temperatura2 { get; set; }
        public Data2 Datos2 { get; set; }
        public double Valor1 { get; set; }

        public double Resultado { get; set; }
    }

    public enum Longit
    {
        Centimetro, Pies, Pulgadas, Metros, Kilometros, Millas
    }
    public enum Mass
    {
        Gramo, Kilogramo, Onza, Libra
    }
    public enum Temperature
    {
        Celcius, Farenheit, Kelvin
    }
    public enum Data
    {
        Bit, Byte, Kilobyte, Megabyte, Gigabyte, Terabyte
    }

    public enum Longit2
    {
        Centimetro, Pies, Pulgadas, Metros, Kilometros, Millas
    }
    public enum Mass2
    {
        Gramo, Kilogramo, Onza, Libra
    }
    public enum Temperature2
    {
        Celcius, Farenheit, Kelvin
    }
    public enum Data2
    {
        Bit, Byte, Kilobyte, Megabyte, Gigabyte, Terabyte
    }
}