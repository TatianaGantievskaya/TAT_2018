using OpenQA.Selenium;
using System;

namespace CarModelsCatalog
{
  class MainPage
  {
    public const string MAIN_PAGE_URL = "https://av.by/";
    public const string NO_SUCH_BRAND_EXCEPTION_MESSAGE = "There are no matches with your car brand.";

    public MainPage(IWebDriver driver)
    {
      driver.Navigate().GoToUrl(MAIN_PAGE_URL);
    }

    public BrandPage ValidateTheExistanceAndGoToTheBrandPage(IWebDriver driver, string brand)
    {
      try
      {
        return new BrandPage(driver, driver.FindElement(By.XPath($"//ul[@class='brandslist']//a[span[.='{brand}']]")));
      }
      catch (NoSuchElementException)
      {
        throw new Exception(NO_SUCH_BRAND_EXCEPTION_MESSAGE);
      }
    }
  }
}