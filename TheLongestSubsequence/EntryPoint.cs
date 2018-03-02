using System;

namespace TheLongestSubsequence
{
  /// <summary>
  /// The entry point of the program.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        Sequence inputString = new Sequence(args[0]);
        inputString.GetMaxAmountOfTheSameConsecutiveSymbols();
      }
      catch(Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}