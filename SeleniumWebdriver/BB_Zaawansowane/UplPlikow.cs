using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebdriver.BB_Zaawansowane
{
    public class UplPlikow
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/file-upload-test.html";
        }

        [Test]
        public void ActionKlik()
        {
            
        }

        [TearDown]
        public void TearDown()
        {
            //driver.Quit();
        }
    }
}
