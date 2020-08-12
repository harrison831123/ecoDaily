using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ecoBack.Controllers
{
    public class BackFinancialController : Controller
    {
        // GET: BackFinancial
        public ActionResult managementFee()
        {
            return View();
        }
        public ActionResult incomeList()
        {
            return View();
        }
        public ActionResult incomeKeyIn()
        {
            return View();
        }
        public ActionResult incomeEdit()
        {
            return View();
        }

        public ActionResult payKeyIn()
        {
            return View();
        }
        public ActionResult payList()
        {
            return View();
        }
        public ActionResult financialList()
        {
            return View();
        }
        public ActionResult gasData()
        {
            return View();
        }
    }
}