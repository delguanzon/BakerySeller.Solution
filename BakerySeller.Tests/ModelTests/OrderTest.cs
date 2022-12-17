using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakerySeller.Models;

namespace BakerySeller.Tests 
{
    
    [TestClass]
    public class OrderTest:IDisposable
    {   
        public void Dispose()
        {
            Order.ClearAll();
        }
        
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

        [TestMethod]
        public void OrderConstructor_AssignIdToOrderInstance_Int()
        {
            int id = 1;
            Order newOrder = new Order("title", "description", 30);
            Assert.AreEqual(id, newOrder.Id);
        }

        [TestMethod]
        public void OrderConstructor_AssignCurrentDateToDateProperty_DateTime()
        {
            DateTime expected = DateTime.Now;
            Order newOrder = new Order("title", "description", 30);
            Assert.AreEqual(expected.ToShortDateString(), newOrder.Date.ToShortDateString());
        }

        [TestMethod]
        public void OrderConstructor_AddOrderToOrderInstances_List()
        {
            Order newOrder1 = new Order("order1", "description1", 30);
            Order newOrder2 = new Order("order2", "description2", 30);
            Order newOrder3 = new Order("order3", "description3", 30);
            List<Order> expected = new List<Order> { newOrder1, newOrder2, newOrder3 };
            CollectionAssert.AreEqual(expected, Order.GetAll());
        }


    }
}