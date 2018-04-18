using System;
using System.Collections.Generic;

namespace Users
{
  /// <summary>
  /// This class was made for work with average age command.
  /// </summary>
  class AverageAgeCommand : ICommand
  {
    Options option;
    List<Person> users = new List<Person>();

    public AverageAgeCommand(Options option, List<Person> users)
    {
      this.option = option;
      this.users = users;
    }

    public void Execute()
    {
      Console.WriteLine(option.CalculateAverageAge(users));
    }
  }
}