using System;
using System.Text;

namespace TheLongestSubsequence
{
  /// <summary>
  /// This class was created to output the information about the sequence.
  /// </summary>
  class InformationOutput
  {
    /// <summary>
    /// This method was created for building the output message.
    /// </summary>
    /// <param name="theLongestSubsequence"> The maximum length of subsequence. </param>
    /// <returns> It returns builded output string. </returns>
    public string BuildTheOutputString(int theLongestSubsequence)
    {
      StringBuilder outputString = new StringBuilder();
      outputString.Append("The maximum number of identical consecutive characters in the string: ").Append(theLongestSubsequence);
      return outputString.ToString();
    }

    /// <summary>
    /// The method, which outputs the information about the maximum length of a subsequence 
    /// of the same consecutive symbols containing in the input string.
    /// </summary>
    /// <param name="outputMessage"> The created message about the maximum length of subsequence. </param>
    public void GetMaxAmountOfTheSameConsecutiveSymbols(string outputMessage)
    {
      Console.WriteLine(outputMessage);
    }
  }
}