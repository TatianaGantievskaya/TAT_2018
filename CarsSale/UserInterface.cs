using System;

namespace CarsSale
{
  /// <summary>
  /// Class was made for work with user.
  /// </summary>
  class UserInterface
  {
    public string EnterTheMake()
    {
      Console.WriteLine("Enter make:");
      return Console.ReadLine();
    }

    public string EnterTheModel()
    {
      Console.WriteLine("Enter model:");
      return Console.ReadLine();
    }

    public string EnterTheStyle()
    {
      Console.WriteLine("Enter style:");
      return Console.ReadLine();
    }

    public string EnterTheTransmissionType()
    {
      Console.WriteLine("Enter transmission type:");
      return Console.ReadLine();
    }

    public string EnterTheEngineType()
    {
      Console.WriteLine("Enter engine type:");
      return Console.ReadLine();
    }

    public string EnterTheEngineCapacity()
    {
      Console.WriteLine("Enter engine capacity:");
      return Console.ReadLine();
    }

    public string EnterTheEnginePower()
    {
      Console.WriteLine("Enter engine power:");
      return Console.ReadLine();
    }

    public string EnterTheClimateManagement()
    {
      Console.WriteLine("Enter climate management:");
      return Console.ReadLine();
    }

    public string EnterTheInteriorType()
    {
      Console.WriteLine("Enter interior type:");
      return Console.ReadLine();
    }

    public Car CreateTheRequestedCar(string make, string model, string style, string transmissionType, string engineType, string engineCapacity, string enginePower, string climateManagement, string interiorType)
    {
      return new Car(make, model, style, transmissionType, engineType, engineCapacity, enginePower,climateManagement, interiorType);
    }

    /// <summary>
    /// Shows found car.
    /// </summary>
    /// <param name="car"></param>
    public void ShowTheCar(Car car)
    {
      Console.WriteLine("Make: {0}, model: {1}, style: {2}, transmission type: {3}, engine type: {4}, engine capacity: {5}, engine power: {6}, climate management: {7}, interior type: {8}", car.Make, car.Model, car.Style, car.TransmissionType, car.EngineType, car.EngineCapacity, car.EnginePower, car.ClimateManagement, car.InteriorType);
    }
  }
}