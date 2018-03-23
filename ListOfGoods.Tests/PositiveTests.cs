using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListOfGoods.Tests
{
  [TestClass]
  public class PositiveTests
  {
    [TestMethod]
    public void TestStoreTheProduct()
    {
      Product myProduct = new Product("Biscuits", "Tuc", 1, 2);
      GoodsStorage storage = new GoodsStorage();
      storage.StoreTheProduct(myProduct);
      Assert.IsTrue(storage.listOfProducts.Contains(myProduct));
    }

    [TestMethod]
    public void TestCountTypesCommand()
    {
      Product firstProduct = new Product("Biscuits", "Tuc", 1, 2);
      Product secondProduct = new Product("Biscuits", "Oreo", 3, 3);
      Product thirdProduct = new Product("Chocolate", "Red riding hood", 5, 2.5);
      GoodsStorage storage = new GoodsStorage();
      storage.StoreTheProduct(firstProduct);
      storage.StoreTheProduct(secondProduct);
      storage.StoreTheProduct(thirdProduct);
      ICommand typesCounter = new CountTypesCommand(storage.listOfProducts);
      Assert.AreEqual(typesCounter.Count(), 2);
    }

    [TestMethod]
    public void TestCountAllCommand()
    {
      Product firstProduct = new Product("Biscuits", "Tuc", 1, 2);
      Product secondProduct = new Product("Biscuits", "Oreo", 3, 3);
      Product thirdProduct = new Product("Chocolate", "Red riding hood", 5, 2.5);
      GoodsStorage storage = new GoodsStorage();
      storage.StoreTheProduct(firstProduct);
      storage.StoreTheProduct(secondProduct);
      storage.StoreTheProduct(thirdProduct);
      ICommand productsCounter = new CountAllCommand(storage.listOfProducts);
      Assert.AreEqual(productsCounter.Count(), 9);
    }
  }
}