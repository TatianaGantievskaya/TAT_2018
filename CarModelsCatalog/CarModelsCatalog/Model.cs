namespace CarModelsCatalog
{
  class Model
  {
    public string ModelName { get; set; }
    public int CarsAmount { get; set; }

    public Model(string name, int amount)
    {
      ModelName = name;
      CarsAmount = amount;
    }
  }
}