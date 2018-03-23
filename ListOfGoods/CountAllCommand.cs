using System.Collections.Generic;

namespace ListOfGoods
{
  /// <summary>
  /// 
  /// </summary>
  public class CountAllCommand : ICommand
  {
    private List<Product> products = new List<Product>();

    public CountAllCommand(List<Product> products)
    {
      this.products = products;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public double Count()
    {
      double amountOfProducts = 0;
      foreach (var product in products)
      {
        amountOfProducts += product.Amount;
      }
      return amountOfProducts;
    }
  }
}