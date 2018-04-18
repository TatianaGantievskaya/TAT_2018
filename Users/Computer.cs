namespace Users
{
  /// <summary>
  /// This class was made to invoke and execute the command.
  /// </summary>
  class Computer
  {
    ICommand command;

    public void GetCommand(ICommand command)
    {
      this.command = command;
    }

    public void ExecuteTheCommand()
    {
      command.Execute();
    }
  }
}