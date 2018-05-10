using System;
using System.Collections.Generic;

namespace CarModelsCatalog
{
  static class InformationOutput
  {
    public const string MODEL = "\n\nModel:";
    public const string AMOUNT = "\nAmount:";

    public static void PrintTheListOfModels(List<Model> listOfModels)
    {
      foreach(var model in listOfModels)
      {
        Console.WriteLine($"{MODEL} {model.ModelName} {AMOUNT} {model.CarsAmount}");
      }
    }
  }
}