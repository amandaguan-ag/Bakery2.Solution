using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order();
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
    }
}
