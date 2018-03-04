using System.Text;

namespace ModifiedString
{
  /// <summary>
  /// This class was created for work with the input string.
  /// </summary>
  class StringProcessing
  {
    /// <summary>
    /// This method processes the input string.
    /// </summary>
    /// <param name="inputString"> It is a string entered by user. </param>
    /// <returns> It returns new, modificated, string. </returns>
    public string ProcessTheString(string inputString)
    {
      StringBuilder modificatedString = new StringBuilder();
      for (int i = 0; i < inputString.Length; i = i + 2)
      {
        modificatedString.Append(inputString[i]);
      }
      return modificatedString.ToString();
    }
  }
}