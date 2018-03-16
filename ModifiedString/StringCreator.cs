using System.Text;

namespace ModifiedString
{
  /// <summary>
  /// This class was made for creating a new string based on the input string.
  /// </summary>
  public class StringCreator
  {
    /// <summary>
    /// This method creates new, output, string.
    /// </summary>
    /// <param name="inputString"> It is a string entered by user. </param>
    /// <returns> It returns new, modificated, string. </returns>
    public string CreateTheString(string inputString)
    {
      StringBuilder outputString = new StringBuilder();
      for (int i = 0; i < inputString.Length; i = i + 2)
      {
        outputString.Append(inputString[i]);
      }
      return outputString.ToString();
    }
  }
}