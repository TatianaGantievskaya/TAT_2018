using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task_2.Tests
{
  [TestClass]
  public class Tests
  {
    [TestMethod]
    public void TestInitializeTheSides()
    {
      Rectangle rectangle = new Rectangle("2", "4");
    }

    [TestMethod]
    [ExpectedException(typeof(Exception), "Side B: rectangle's side exception. Side cannot be less than 1.")]
    public void TestTheWrongSideValueException()
    {
      Rectangle rectangle = new Rectangle("2", "0");
    }

    [TestMethod]
    public void TestCalculateTheRectangleSquare()
    {
      Rectangle rectangle = new Rectangle("0,2", "4");
      Assert.IsTrue(rectangle.CalculateTheRectangleSquare() == 0.8);
    }
  }
}