using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebdriver.PageObjectPattern.pages
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        //User
        private By userNameLocator => By.XPath("//*[@id=\"main\"]/div/nav/div/ul/li[4]/a");
        private IWebElement wartosc => driver.FindElement(userNameLocator);

        public string getUserName()
        {
            return wartosc.Text;
        }


    }
}
