using System.Collections.Generic;

namespace ListOfGoods
{
  /// <summary>
  /// 
  /// </summary>
  public class GoodsStorage
  {
    public List<Product> listOfProducts = new List<Product>();

    public void StoreTheProduct(Product product)
    {
      listOfProducts.Add(product);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="products"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public List<Product> GetProcessingList(List<Product> products, string type)
    {
      List<Product> productsWithIdenticalType = new List<Product>();
      productsWithIdenticalType = products.FindAll(product => product.Type.Equals(type));
      return productsWithIdenticalType;
    }
  }
}