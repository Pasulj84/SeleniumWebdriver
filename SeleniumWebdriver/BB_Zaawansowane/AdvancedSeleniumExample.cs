using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebdriver.BB_Zaawansowane
{
    public class AdvancedSeleniumExample
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/basic-ajax-test.html";
        }

        [TestCase ("1", "1", "1", "1")]
        [TestCase ("2", "12", "2", "12")]
        [TestCase ("3", "23", "3", "23")]

        public void ZadaniePierwsze(string category, string lang, string valcate, string vallang)
        {
            IWebElement selectElement = driver.FindElement(By.Name("id"));
            var selectObject = new SelectElement(selectElement);
            selectObject.SelectByValue(category);

            WebDriverWait wait = new WebDriverWait(driver, timeout: TimeSpan.FromSeconds(10))
            {
	            PollingInterval = TimeSpan.FromSeconds(1),
            };

            wait.Until(driver =>
	            !driver.FindElement(By.Id("ajaxBusy")).Displayed);
            
            IWebElement selectlanguage_id = driver.FindElement(By.Name("language_id"));
            var selectObject2 = new SelectElement(selectlanguage_id);
            selectObject2.SelectByValue(lang);

            IWebElement Clickbut = driver.FindElement(By.Name("submitbutton"));
            Clickbut.Click();

            IWebElement chElem1 = driver.FindElement(By.Id("_valueid"));
            IWebElement chElem2 = driver.FindElement(By.Id("_valuelanguage_id"));

            Assert.Multiple(() =>
            {
                Assert.AreEqual(valcate, chElem1.Text);
                Assert.AreEqual(vallang, chElem2.Text);
            });
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
