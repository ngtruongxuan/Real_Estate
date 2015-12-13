using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Real_Estate.Controllers
{
    public class MasterPageAdminController : Controller
    {
        //
        // GET: /MasterPageAdmin/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Header()
        {
            return View();
        }
        public ActionResult Footer()
        {
            return View();
        }
	}
}