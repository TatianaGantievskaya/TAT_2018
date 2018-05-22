using OpenQA.Selenium;

namespace CarModelsCatalog
{
  class BrandPage
  {
    private IWebDriver driver;

    public string BrandPageURL { get; set; }

    public BrandPage(IWebDriver driver, IWebElement element)
    {
      this.driver = driver;
      element.Click();
      BrandPageURL = driver.Url;
    }

    public MainPage ReturnToMainPage()
    {
      return new MainPage(driver);
    }
  }
}