using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarModelsCatalog
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      IWebDriver driver = new ChromeDriver();
      MainPage mainPage = new MainPage(driver);
      try
      {
        BrandPage brandPage = mainPage.ValidateTheExistanceAndGoToTheBrandPage(driver, args[0]);
        List<Model> listOfModels = new List<Model>();
        foreach (var model in driver.FindElements(By.XPath("//ul[@class='brandslist']//li//a")))
        {
          listOfModels.Add(new Model(model.FindElement(By.TagName("span")).Text, int.Parse(model.FindElement(By.TagName("small")).Text)));
        }
        InformationOutput.PrintTheListOfModels(listOfModels.OrderByDescending(model => model.CarsAmount).ToList());
      }
      catch(Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      driver.Quit();
    }
  }
}