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

        public string Username { get; private set; }
        public string Password { get; private set; }


        public LoginPage(IWebDriver driver)
        {
            Driver = driver;

            if (!Driver.Title.Equals("STORE"))
                throw new Exception("This is not page");

            Username = GenerateUsername();
            Password = GeneratePassword();
        }

        private string GenerateUsername()
        {
            return "User" + new Random().Next(1000, 9999);
        }

        private string GeneratePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
            return new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
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

        public void FillFields() 
        {  
            Driver.FindElement(InputUserName).SendKeys(Username);
            Driver.FindElement(InputPassword).SendKeys(Password);
            WaitHandler.ElementIsClickeable(Driver, ButtonSubmit);
            Driver.FindElement(ButtonSubmit).Click(); 
        }
    }
}