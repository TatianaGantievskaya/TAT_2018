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
        InformationOutput information = new InformationOutput();
        information.GetMaxAmountOfTheSameConsecutiveSymbols(information.BuildTheOutputString(inputString.FindTheLongestSubsequence()));
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}