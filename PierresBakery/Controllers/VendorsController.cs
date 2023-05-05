using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;

namespace PierresBakery.Controllers
{
    public class VendorsController : Controller
    {
        private static List<Vendor> _vendors = new List<Vendor>();
        private static int _nextVendorId = 1;

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
            _vendors.Add(new Vendor { Id = _nextVendorId++, Name = name, Description = description });
            return RedirectToAction("Index");
        }

        [HttpGet("/vendors/{id}")]
        public ActionResult Show(int id)
        {
            Vendor vendor = _vendors.Find(v => v.Id == id);
            return View(vendor);
        }

        [HttpGet("/vendors/{vendorId}/orders/new")]
        public ActionResult NewOrder(int vendorId)
        {
            ViewBag.VendorId = vendorId;
            return View();
        }

        [HttpPost("/vendors/{vendorId}/orders")]
        public ActionResult CreateOrder(int vendorId, string title, string description, decimal price, DateTime date)
        {
            Vendor vendor = _vendors.Find(v => v.Id == vendorId);
            vendor.Orders.Add(new Order { Title = title, Description = description, Price = price, Date = date });
            return RedirectToAction("Show", new { id = vendorId });
        }
    }
}
