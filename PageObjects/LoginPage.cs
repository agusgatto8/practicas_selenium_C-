using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;

namespace SeleniumTests.PageObjects
{
    public class LoginPage 
    {
        protected IWebDriver Driver;

        protected By LoginButton = By.Id("login2");
        protected By InputUserName = By.Id("loginusername");
        protected By InputPassword = By.Id("loginpassword");
        protected By ButtonSubmit = By.CssSelector("btn btn-primary");

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void FillInputs(string user, string password) 
        {
            Driver.FindElement(InputUserName).SendKeys(user);
            Driver.FindElement(InputPassword).SendKeys(password);
        }

         public void ClickOn() 
        {
          Driver.FindElement(ButtonSubmit).Click();
        }
    }
}