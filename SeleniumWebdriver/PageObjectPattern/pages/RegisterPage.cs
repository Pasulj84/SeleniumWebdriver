using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebdriver.PageObjectPattern.pages
{
    public class RegisterPage
    {
        private IWebDriver driver;

        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        //User
        private By userNameLocator => By.XPath("//form//input[@type='text']");
        //Email
        private By emailLocator => By.XPath("//form//input[@type='email']");
        //Hasło
        private By passwordLocator => By.XPath("//form//input[@type='password']");
        private IWebElement polepassword => driver.FindElement(passwordLocator);
        //Przycisk Logowania
        private By buttonLo => By.XPath("//button[@type='submit']");
        private IWebElement registerbutton => driver.FindElement(buttonLo);

        public void CreateUser(string username, string email, string password)
        {
            driver.FindElement(userNameLocator).SendKeys(username);
            driver.FindElement(emailLocator).SendKeys(email);
            polepassword.SendKeys(password);
            registerbutton.Click();
        }
    }
}
