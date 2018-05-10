using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListOfGoods.Tests
{
  [TestClass]
  public class NegativeTests
  {
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestProduct()
    {
      Product newProduct = new Product("Biscuits", "Tuc", -1, 2);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestOtherProduct()
    {
      Product newProduct = new Product("Biscuits", "Tuc", 1, -0.5);
    }

    [TestMethod]
    [ExpectedException(typeof(Exception), "Cannot create an object, some of the parameters are invalid.")]
    public void TestProductBuilder()
    {
      ProductBuilder builder = new ProductBuilder();
      builder.Build("Biscuits", "Tuc", -1, 2);
    }
  }
}