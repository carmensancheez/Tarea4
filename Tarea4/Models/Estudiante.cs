using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Web.Mvc;

namespace Tarea4.Models
{
    public class Estudiante
    {
        [Required(ErrorMessage = "La Cedula es Obligatoria")] 
        public string Cedula { get; set; }
        [Required(ErrorMessage = "El Nombre es Obligatorio")] 
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Apellido es Obligatorio")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La Edad es Obligatoria")]
        [Range(15, 90, ErrorMessage = "Debe de ser mayor de 15 años")] 
        public int Edad { get; set; }
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El email es Obligatorio")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Porfavor introduzca un Email con el formato correcto")]
        public string Correo { get; set; }
        public Gender Genero { get; set; }
        public Job Puesto { get; set; }

        public enum Gender
        {
            Masculino, Femenino
        }

        public enum Job
        {
            Programador, Diseñador, DBA, Analista
        }
    }
}