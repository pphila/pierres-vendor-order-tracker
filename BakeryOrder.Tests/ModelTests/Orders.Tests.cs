using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrder.Models;
using System.Collections.Generic;
using System;

namespace BakeryOrder.Tests
{
  [TestClass]
  public class OrdersTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Test order1", "test discription", 5, 5, 10, "test date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Rick's Cafe and Taproom";
      Order newOrder = new Order(title, "test discription", 5, 10, 20, "12/10/2022");
      //Act
      //Assert
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnDesctription_Srting()
    {
      //Arrange
      string title = "Rick's Cafe and Taproom";
      string description = "baguettes and croissants";
      Order newOrder = new Order(title, description, 5, 10, 20, "12/10/2022");
      
      //Act
      string result = newOrder.Description;
      
      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      //Arrange
      List<Order> newList = new List<Order>{};

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string title01 = "Rick's Coffee and Beer";
      string title02 = "Morty's Snack Shack";
      Order newOrder1 = new Order(title01, "test descript", 5, 10, 20, "test date");
      Order newOrder2 = new Order(title02, "test descript2", 5, 15, 30, "test date2");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Arrange
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string title = "Rick's Cafe and Taproom";
      string description = "baguettes and croissants";
      int price = 20;
      int bread = 5;
      int pastry = 10;
      string date = "12/10/2022";
      Order newOrder = new Order(title, description, bread, pastry, price, date);

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange
      string title01 = "Rick's Coffee and Beer";
      string title02 = "Morty's Snack Shack";
      Order newOrder1 = new Order(title01, "test descript", 5, 10, 20, "test date");
      Order newOrder2 = new Order(title02, "test descript2", 5, 15, 30, "test date2");

      //Act
      Order result = Order.Find(2);

      //Assert
      Assert.AreEqual(newOrder2, result);
    }

  }
}