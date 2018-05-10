using System.Collections.Generic;

namespace CarsSale
{
  interface ICommand
  {
    string pathToFile { get; set; }

    void AddTheCar(Car newCar);
    void WriteToJSONFile();
    void ReadFromJSONFile();
    List<Car> GetTheListOfCars();
  }
}