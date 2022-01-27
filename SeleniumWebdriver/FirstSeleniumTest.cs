using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebdriver
{
    public class FirstSeleniumTest
    {
        IWebDriver driver;
        
        [SetUp]
        public void Setup()
        {
            // przygotuj sterownik przegl�darki
        }

        [Test]
        public void SearchForMyCompanyShouldReturnSomeResults()
        {
            // odpal stron� bing.com i wyszukaj swoj� firm� w Google
            driver = new ChromeDriver();
            driver.Url = "https://www.bing.com";
            driver.FindElement(By.Name("q")).Click();
            driver.FindElement(By.Name("q")).SendKeys("MojaFirma");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            driver.Quit();
        }

        [TearDown]
        public void TearDown()
        {
            // zamknij przegl�dark�
        }
    }
}