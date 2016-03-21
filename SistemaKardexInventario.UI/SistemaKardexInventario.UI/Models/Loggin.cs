using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SistemaKardexInventario.UI.Models
{
    public class Loggin
    {
        [Required(ErrorMessage ="Ingrese su Usuario")]
        public string usuario { get; set; }

        [Required(ErrorMessage = "Ingrese su Password")]
        public string password { get; set; }
    }
}