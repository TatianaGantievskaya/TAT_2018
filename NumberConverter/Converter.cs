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
    private int radix;

    /// <summary>
    /// Constructor with the parameters, which initializes class's fields.
    /// </summary>
    /// <param name="numberToConvert"> Number, which user wants to convert. </param>
    /// <param name="basisForConverting"> Radix. </param>
    public Converter(string numberToConvert, string basisForConverting)
    {
      convertibleNumber = Convert.ToInt64(numberToConvert);
      radix = Convert.ToInt32(basisForConverting);
      if (radix < 2 || radix > 20 || convertibleNumber <= 0)
      {
        throw new Exception("You entered wrong radix or incorrect convertible number.");
      }
    }

    /// <summary>
    /// This method converts the number to selected numeral system.
    /// </summary>
    /// <returns> It returns converted number. </returns>
    public char[] ConvertNumberToSelectedNumeralSystem()
    {
      StringBuilder convertedNumber = new StringBuilder();
      while (convertibleNumber != 0)
      {
        Int64 temporaryVariable = convertibleNumber / radix;
        Int64 calculatedVariable = convertibleNumber - radix * temporaryVariable;
        if (calculatedVariable > 9)
        {
          convertedNumber.Append((char)(calculatedVariable + 55));
        }
        else
        {
          convertedNumber.Append(calculatedVariable);
        }
        convertibleNumber = temporaryVariable;
      }
      char[] convertedValue = convertedNumber.ToString().ToCharArray();
      Array.Reverse(convertedValue);
      return convertedValue;
    }
  }
}