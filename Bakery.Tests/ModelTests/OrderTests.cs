using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfClassItem_Order()
    {
      Order newOrder = new Order("test", "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnTitle_String()
    {
      string title = "Weekly Croissants";
      Order newOrder = new Order(title, "test");
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string description = "500 Croissants to be delivered every Tuesday at 0900";
      Order newOrder = new Order("Weekly Croissants", description);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
  }
}