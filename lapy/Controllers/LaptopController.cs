using lapy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lapy.Controllers
{
    public class LaptopController : Controller
    {
        // GET: Laptop
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SaveLaptop(LaptopModel model)
        {
            try
            {

                return Json(new { Message = new LaptopModel().SaveLaptop(model) }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {
                return Json(new { model = ex }, JsonRequestBehavior.AllowGet);
            }
        
        
        }
        




    }
}