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
  }
}