using System;

namespace ListOfGoods
{
  /// <summary>
  /// 
  /// </summary>
  public class Product
  {
    public string Type { get; set; }
    public string Name { get; set; }
    private double amount;
    private double price;

    private const double MIN_VALUE = 0.0D;

    public double Amount
    {
      get
      {
        return amount;
      }
      set
      {
        amount = value;
        if (amount < MIN_VALUE)
        {
          throw new ArgumentException();
        }
      }
    }

    public double Price
    {
      get
      {
        return price;
      }
      set
      {
        price = value;
        if (price < MIN_VALUE)
        {
          throw new ArgumentException();
        }
      }
    }

    public Product(string type, string name, double amount, double price)
    {
      Type = type;
      Name = name;
      Amount = amount;
      Price = price;
    }
  }
}