using System;

namespace ListOfGoods
{
  /// <summary>
  /// Product builder.
  /// </summary>
  public class ProductBuilder
  {
    public Product Build(string type, string name, double amount, double price)
    {
      try
      {
        return new Product(type, name, amount, price);
      }
      catch
      {
        throw new Exception("Cannot create an object, some of the parameters are invalid.");
      }
    }
  }
}