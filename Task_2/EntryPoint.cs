using System;

namespace Task_2
{
  /// <summary>
  /// This is the entry point of the program.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        Rectangle rectangle = new Rectangle(args[0], args[1]);
        Console.WriteLine($"Rectangle's square: {rectangle.CalculateTheRectangleSquare()}");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}