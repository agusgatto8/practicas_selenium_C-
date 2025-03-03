using OpenQA.Selenium;
using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Configuration;


namespace SeleniumTests.TestCases 
{
    public class BaseTest()
    {
        protected IWebDriver Driver;

    // protected string Url = ConfigurationManager.AppSettings["Url"];


    // CON LA SIGUEINTE ANOTACION INDICAMOS QUE EL NAVEGADOR SE INICIALIZA UNA SOLA VEZ PARA EJECUTAR LAS PRUEBAS.
        [OneTimeSetUp]
        public void BeforeBaseTest() 
        {   
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            Driver.Manage().Window.Maximize();
        }
    // INDICAMOS QUE UNA VEZ CORRIDAS LAS PRUEBAS EL NAVEGADOR SE CERRARA.
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