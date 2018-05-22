using System.Collections.Generic;
using System.Linq;

namespace Users
{
  /// <summary>
  /// This class contains the actions which can be performed with the list of users.
  /// </summary>
  public class Options
  {
    public double CalculateAverageAge(List<Person> users)
    {
      return users.Average(user => user.Age);
    }

    public IEnumerable<Person> FindTheOldestUser(List<Person> users)
    {
      return (from user in users
              where user.Age.Equals(users.Max(person => person.Age))
              select user);
    }

    /// <summary>
    /// This method searches the most popular female name in the list of users.
    /// </summary>
    /// <param name="users"> List of users. </param>
    /// <returns> 
    /// It returns the most popular female name. If there is no popular name, it returns the last one. 
    /// If list contains no women, it returns the message with that information. 
    /// </returns>
    public string FindTheMostPopularFemaleName(List<Person> users)
    {
      int counter = 0;
      string popularName = null;
      var women = (from user in users
                   where user.Gender.ToUpper().Equals("FEMALE")
                   select user).ToList();
      for (int i = 0; i < women.Count; i++)
      {
        var temporaryList = (from woman in women
                             where woman.Name.SequenceEqual(women[i].Name)
                             select woman).ToList();
        if (counter < temporaryList.Count)
        {
          counter = temporaryList.Count;
          popularName = temporaryList.First().Name;
        }
      }
      return counter != 0 ? popularName : "\nThere are no women at the list.";
    }
  }
}