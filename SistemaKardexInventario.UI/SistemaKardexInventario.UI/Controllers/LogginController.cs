using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SistemaKardexInventario.UI.Models;
using SistemaKardexInventario.UI.DataAccess;


namespace SistemaKardexInventario.UI.Controllers
{
    public class LogginController : Controller
    {
        DALC oDalc = new DALC();

        // GET: Loggin
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User User)
        {
            if (oDalc.CheckUserLogin(User) > 0)
            {
                return RedirectToAction("Index", "Home");

            }
            return View();
        }

    }
}