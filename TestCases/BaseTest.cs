using OpenQA.Selenium;
using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Configuration;


namespace SeleniumTests.TestCases 
{
    public abstract class BaseTest()
    {
        protected IWebDriver Driver;

        // protected string Url = ConfigurationManager.AppSettings["Url"];


        [OneTimeSetUp]
        public void BeforeBaseTest() 
        {   
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            Driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void AfterBaseTest() 
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