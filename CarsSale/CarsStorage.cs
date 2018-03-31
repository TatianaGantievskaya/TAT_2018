using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.IO;

namespace CarsSale
{
  /// <summary>
  /// Class implementing the ICommand interface.
  /// </summary>
  public class CarsStorage : ICommand
  {
    public string pathToFile { get; set; }
    private List<Car> carsStorage = new List<Car>();
    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Car>));

    /// <summary>
    /// Add the car in list.
    /// </summary>
    /// <param name="newCar"> The car we want to add. </param>
    public void AddTheCar(Car newCar)
    {
      carsStorage.Add(newCar);
    }

    /// <summary>
    /// Writes from list to JSON file.
    /// </summary>
    public void WriteToJSONFile()
    {
      using (FileStream file = new FileStream(pathToFile, FileMode.OpenOrCreate))
      {
        jsonFormatter.WriteObject(file, carsStorage);
      }
    }

    /// <summary>
    /// Reads from JSON file and displays the information.
    /// </summary>
    public void ReadFromJSONFile()
    {
      using (FileStream file = new FileStream(pathToFile, FileMode.OpenOrCreate))
      {
        int counter = 0;
        List<Car> cars = (List<Car>)jsonFormatter.ReadObject(file);
        foreach(var car in cars)
        {
          Console.WriteLine("{0}. Make: {1}, model: {2}, style: {3}, transmission type: {4}, engine type: {5}, engine capacity: {6}, engine power: {7}, climate management: {8}, interior type: {9}", ++counter, car.Make, car.Model, car.Style, car.TransmissionType, car.EngineType, car.EngineCapacity, car.EnginePower, car.ClimateManagement, car.InteriorType);
        }
      }
    }

    /// <summary>
    /// Gets all the cars from JSON file.
    /// </summary>
    /// <returns> It returns the list of cars. </returns>
    public List<Car> GetTheListOfCars()
    {
      using (FileStream file = new FileStream(pathToFile, FileMode.OpenOrCreate))
      {
        return (List<Car>)jsonFormatter.ReadObject(file);
      }
    }
  }
}