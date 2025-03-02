using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;
using Selenium.Test.PageObjects;
using SeleniumTests.Handler;

namespace SeleniumTests.PageObjects
{
    public class LoginPage : BasePage
    {
        protected By NavButton = By.Id("nava");
        protected By NavBatButtons = By.Id("navbarExample");
        protected By CategoriesList = By.CssSelector("list-group");
        protected By LoginButton = By.Id("login2");
        protected By FormLogin = By.ClassName("modal-content");
        protected By InputUserName = By.Id("loginusername");
        protected By InputPassword = By.Id("loginpassword");
        protected By ButtonSubmit = By.CssSelector("#logInModal > div > div > div.modal-footer > button.btn.btn-primary");

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;

        }

        public bool CheckElements() 
        {
            return WaitHandler.ElementIsClickeable(Driver, LoginButton);
        }

        public void SelectLogin() 
        {  
            Driver.FindElement(LoginButton).Click();
            WaitHandler.ElementIsDisplayed(Driver, FormLogin);
        }

        public void FillFields(string User, string Password) 
        {            
            Driver.FindElement(InputUserName).SendKeys(User);
            Driver.FindElement(InputPassword).SendKeys(Password);
            WaitHandler.ElementIsClickeable(Driver, ButtonSubmit);
            Driver.FindElement(ButtonSubmit).Click(); 
        }
    }
}