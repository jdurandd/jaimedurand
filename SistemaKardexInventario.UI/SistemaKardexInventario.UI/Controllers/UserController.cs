using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaKardexInventario.UI.DataAccess;
using SistemaKardexInventario.UI.Dominio;

namespace SistemaKardexInventario.UI.Controllers
{
    public class UserController : Controller
    {
        // GET: User

        DALC dalc = new DALC();

        public ActionResult Login()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            string message = "";

            if (ModelState.IsValid)
            {
                if (dalc.CheckUserLogin(user) > 0)
                {
                    message = "succes";

                }
                else
                {
                    message = "Usuario y contrasena incorrectos";

                }

            }
            else
            {
                message = "Todos los campos requeridos";

            }
            if (Request.IsAjaxRequest())
            {
                return Json(message, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return RedirectToAction("Index", "Home");

            }
        }
    }
}