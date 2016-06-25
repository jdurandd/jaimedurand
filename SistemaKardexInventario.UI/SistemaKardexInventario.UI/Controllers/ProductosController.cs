using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaKardexInventario.UI.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            @ViewData["Name"] = "Bienveniedos al curso de mvc";
            return View();
        }

        public string Saludos()
        {
            return "Bienvenidos al curso de mvc";

        }
    }
}