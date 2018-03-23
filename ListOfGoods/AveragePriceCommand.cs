using System.Collections.Generic;

namespace ListOfGoods
{
  /// <summary>
  /// 
  /// </summary>
  class AveragePriceCommand : ICommand
  {
    private List<Product> products = new List<Product>();
    private string type;

    public AveragePriceCommand(List<Product> products)
    {
      this.products = products;
    }

    public AveragePriceCommand(List<Product> products, string type)
    {
      this.products = products;
      this.type = type;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public double Count()
    {
      double averagePrice = 0;
      foreach (var product in products)
      {
        averagePrice += product.Price;
      }
      return (averagePrice /= products.Count);
    }
  }
}