using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HorizonMindCare.Controllers
{
    public class FacilitiesController : Controller
    {

        public ActionResult Academic()
        {
            return View("Academic");
        }
        public ActionResult Addictions()
        {
            return View("Addictions");
        }
        public ActionResult ChildProblem()
        {
            return View("ChildProblem");
        }
        public ActionResult MemoryProblems()
        {
            return View("MemoryProblems");
        }
        public ActionResult Psychosomaticdisorders()
        {
            return View("Psychosomaticdisorders");
        }
        public ActionResult SexualProblems()
        {
            return View("SexualProblems");
        }
        public ActionResult StressinRelationship()
        {
            return View("StressinRelationship");
        }
        public ActionResult WomenpsychologicalProblems()
        {
            return View("WomenpsychologicalProblems");
        }
        
	}
}