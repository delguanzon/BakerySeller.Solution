using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName;

namespace ProjectName.Tests
{
  [TestClass]
  public class ClassNameTests: IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {      
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {      
      Vendor newVendor = new Vendor("test vendor");
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
      int id = 0;
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(id, newVendor.Id);
    }

    public void VendorConstructor_AddVendorToVendorList_List()
    {
      Vendor newVendor = new Vendor("vendor1","vendor1 description");
      Vendor newVendor = new Vendor("vendor2","vendor2 description");
      Vendor newVendor = new Vendor("vendor2","vendor2 description");
      List<Vendor> expected = new List<Vendor> {newVendor1, newVendor2, newVendor3};
      CollectionAssert.AreEqual(expected, Vendor.GetAll());
    }

    public void AddOrder_AddOrderToVendorsOrderList_List()
    {
      Vendor newVendor = new Vendor("vendor1","vendor1 description");
      Order newOrder = new Order("title", "description", 1, 1);
      newVendor.AddOrder(newOrder);
      List<Order> expected = new List<Order> {newOrder};
      CollectionAssert.AreEqual(expected, newVendor.Orders);
    }

  }
}