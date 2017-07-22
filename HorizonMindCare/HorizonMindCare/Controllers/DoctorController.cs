using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HorizonMindCare.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult AboutDoctors(int id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}