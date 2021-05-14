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
    public void SetDescription_SetDescription_String()
    {
      string description = "500 chocolate croissants to be delivered every Tuesday at 0900";
      Order newOrder = new Order("Weekly Eclairs", description, 0, "test");
      string updatedDescription = "450 eclairs to be delivered every Wednesday at 1000";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedDescription, result);
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
    public void SetPrice_SetPrice_Int()
    {
      int price = 800;
      Order newOrder = new Order("Weekly Eclairs", "450 eclairs to be delivered every Wednesday at 1000", price, "test");
      int updatedPrice = 825;
      newOrder.Price = updatedPrice;
      int result = newOrder.Price;
      Assert.AreEqual(updatedPrice, result);
    }
    [TestMethod]
    public void GetDate_ReturnDate_String()
    {
      string date = "5/18/2021";
      Order newOrder = new Order("Weekly Croissants", "500 chocolate croissants to be delivered every Tuesdsay at 0900", 800, "5/18/2021");
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }
    [TestMethod]
    public void SetDate_SetDate_String()
    {
      string date = "5/18/2021";
      Order newOrder = new Order("Weekly Eclairs", "450 eclairs to be delivered every Wednesday at 1000", 825, date);
      string updatedDate = "5/19/2021";
      newOrder.Date = updatedDate;
      string result = newOrder.Date;
      Assert.AreEqual(updatedDate, result);
    }
  }
}