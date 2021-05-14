using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceofVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test", "test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Suzie's Cafe";
      Vendor newVendor = new Vendor(name, "test");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Cafe: 123 Some Street Address, Point of Contact: Suzie";
      Vendor newVendor = new Vendor("Suzie's Cafe", description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      Vendor newVendor = new Vendor("Suzie's Cafe", "Cafe: 123 Some Street Address, Point of Contact: Suzie");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      Vendor newVendor1 = new Vendor("Suzie's Cafe", "Cafe: 123 Some Street Address, Point of Contact: Suzie");
      Vendor newVendor2 = new Vendor("Morning Joe", "Cafe: 456 Some Street Address, Point of Contact: Joe");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Vendor newVendor1 = new Vendor("Suzie's Cafe", "Cafe: 123 Some Street Address, Point of Contact: Suzie");
      Vendor newVendor2 = new Vendor("Morning Joe", "Cafe: 456 Some Street Address, Point of Contact: Joe");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      Order newOrder = new Order("Weekly Croissants", "500 chocolate croissants to be delivered every Tuesdsay at 0900", 800, "5/18/2021");
      List<Order> newList = new List<Order> { newOrder };
      Vendor newVendor = new Vendor("Suzie's Cafe", "Cafe: 123 Some Street Address, Point of Contact: Suzie");
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}