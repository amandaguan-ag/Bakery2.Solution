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

        [TestMethod]
        public void GetOrderProperties_ReturnsOrderProperties_OrderProperties()
        {
            Order newOrder = new Order
            {
                Id = 1,
                Title = "Croissant order",
                Description = "Freshly baked croissants",
                Price = 12.50m,
                Date = new DateTime(2023, 5, 4)
            };

            int id = 1;
            string title = "Croissant order";
            string description = "Freshly baked croissants";
            decimal price = 12.50m;
            DateTime date = new DateTime(2023, 5, 4);

            Assert.AreEqual(id, newOrder.Id);
            Assert.AreEqual(title, newOrder.Title);
            Assert.AreEqual(description, newOrder.Description);
            Assert.AreEqual(price, newOrder.Price);
            Assert.AreEqual(date, newOrder.Date);
        }
    }
}
