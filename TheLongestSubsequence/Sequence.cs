namespace TheLongestSubsequence
{
  /// <summary>
  /// This class was made for work with the input sequence.
  /// </summary>
  class Sequence
  {
    /// <summary>
    /// The input string we work with.
    /// </summary>
    public string EnteredSequence { get; set; }

    /// <summary>
    /// Class constructor with a parameter, which initialize class's field.
    /// </summary>
    /// <param name="sequence"> A sequence, which was entered in the command line. </param>
    public Sequence(string sequence)
    {
      EnteredSequence = sequence;
    }

    /// <summary>
    /// This method finds the longest subsequence of the same consecutive symbols.
    /// </summary>
    /// <returns> It returns the value, which reflects the maximum length of the subsequence. </returns>
    public int FindTheLongestSubsequence()
    {
      int amountOfTheSameSymbols = 1;
      int counter = 1;
      for (int i = 0; i < EnteredSequence.Length - 1; i++)
      {
        if (EnteredSequence[i].Equals(EnteredSequence[i + 1]))
        {
          counter++;
        }
        if (!EnteredSequence[i].Equals(EnteredSequence[i + 1]) || i.Equals(EnteredSequence.Length - 2))
        {
          if (amountOfTheSameSymbols < counter)
          {
            amountOfTheSameSymbols = counter;
          }
          counter = 1;
        }
      }
      return amountOfTheSameSymbols;
    }
  }
}