using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTests.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests{

    [TestFixture]
    public class LoginTests
    {
        protected IWebDriver Driver;

        [SetUp]
        public void BeforeTest() 
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize(); 
            Driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            Thread.Sleep(2000);
        }

        [Test]
        public void LoginSuccessfull() 
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.CheckElements();
            loginPage.SelectLogin();
            Thread.Sleep(3000);
            loginPage.FillFields("agusgatto", "agus1994");
            Thread.Sleep(3000);
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