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
      Order newOrder = new Order("test", "test", 0, "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnTitle_String()
    {
      string title = "Weekly Croissants";
      Order newOrder = new Order(title, "test", 0, "test");
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      string title = "Weekly Croissants";
      Order newOrder = new Order(title, "test", 0, "test");
      string updatedTitle = "Weekly Eclairs";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      Assert.AreEqual(updatedTitle, result);
    }
    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string description = "500 chocolate croissants to be delivered every Tuesday at 0900";
      Order newOrder = new Order("Weekly Croissants", description, 0, "test");
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetPrice_ReturnPrice_Int()
    {
      int price = 800;
      Order newOrder = new Order("Weekly Croissants", "500 chocolate croissants to be delivered every Tuesday at 0900", 800, "test");
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void GetDate_ReturnDate_String()
    {
      string date = "5/18/2021";
      Order newOrder = new Order("Weekly Croissants", "500 chocolate croissants to be delivered every Tuesdsay at 0900", 800, "5/18/2021");
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }
  }
}