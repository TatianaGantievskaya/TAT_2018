using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CarsSale
{
  /// <summary>
  /// The entry point of the program.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        ICommand command = new CarsCatalog
        {
          pathToFile = "cars_catalog.json"
        };
        UserInterface user = new UserInterface();
        Car userCar = user.CreateTheRequestedCar(user.EnterTheMake(), user.EnterTheModel(), user.EnterTheStyle(), user.EnterTheTransmissionType(), user.EnterTheEngineType(), user.EnterTheEngineCapacity(), user.EnterTheEnginePower(), user.EnterTheClimateManagement(), user.EnterTheInteriorType());
        PropertyInfo[] carProperties = typeof(Car).GetProperties();
        List<Car> foundMatches = new List<Car>();
        List<Car> listOfCars = command.GetTheListOfCars();
        Check check = new Check();
        foreach (var car in listOfCars)
        {
          List<Car> carMatches =
          (from property in carProperties
           where (property.GetValue(userCar).Equals(property.GetValue(car)))
           select car).ToList();
          foundMatches.AddRange(carMatches);
        }
        check.CheckTheMatches(foundMatches);
        foreach (var car in listOfCars)
        {
          foreach (var property in carProperties)
          {
            check.CheckTheMatches(foundMatches);
            if (!property.GetValue(userCar).Equals(string.Empty) && !property.GetValue(userCar).Equals(property.GetValue(car)))
            {
              foundMatches.Remove(car);
            }
          }
        }
        Console.WriteLine("Matches for your request were found. Do you want to look in storage?");
        string answer = Console.ReadLine();
        if (answer.Equals("yes"))
        {
          command = new CarsStorage
          {
            pathToFile = "cars_storage.json"
          };
          List<Car> matches = new List<Car>();
          foreach (var car in command.GetTheListOfCars())
          {
            matches =
            (from property in carProperties
             where (property.GetValue(userCar).Equals(property.GetValue(car)))
             select car).ToList();
          }
          check.CheckTheMatches(matches);
          foreach (var car in matches)
          {
            user.ShowTheCar(car);
          }
        }
        foreach(var car in foundMatches)
        {
          user.ShowTheCar(car);
        }
      }
      catch(Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}