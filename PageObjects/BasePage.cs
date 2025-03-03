using OpenQA.Selenium;

namespace Selenium.Test.PageObjects
{
    public abstract class BasePage 
    {
        protected IWebDriver Driver;

    // GENERA USUARIO Y CONTRASENA RANDOM
       public string GenerateUsername()
        {
            return "User" + new Random().Next(1000, 9999);
        }

        public string GeneratePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
            return new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
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