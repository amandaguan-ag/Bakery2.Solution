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
        [HttpPost("/vendors")]
        public ActionResult Create(string name, string description)
        {
            _vendors.Add(new Vendor { Name = name, Description = description });
            return RedirectToAction("Index");
        }
        [HttpGet("/vendors/{id}")]
        public ActionResult Show(int id)
        {
            Vendor vendor = _vendors.Find(v => v.Id == id);
            return View(vendor);
        }
    }
}