using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SistemaKardexInventario.UI.Models;


namespace SistemaKardexInventario.UI.Controllers
{
    public class LogginController : Controller
    {
        // GET: Loggin
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Loggin model)
        {
            if()


        }

    }
}