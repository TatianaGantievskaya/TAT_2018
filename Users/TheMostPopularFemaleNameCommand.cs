using System;
using System.Collections.Generic;

namespace Users
{
  /// <summary>
  /// This class was made for work with the most popular female name command.
  /// </summary>
  class TheMostPopularFemaleNameCommand : ICommand
  {
    Options option;
    List<Person> users = new List<Person>();

    public TheMostPopularFemaleNameCommand(Options option, List<Person> users)
    {
      this.option = option;
      this.users = users;
    }

    public void Execute()
    {
      Console.WriteLine(option.FindTheMostPopularFemaleName(users));
    }
  }
}