using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Real_Estate.Models;
using Real_Estate.Entity;
namespace Real_Estate.Controllers
{
    public class MasterPageController : Controller
    {
        Real_EstateDataContext ctx = new Real_EstateDataContext();
        //
        // GET: /MasterPage/
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
        public ActionResult Left()
        {
            return View();
        }
        public ActionResult Right()
        {
            return View();
        }
        public ActionResult Menu()
        {

            var menu = (from p in ctx.Poperties
                        select new PropertyModel
                        {
                            id = p.id,
                            parent_id = p.id,
                            name_eng = p.name_eng,
                            name_vie = p.name_vie,
                            status = p.status,
                            ls_Location = (from l in ctx.Locations
                                           where l.property_id==p.id
                                           select new LocationModel { 
                                                id = l.id,
                                                property_id = (int)l.property_id,
                                                location_name_eng = l.location_name_eng,
                                                location_name_vie= l.location_name_vie,
                                                status = l.status
                                           }).ToList()
                        }).ToList();
            return View(menu);
        }
	}
}