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
}