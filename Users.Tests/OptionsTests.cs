using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Users.Tests
{
  [TestClass]
  public class OptionsTests
  {
    Person firstUser;
    Person secondUser;
    private List<Person> list;
    private Options option;

    [TestInitialize]
    public void SetupContext()
    {
      firstUser = new Person("Maria", "Ivanova", "Female", 12);
      secondUser = new Person("Peter", "Ivanov", "Male", 30);
      list = new List<Person>();
      option = new Options();
    }

    [TestMethod]
    public void TestCalculateAverageAge()
    {
      list.Add(firstUser);
      list.Add(secondUser);
      Assert.AreEqual(21, option.CalculateAverageAge(list));
    }

    [TestMethod]
    public void TestFindTheOldestUser()
    {
      list.Add(firstUser);
      list.Add(secondUser);
      Assert.AreEqual(secondUser, option.FindTheOldestUser(list).ToList().Single());
    }

    [TestMethod]
    public void TestFindTheMostPopularFemaleName()
    {
      list.Add(firstUser);
      list.Add(secondUser);
      Assert.AreEqual("Maria", option.FindTheMostPopularFemaleName(list));
      list.Remove(firstUser);
      Assert.AreEqual("\nThere are no women at the list.", option.FindTheMostPopularFemaleName(list));
    }
  }
}