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
            Order newOrder = new Order("title", "description", "price", "date");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        
    }
}