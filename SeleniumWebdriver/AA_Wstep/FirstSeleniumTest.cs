using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace SeleniumWebdriver.AA_Wstep
{
    public class FirstSeleniumTest
    {
        IWebDriver driver;
        
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.saucedemo.com/";
        }

        [Test]
        public void SearchForMyCompanyShouldReturnSomeResults()
        {
            IWebElement quertyInputElement = driver.FindElement(By.Name("user-name"));
            quertyInputElement.SendKeys("standard_user");
            IWebElement quertyInputElement2 = driver.FindElement(By.Name("password"));
            quertyInputElement2.SendKeys("secret_sauce");
            IWebElement quertyInputElement3 = driver.FindElement(By.Name("login-button"));
            quertyInputElement3.Click();

            IWebElement selectElement = driver.FindElement(By.CssSelector(".product_sort_container"));
            var selectObject = new SelectElement(selectElement);
            selectObject.SelectByValue("hilo");

            IList<IWebElement> elements = driver.FindElements(By.CssSelector(".inventory_item_name"));
            Assert.Multiple(() =>
            {
                Assert.AreEqual("Sauce Labs Fleece Jacket", elements[0].Text);
                Assert.AreEqual("Sauce Labs Backpack", elements[1].Text);
            });
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}