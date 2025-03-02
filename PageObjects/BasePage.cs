using OpenQA.Selenium;

namespace Selenium.Test.PageObjects
{
    public abstract class BasePage 
    {
        protected IWebDriver Driver;
    }
}


        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        //URL DE LA APP BAJO PRUEBA.

        // METODO PARA INICIAR EL NAVEGADOR Y NAVEGAR A LA URL.
        // protected string Url = ConfigurationManager.AppSettings["Url"];




        // [OneTimeSetUp]

        // public void BeforeTest() 
        // {   
        //     Driver = new ChromeDriver();
        //     Driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
        //     Driver.Manage().Window.Maximize();
        //     Thread.Sleep(1000);
        // }