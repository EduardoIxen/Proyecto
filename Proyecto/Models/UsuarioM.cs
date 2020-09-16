using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class UsuarioM
    {
        public int idUsuario { get; set; }
        [Display(Name = "nombre"), Required(ErrorMessage = "Nombre es requerido")]
        public string nombre { get; set; }
        [Display(Name = "apellido"), Required(ErrorMessage = "Apellido es requerido")]
        public string apellido { get; set; }
        [Display(Name = "nombreUsuario"), Required(ErrorMessage = "Nombre de usuario es requerido")]
        public string nombreUsuario { get; set; }
        [Display(Name = "contrasenia"), Required(ErrorMessage = "Contraseña es requerida"), DataType(DataType.Password)]
        public string contrasenia { get; set; }
        public System.DateTime fechaNacimiento { get; set; }
        [Display(Name = "correo"), Required(ErrorMessage = "Correo es requerido"), DataType(DataType.EmailAddress)]
        public string correo { get; set; }
        public int pais { get; set; }

        public virtual Pais Pais1 { get; set; }
    }
}