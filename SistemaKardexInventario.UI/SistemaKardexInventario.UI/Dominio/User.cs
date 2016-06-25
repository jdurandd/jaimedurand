using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace SistemaKardexInventario.UI.Dominio
{
    public class User
    {
     
        public int UserID { get; set; }

        [Required(ErrorMessage = "Ingrese su Usuario")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Ingrese su Password")]
        public string Password { get; set; } 
    }


}