using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using BakeryOrder.Models;

namespace BakeryOrder.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int Id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderDescription, int bread1, int bread2, int bread3, int bread4, int pastry1, int pastry2, int pastry3, int pastry4, DateTime orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      string venderName = foundVendor.Name;
      
      int breadTotal = bread1 + bread2 + bread3 + bread4;
      int pastryTotal = pastry1 + pastry2 + pastry3 + pastry4;
      string dateToDisplay = orderDate.ToShortDateString();
      string orderTitle = venderName + " " + dateToDisplay;

      Order newOrder = new Order(orderTitle, orderDescription, breadTotal, pastryTotal, dateToDisplay);
      newOrder.CalculatePrice();

      foundVendor.AddItem(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }

  }
}