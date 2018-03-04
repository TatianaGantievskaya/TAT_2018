using System;

namespace ModifiedString
{
  /// <summary>
  /// This is entry point of the program.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      string inputString = null;
      while (string.IsNullOrEmpty(inputString))
      {
        Console.WriteLine("Enter your string: ");
        inputString = Console.ReadLine();
        if (inputString.Equals(string.Empty))
        {
          Console.WriteLine("\nYour string is empty. If you want to exit the program, press 'escape' key. If you want to try to enter your string again, press any key besides 'escape'.");
          if ((Console.ReadKey().Key).Equals(ConsoleKey.Escape))
          {
            return;
          }
        }
      }
      StringProcessing outputString = new StringProcessing();
      Console.WriteLine(outputString.ProcessTheString(inputString));
    }
  }
}