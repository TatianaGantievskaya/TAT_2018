using System;

namespace ListOfGoods
{
  /// <summary>
  /// 
  /// </summary>
  public class InformationInput
  {
    private const string NUMBER_OF_PRODUCTS = "Enter the number of products: ";
    private const string TYPE_OF_PRODUCT = "Type: ";
    private const string NAME_OF_PRODUCT = "Name: ";
    private const string AMOUNT_OF_PRODUCT = "Amount: ";
    private const string PRODUCT_PRICE = "Price: ";
    private const string WRONG_NUMBER_EXCEPTION = "You entered wrong number.";

    public int EnterTheNumberOfProducts()
    {
      int number;
      do
      {
        Console.Write(NUMBER_OF_PRODUCTS);
        int.TryParse(Console.ReadLine(), out number);
      } while (number.Equals(null) || number <= 0);
      return number;
    }

    public string EnterTheTypeOfProduct()
    {
      string type = null;
      do
      {
        Console.Write(TYPE_OF_PRODUCT);
        type = Console.ReadLine();
      } while (string.IsNullOrEmpty(type));
      return type;
    }

    public string EnterTheNameOfProduct()
    {
      string name = null;
      do
      {
        Console.Write(NAME_OF_PRODUCT);
        name = Console.ReadLine();
      } while (string.IsNullOrEmpty(name));
      return name;
    }

    public double EnterTheAmountOfProduct()
    {
      Console.Write(AMOUNT_OF_PRODUCT);
      double amount = double.Parse(Console.ReadLine());
      return amount;
    }

    public double EnterThePriceOfProduct()
    {
      Console.Write(PRODUCT_PRICE);
      double price = double.Parse(Console.ReadLine());
      return price;
    }
  }
}