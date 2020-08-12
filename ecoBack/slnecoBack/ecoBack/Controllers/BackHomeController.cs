using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ecoBack.Controllers
{
    public class BackHomeController : Controller
    {
        // GET: BackHome
        public ActionResult Index()
        {
            return View();
        }
    }
}