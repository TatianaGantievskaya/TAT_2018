namespace Users
{
  /// <summary>
  /// This class was made to create the person.
  /// </summary>
  public class Person
  {
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Gender { get; set; }
    public double Age { get; set; }

    public Person(string name, string surname, string gender, double age)
    {
      Name = name;
      Surname = surname;
      Gender = gender;
      Age = age;
    }
  }
}