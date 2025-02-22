using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTests.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;


namespace SeleniumTests{

    [TestFixture]
    public class LoginTests
    {
        protected IWebDriver Driver;

        [SetUp]
        public void BeforeTest() 
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
        }

        [Test]
        public void LoginSuccessfull() 
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.FillInputs("agusgatto", "Agus1994");
            loginPage.ClickOn();
        }

        [TearDown]
        public void AfterTest() 
        {
             if (Driver != null)
            {
                Driver.Quit();
                Driver.Dispose(); 
                Driver = null;
            }
        }

    }
}