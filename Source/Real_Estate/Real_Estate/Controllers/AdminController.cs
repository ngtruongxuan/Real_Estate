using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Real_Estate.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Addmin/
       
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddProperty()
        {
            return View();

        }
        public ActionResult AddLocation()
        {
            return View();
        }
	}
}