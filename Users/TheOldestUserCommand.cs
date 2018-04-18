using System;
using System.Collections.Generic;

namespace Users
{
  /// <summary>
  /// This class was made for work with the oldest user command.
  /// </summary>
  class TheOldestUserCommand : ICommand
  {
    Options option;
    List<Person> users = new List<Person>();

    public TheOldestUserCommand(Options option, List<Person> users)
    {
      this.option = option;
      this.users = users;
    }

    public void Execute()
    {
      foreach (var user in option.FindTheOldestUser(users))
      {
        Console.WriteLine($"\nName: {user.Name} \nSurname {user.Surname} \nGender: {user.Gender} \nAge: {user.Age}");
      }
    }
  }
}