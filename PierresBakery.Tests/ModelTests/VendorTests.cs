using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
    [TestClass]
    public class VendorTests
    {
        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor();
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetVendorProperties_ReturnsVendorProperties_VendorProperties()
        {
            Vendor newVendor = new Vendor { Id = 1, Name = "Suzie's Cafe", Description = "A cozy cafe" };
            int id = 1;
            string name = "Suzie's Cafe";
            string description = "A cozy cafe";

            Assert.AreEqual(id, newVendor.Id);
            Assert.AreEqual(name, newVendor.Name);
            Assert.AreEqual(description, newVendor.Description);
        }
    }
}
