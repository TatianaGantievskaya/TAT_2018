namespace CarsSale
{
  /// <summary>
  /// This class was made for working with ICommand.
  /// </summary>
  class Actions
  {
    ICommand command;

    /// <summary>
    /// Here we set the command (choose which we work with: car catalog or car storage).
    /// </summary>
    /// <param name="chosenCommand"> Established command. </param>
    public void SetCommand(ICommand chosenCommand)
    {
      command = chosenCommand;
    }

    /// <summary>
    /// Displays the list of cars.
    /// </summary>
    public void ShowCars()
    {
      command.ReadFromJSONFile();
    }
  }
}