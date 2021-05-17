using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }
    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> vendorAndOrders = new Dictionary<string, object>();
      vendorAndOrders.Add("Order", order);
      vendorAndOrders.Add("Vendor", vendor);
      return View(vendorAndOrders);
    }
    [HttpPost("/vendors/{vendorId}/orders/delete")]
    public ActionResult Delete(int vendorId, int orderId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      vendor.Orders.RemoveAt(orderId-1);
      return View();
    }
  }
}