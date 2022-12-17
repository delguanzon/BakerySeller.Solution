using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakerySeller.Tests 
{
    
    public class OrderTest
    {
        [TestMethod]
        public void OrderConstructor_CreateInstanceOfOrder_Order()
        {
            Order newOrder = new Order("title", "description", 30);
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void OrderConstructor_AssignValuesToOrderTitleAndDescription_String()
        {
            string title = "title";
            string description = "description";
            int price = 30;
            Order newOrder = new Order(title, description, price);
            Assert.AreEqual(title, newOrder.Title);
            Assert.AreEqual(description, newOrder.Description);
            Assert.AreEqual(price, newOrder.Price);
        }


    }
}