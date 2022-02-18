using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebdriver.BB_Zaawansowane
{
    public class TestUkryteElementy
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/expandingdiv.html";
        }

        [Test]

        public void ActionKur()
        {
            //Rozwiniecie elementu na stronie
            IWebElement expandingDiv = driver.FindElement(By.CssSelector(".expand"));
            Actions action = new Actions(driver);
            action.MoveToElement(expandingDiv);
            action.Perform();

            IWebElement Clickbut = driver.FindElement(By.XPath("/html/body/div/div[3]/div/div/p[6]/a"));
            Clickbut.Click();
        }

        [TearDown]
        public void TearDown()
        {
            //driver.Quit();
        }
    }
}
