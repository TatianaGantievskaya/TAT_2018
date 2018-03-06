using System;
using System.Text;

namespace NumberConverter
{
  /// <summary>
  /// This class was made for converting the numbers to different numeral systems.
  /// </summary>
  class Converter
  {
    private Int64 convertibleNumber;
    private Int16 radix;

    /// <summary>
    /// Constructor with the parameters, which initializes class's fields.
    /// </summary>
    /// <param name="numberToConvert"> Number, which user wants to convert. </param>
    /// <param name="basisForConverting"> Radix. </param>
    public Converter(string numberToConvert, string basisForConverting)
    {
      convertibleNumber = Convert.ToInt64(numberToConvert);
      radix = Convert.ToInt16(basisForConverting);
      if (radix < 2 || radix > 20 || convertibleNumber <= 0)
      {
        throw new ConvertingException();
      }
    }

    /// <summary>
    /// This method chooses the numeral system, selected by user.
    /// </summary>
    /// <returns> It returns chosen numeral system. </returns>
    public string ChooseTheNumeralSystem()
    {
      string vigesimalNumeralSystem = "0123456789ABCDEFGHIJ";
      string chosenNumeralSystem = vigesimalNumeralSystem.Substring(0, radix);
      return chosenNumeralSystem;
    }

    /// <summary>
    /// This method converts the number to selected numeral system.
    /// </summary>
    /// <param name="chosenNumeralSystem"> String, containing values of selected numeral system. </param>
    /// <returns> It returns converted number. </returns>
    public char[] ConvertNumberToSelectedNumeralSystem(string chosenNumeralSystem)
    {
      StringBuilder convertedNumber = new StringBuilder();
      while (convertibleNumber != 0)
      {
        Int64 temporaryVariable = convertibleNumber / radix;
        char calculatedVariable = chosenNumeralSystem[Convert.ToInt32(convertibleNumber - radix * temporaryVariable)];
        convertedNumber.Append(calculatedVariable);
        convertibleNumber = temporaryVariable;
      }
      char[] convertedValue = convertedNumber.ToString().ToCharArray();
      Array.Reverse(convertedValue);
      return convertedValue;
    }
  }
}