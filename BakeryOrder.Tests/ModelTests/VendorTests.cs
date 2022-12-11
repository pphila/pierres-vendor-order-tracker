using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrder.Models;
using System.Collections.Generic;
using System;

namespace BakeryOrder.Tests
{
  [TestClass]
  public class VendorTests
  {
    
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Rick", "Multiverse cafe owner");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Name";
      Vendor newVendor = new Vendor(name, "desctription");

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDesctription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Cafe and taproom";
      Vendor newVendor = new Vendor("Ricks Cafe", description);

      //Act
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string Name = "Rick"
      Vendor newVendor = new Vendore(name, "descrption");

      //Act
      int result = newVendor.Id;

      //Asser
      Assert.AreEqual(1, result);
    }

  }
}