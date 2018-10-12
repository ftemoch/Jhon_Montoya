using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Parcial2.Models;



namespace Parcial2.Controllers
{
    public class famusController : Controller
    {
        // GET: famus
        public ActionResult Ramdon()
        {
            var cliente = new cliente()
            {
                Nombre = "jhon ",
                Apellido = "Montoya",
                Sueldo = 12000000
            };
            return View(muesta);
            

    }
    }
}