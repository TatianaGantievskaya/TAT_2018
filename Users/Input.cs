using System;
using System.Collections.Generic;

namespace Users
{
  /// <summary>
  /// This class was made for work with the input.
  /// </summary>
  class Input
  {
    public List<Person> users = new List<Person>();

    public string EnterTheName()
    {
      string name = null;
      bool correctName = false;
      while (!correctName)
      {
        try
        {
          name = Console.ReadLine();
          if (string.IsNullOrEmpty(name))
          {
            throw new Exception("\nThe name field must be filled.");
          }
          correctName = true;
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message + " Try to enter the name again.\n");
        }
      }
      return name;
    }

    public string EnterTheSurname()
    {
      string surname = null;
      bool correctSurname = false;
      while (!correctSurname)
      {
        try
        {
          surname = Console.ReadLine();
          if (string.IsNullOrEmpty(surname))
          {
            throw new Exception("\nThe surname field must be filled.");
          }
          correctSurname = true;
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message + " Try to enter the surname again.\n");
        }
      }
      return surname;
    }

    public string EnterTheGender()
    {
      string gender = null;
      bool correctGender = false;
      while (!correctGender)
      {
        try
        {
          gender = Console.ReadLine();
          if (string.IsNullOrEmpty(gender) || (!gender.ToUpper().Equals("FEMALE") && !gender.ToUpper().Equals("MALE")))
          {
            throw new Exception("\nYou entered the incorrect gender.");
          }
          correctGender = true;
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message + " Try to enter the gender again.\n");
        }
      }
      return gender;
    }

    public double EnterTheAge()
    {
      double age = -1;
      bool correctAge = false;
      while (!correctAge)
      {
        try
        {
          age = double.Parse(Console.ReadLine());
          if (age < 0)
          {
            throw new Exception("\nAge cannot be less than 0.");
          }
          correctAge = true;
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message + " Try to enter the age again.\n");
        }
      }
      return age;
    }

    /// <summary>
    /// This method adds user to the list of users.
    /// </summary>
    /// <param name="name"> Entered name. </param>
    /// <param name="surname"> Entered surname. </param>
    /// <param name="gender"> Entered gender. </param>
    /// <param name="age"> Entered age. </param>
    public void AddTheUser(string name, string surname, string gender, double age)
    {
      foreach (var user in users)
      {
        if (surname.Equals(user.Surname))
        {
          IdenticalSurnameEventArgs args = new IdenticalSurnameEventArgs();
          args.User = user;
          args.Message = $"\nUser with the identical surname:\n \nName: {args.User.Name} \nSurname {args.User.Surname} \nGender: {args.User.Gender} \nAge: {args.User.Age}";
          OnIdenticalSurnameReceived(args);
        }
      }
      users.Add(new Person(name, surname, gender, age));
      Console.WriteLine("\nPress any key to continue. If you want to finish the input, press 'esc'.\n");
    }

    /// <summary>
    /// Identical surname event.
    /// </summary>
    public event EventHandler<IdenticalSurnameEventArgs> IdenticalSurnameReceived;

    protected virtual void OnIdenticalSurnameReceived(IdenticalSurnameEventArgs e)
    {
      IdenticalSurnameReceived?.Invoke(this, e);
    }
  }
}