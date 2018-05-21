using System;

namespace Task_1
{
  /// <summary>
  /// This is the entry point of the program. This program was made for displaying the welcoming messages.
  /// </summary>
  class EntryPoint
  {
    private const string HELLO_WORLD = "Hello, world!";
    private const string HI_AGAIN = "And hi again!";

    static void Main(string[] args)
    {
      Random random = new Random();
      int amount = random.Next(5, 50);
      string exclamationPointsString = new string('!', amount);
      Console.WriteLine($"{HELLO_WORLD}\n{HI_AGAIN}\n{exclamationPointsString}");
    }
  }
}