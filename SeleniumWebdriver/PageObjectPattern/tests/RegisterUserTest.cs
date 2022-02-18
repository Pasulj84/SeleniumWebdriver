using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebdriver.PageObjectPattern.pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebdriver.PageObjectPattern.tests
{
    public class RegisterUserTest
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://react-redux.realworld.io/#/register?_k=qxonh8";
        }
        [Test]
        public void testUserRegi()
        {
            var timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            string email = $"paparapapa+{timestamp}@gmail.com";
            string username = $"John Wick{timestamp}";
            string password = "Daisy";

            RegisterPage registerPage = new RegisterPage(driver);
            registerPage.CreateUser(username, email, password);
            HomePage homePage = new HomePage(driver);
            StringAssert.AreEqualIgnoringCase(username, homePage.getUserName()); 

        }

        [TearDown]
        public void TearDown()
        {
            //driver.Quit();
        }
    }
}
