using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using model;

namespace asignacion_4.Controllers
{
    public class HomeController : Controller
    {
        private InformacionGeneral Mipersona = new InformacionGeneral();

        public ActionResult Index(int id =1)
        {

            return View(Mipersona.MostrarMiinformacion(id));
        }
    }
}