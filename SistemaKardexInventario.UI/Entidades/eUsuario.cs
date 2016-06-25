using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Entidades
{
   public class eUsuario
    {
        [Display(Name ="Usuario")]
        [Required(ErrorMessage ="Debe ingresar un usuario")]
        public string usuario { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Text)]
        public string password { get; set; }

    }
}
