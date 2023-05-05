using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;

namespace PierresBakery.Controllers
{
    public class VendorsController : Controller
    {
        private static List<Vendor> _vendors = new List<Vendor>();

        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            return View(_vendors);
        }
        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }
    }
}