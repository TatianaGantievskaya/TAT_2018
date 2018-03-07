using System;
using System.Text;
using System.Numerics;

namespace NumberConverter
{
  /// <summary>
  /// This class was made for converting the numbers to different numeral systems.
  /// </summary>
  class Converter
  {
    private BigInteger convertibleNumber;
    private int radix;

    /// <summary>
    /// Constructor, which initializes class's fields.
    /// </summary>
    /// <param name="numberToConvert"> Number, which user wants to convert. </param>
    /// <param name="basisForConverting"> Radix. </param>
    public Converter(string numberToConvert, string basisForConverting)
    {
      convertibleNumber = BigInteger.Parse(numberToConvert);
      radix = int.Parse(basisForConverting);
      if (radix < 2 || radix > 20)
      {
        throw new Exception("Error, you entered wrong radix.");
      }
      if (convertibleNumber <= 0)
      {
        throw new Exception("Error, you entered incorrect convertible number.");
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
        BigInteger temporaryVariable = convertibleNumber / radix;
        BigInteger calculatedVariable = convertibleNumber - radix * temporaryVariable;
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