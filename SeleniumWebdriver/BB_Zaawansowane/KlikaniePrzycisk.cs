using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebdriver.BB_Zaawansowane
{
    internal class KlikaniePrzycisk
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/dynamic-buttons-disabled.html";
        }

        [Test]

        public void ActionKlik()
        {
            WebDriverWait wait = new WebDriverWait(driver, timeout: TimeSpan.FromSeconds(10))
            {
                PollingInterval = TimeSpan.FromSeconds(1),
            };

            //Klikam 1
            wait.Until(driver =>
                driver.FindElement(By.Id("button00")).Enabled);

            IWebElement Clickbut = driver.FindElement(By.Id("button00"));
            Clickbut.Click();

            //Klikam 2
            wait.Until(driver =>
                driver.FindElement(By.Id("button01")).Enabled);

            IWebElement Clickbut2 = driver.FindElement(By.Id("button01"));
            Clickbut2.Click();

            //Klikam 3
            wait.Until(driver =>
                driver.FindElement(By.Id("button02")).Enabled);

            IWebElement Clickbut3 = driver.FindElement(By.Id("button02"));
            Clickbut3.Click();

            //Klikam 4
            wait.Until(driver =>
                driver.FindElement(By.Id("button03")).Enabled);

            IWebElement Clickbut4 = driver.FindElement(By.Id("button03"));
            Clickbut4.Click();

            //Asercja
            IWebElement chElem1 = driver.FindElement(By.Id("buttonmessage"));
            Assert.AreEqual("All Buttons Clicked", chElem1.Text);
        }



        [TearDown]
        public void TearDown()
        {
            //driver.Quit();
        }
    }
}
