using System.Collections.Generic;

namespace ListOfGoods
{
  /// <summary>
  /// 
  /// </summary>
  public class CountTypesCommand : ICommand
  {
    private List<Product> products = new List<Product>();

    public CountTypesCommand(List<Product> products)
    {
      this.products = products;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public double Count()
    {
      List<string> processedList = new List<string>();
      foreach (var product in products)
      {
        processedList.Add(product.Type);
      }
      for (int i = 0; i < processedList.Count; i++)
      {
        for (int j = 0; j < processedList.Count; j++)
        {
          if (processedList[i].Equals(processedList[j]) && i != j)
          {
            processedList.RemoveAt(j);
          }
        }
      }
      return processedList.Count;
    }
  }
}