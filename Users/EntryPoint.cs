using System;
using System.IO;
using System.Text;

namespace Users
{
  /// <summary>
  /// The entry point of the program.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      Input input = new Input();
      input.IdenticalSurnameReceived += Input_IdenticalSurnameReceived;
      do
      {
        input.AddTheUser(input.EnterTheName(), input.EnterTheSurname(), input.EnterTheGender(), input.EnterTheAge());
      } while (!Console.ReadKey().Key.Equals(ConsoleKey.Escape));
      Computer computer = new Computer();
      Options option = new Options();
      computer.GetCommand(new AverageAgeCommand(option, input.users));
      computer.ExecuteTheCommand();
      ICommand command = new TheOldestUserCommand(option, input.users);
      computer.GetCommand(command);
      computer.ExecuteTheCommand();
      command = new TheMostPopularFemaleNameCommand(option, input.users);
      computer.GetCommand(command);
      computer.ExecuteTheCommand();
    }

    static void Input_IdenticalSurnameReceived(object sender, IdenticalSurnameEventArgs e)
    {
      Console.WriteLine(e.Message);
      using (FileStream stream = new FileStream("D:\\logs.txt", FileMode.Append, FileAccess.Write))
      {
        byte[] newEvent = Encoding.Default.GetBytes("\r\nNew event: " + e.Message);
        stream.Write(newEvent, 0, newEvent.Length);
        stream.Flush();
        stream.Close();
      }
      return;
    }
  }
}