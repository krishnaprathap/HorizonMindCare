using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using HorizonMindCare.Models;

namespace HorizonMindCare.Controllers
{
    public class ReadDataController : Controller
    {
        // GET: ReadData
        public ActionResult Index()
        {

            string file = Server.MapPath("~/Content/hi.txt");
            string json = System.IO.File.ReadAllText(file);
          
            JavaScriptSerializer ser = new JavaScriptSerializer();
            var personlist = ser.Deserialize<List<News>>(json);
            return View(personlist);
        }

        [HttpGet]
        public JsonResult news()
        {
            string file = Server.MapPath("~/Content/hi.txt");
            string json = System.IO.File.ReadAllText(file);
           
            JavaScriptSerializer ser = new JavaScriptSerializer();
            var newslist = ser.Deserialize<List<News>>(json);
            
            
            return Json(newslist, JsonRequestBehavior.AllowGet);


        }
    }
}