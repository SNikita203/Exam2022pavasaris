using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WindowsFormsApp1.Tests;

[TestClass]
public class EbayElementsTests
{
    private const string EbayHomeUrl = "https://www.ebay.com/";

    private IWebDriver? _driver;
    private WebDriverWait? _wait;

    [TestInitialize]
    public void TestInitialize()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("--headless=new");
        options.AddArgument("--window-size=1920,1080");
        options.AddArgument("--no-sandbox");
        options.AddArgument("--disable-dev-shm-usage");

        _driver = new ChromeDriver(options);
        _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));

        _driver.Navigate().GoToUrl(EbayHomeUrl);
    }

    [TestCleanup]
    public void TestCleanup()
    {
        try
        {
            _driver?.Quit();
            _driver?.Dispose();
        }
        catch
        {
        }
        finally
        {
            _driver = null;
            _wait = null;
        }
    }

    [TestMethod]
    public void Test1_field()
    {
        IWebElement? searchField = WaitForElement(By.Id("gh-ac"));

        Assert.IsNotNull(searchField, "Element with id 'gh-ac' was not found.");
        Assert.AreEqual("gh-ac", searchField.GetAttribute("id"));
    }

    [TestMethod]
    public void Test2_search()
    {
        IWebElement? searchButton = WaitForElement(By.Id("gh-btn"));

        Assert.IsNotNull(searchButton, "Element with id 'gh-btn' was not found.");
        Assert.AreEqual("gh-btn", searchButton.GetAttribute("id"));
    }

    private IWebElement? WaitForElement(By by)
    {
        return _wait!.Until(driver =>
        {
            try
            {
                IWebElement element = driver.FindElement(by);
                return element.Displayed ? element : null;
            }
            catch (NoSuchElementException)
            {
                return null;
            }
            catch (StaleElementReferenceException)
            {
                return null;
            }
        });
    }
}
