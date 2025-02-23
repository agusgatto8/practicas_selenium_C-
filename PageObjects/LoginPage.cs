using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;
using SeleniumTests.Handler;

namespace SeleniumTests.PageObjects
{
    public class LoginPage 
    {
        protected IWebDriver Driver;

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

            if (!Driver.Title.Equals("STORE"))
                throw new Exception("This is not page");
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

        public void FillFields(string user, string password) 
        {  
            Driver.FindElement(InputUserName).SendKeys(user);
            Driver.FindElement(InputPassword).SendKeys(password);
            WaitHandler.ElementIsClickeable(Driver, ButtonSubmit);
            Driver.FindElement(ButtonSubmit).Click(); 
        }
            // Driver.FindElement(InputUserName).SendKeys(user);
            // Driver.FindElement(InputPassword).SendKeys(password);
            // Driver.FindElement(ButtonSubmit).Click();

        
    }
}