using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadPrice_CreatesInstanceOfBread_Bread()
    {
      int customerInput = 1;
      Bread newBread = new Bread(customerInput);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void BreadPrice_SetsNumberOfItems_Int()
    {
      int customerInput = 1;
      Bread newBread = new Bread(customerInput);
      int result = newBread.Quantity;
      Assert.AreEqual(customerInput, result);
    }
    [TestMethod]
    public void BreadPrice_ReturnPriceOfLoaf_Int()
    {
      int expectedCost = 5;
      int customerInput = 1;
      Bread newBread = new Bread(customerInput);
      int result = newBread.BreadCost();
      Assert.AreEqual(expectedCost, result);
    }
    [TestMethod]
    public void BreadPrice_ReturnPriceOfMultipleLoafs_Int()
    {
      int expectedCost = 25;
      int customerInput = 7;
      Bread newBread = new Bread(customerInput);
      int result = newBread.BreadCost();
      Assert.AreEqual(expectedCost, result);
    }
  }
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastries_CreatesInstanceOfPastries_Pastry()
    {
      int customerInput = 1;
      Pastries newPastries = new Pastries(customerInput);
      Assert.AreEqual(typeof(Pastries), newPastries.GetType());
    }
    [TestMethod]
    public void Pastries_SetsNumberOfPastries_Int()
    {
      int customerInput = 1;
      Pastries newPastries = new Pastries(customerInput);
      int result = newPastries.PastryQuantity;
      Assert.AreEqual(customerInput, result);
    }
    [TestMethod]
    public void Pastries_ReturnsCostOfPastries_Int()
    {
      int expectedCost = 7;
      int customerInput = 4;
      Pastries newPastries = new Pastries(customerInput);
      int result = newPastries.PastryCost();
      Assert.AreEqual(expectedCost, result);
    }
    [TestMethod]
    public void Pastries_ReturnsCostOfUnderThreePastries_Int()
    {
      int expectedCost = 4;
      int customerInput = 2;
      Pastries newPastries = new Pastries(customerInput);
      int result = newPastries.PastryCost();
      Assert.AreEqual(expectedCost, result);
    }
  }
}