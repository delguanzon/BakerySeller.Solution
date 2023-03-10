using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakerySeller.Models;

namespace BakerySeller.Tests
{
  [TestClass]
  public class VendorTests: IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {      
      Vendor newVendor = new Vendor("test vendor","test vendor description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void VendorConstructor_AssignValuesToVendorNameAndDescription_String()
    { 
      string name = "vendor name";
      string description = "descrption";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(name, newVendor.Name);
      Assert.AreEqual(description, newVendor.Description);
    }

    [TestMethod]
    public void VendorConstructor_AssignIdToVendorInstance_Int()
    { 
      int id = 1;
      Vendor newVendor = new Vendor("vendor1","vendor1 description");
      Assert.AreEqual(id, newVendor.Id);
    }

    public void VendorConstructor_AddVendorToVendorList_List()
    {
      Vendor newVendor1 = new Vendor("vendor1","vendor1 description");
      Vendor newVendor2 = new Vendor("vendor2","vendor2 description");
      Vendor newVendor3 = new Vendor("vendor3","vendor3 description");
      List<Vendor> expected = new List<Vendor> {newVendor1, newVendor2, newVendor3};
      CollectionAssert.AreEqual(expected, Vendor.GetAll());
    }

    [TestMethod]
    public void AddOrder_AddOrderToVendorsOrderList_List()
    {
      Vendor newVendor = new Vendor("vendor1","vendor1 description");
      Order newOrder = new Order("title", "description", 1);
      newVendor.AddOrder(newOrder);
      List<Order> expected = new List<Order> {newOrder};
      CollectionAssert.AreEqual(expected, newVendor.GetOrders());
    }

    [TestMethod]
    public void Find_FindVendorById_Vendor()
    {
      Vendor newVendor1 = new Vendor("vendor1","vendor1 description");
      Vendor newVendor2 = new Vendor("vendor2","vendor2 description");
      Vendor newVendor3 = new Vendor("vendor3","vendor3 description");
      Vendor expected = newVendor2;
      Assert.AreEqual(expected, Vendor.Find(2));
    }

  }
}