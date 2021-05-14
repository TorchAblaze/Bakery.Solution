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
      Order newOrder = new Order("test", "test", 0);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnTitle_String()
    {
      string title = "Weekly Croissants";
      Order newOrder = new Order(title, "test", 800);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string description = "500 chocolate croissants to be delivered every Tuesday at 0900";
      Order newOrder = new Order("Weekly Croissants", description, 800);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetPrice_ReturnPrice_Int()
    {
      int price = 800;
      Order newOrder = new Order("Weekly Croissants", "500 chocolate croissants to be delivered every Tuesday at 0900", 800);
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }
  }
}