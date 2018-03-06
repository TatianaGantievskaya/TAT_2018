using System;

namespace NumberConverter
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
        Converter convertibleNumber = new Converter(args[0], args[1]);
        Console.WriteLine(convertibleNumber.ConvertNumberToSelectedNumeralSystem());
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}