using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrder.Models;
using System.Collections.Generic;
using System;

namespace BakeryOrder.Tests
{
  [TestClass]
  public class OrdersTests
  {

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Test order1", "test discription", 10, "test date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Rick Cafe and Taproom";
      Order newOrder = new Order(title, "bread and pastry", 20, "12/10/2022");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

  }
}