using NumberConverter;
using NUnit.Framework;
using System;

namespace Tests
{
  public class Tests
  {
    private Converter convertibleNumber;

    [Test]
    public void Positive()
    {
      Assert.AreEqual("10111", (convertibleNumber = new Converter("23", "2")).ConvertNumberToSelectedNumeralSystem());
      Assert.AreEqual("13", (convertibleNumber = new Converter("23", "20")).ConvertNumberToSelectedNumeralSystem());
    }
    [Test]
    public void Negative()
    {
      var ex = Assert.Catch<Exception>(delegate { convertibleNumber = new Converter("-1", "2"); });
      Assert.AreEqual("Error, you entered incorrect convertible number.", ex.Message);
    }
  }
}