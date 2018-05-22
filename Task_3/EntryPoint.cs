using System;
using System.Collections.Generic;

namespace Task_3
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      InformationAboutFiles data = new InformationAboutFiles();
      List<string> information = data.GetAllTheInfoAboutFiles(args[0], args[1]);
      foreach (var info in information)
      {
        Console.WriteLine(data.PrepareTheOutputString(info));
      }
    }
  }
}