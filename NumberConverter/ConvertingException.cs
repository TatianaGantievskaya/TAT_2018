using System;

namespace NumberConverter
{
  /// <summary>
  /// This class was made for possible converting exception.
  /// </summary>
  class ConvertingException : Exception
  {
    /// <summary>
    /// Overridden message.
    /// </summary>
    public string Message
    {
      get
      {
        return "You entered wrong radix or incorrect convertible number.";
      }
    }
  }
}