using Xunit;

namespace ModifiedString.Tests
{
  public class TestsForTheStringCreator
  {
    private StringCreator outputString = new StringCreator();

    [Fact]
    public void TestEnteredString()
    {
      Assert.Equal("hlo", outputString.CreateTheString("hello"));
    }

    [Fact]
    public void TestEmptyString()
    {
      Assert.Equal(string.Empty, outputString.CreateTheString(""));
    }
  }
}