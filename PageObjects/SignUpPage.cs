using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using Selenium.Test.PageObjects;
using SeleniumTests.Handler;


namespace SeleniumTests.PageObjects
{
    public class SignUpPage : BasePage
    {

       // Selectores y variables que se vayan a utilizar

       protected By SignUpButton = By.Id("signin2");
       protected By SignUpForm = By.ClassName("modal-content");
       protected By UserInput = By.Id("sign-username");
       protected By PasswordInput = By.Id("sign-password");
       protected By SignUpSubmit = By.XPath("//button[text()='Sign up']");

       public string Username { get; private set; }
       public string Password { get; private set; }


     //CONSTRUCTOR DE SELENIUM
        public SignUpPage(IWebDriver driver) 
       {
          Driver = driver;
          Username = GenerateUsername();
          Password = GeneratePassword();

          if (!Driver.Title.Equals("STORE"))
                throw new Exception("This is not page");
       } 

       // Generador de usuario y contrasena ranmdom

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

        //Metodos 

         public bool CheckElements() 
        {
            return WaitHandler.ElementIsClickeable(Driver, SignUpButton);
        }

        public void SignUpStart(string Username, string Password) 
        {  
            Driver.FindElement(SignUpButton).Click();
            WaitHandler.ElementIsDisplayed(Driver, SignUpForm);
            WaitHandler.ElementIsClickeable(Driver, SignUpSubmit);
            Driver.FindElement(UserInput).SendKeys(Username);
            Driver.FindElement(PasswordInput).SendKeys(Password);
            Thread.Sleep(2000);
            WaitHandler.ElementIsClickeable(Driver, SignUpSubmit);
            Driver.FindElement(SignUpSubmit).Click(); 
            WaitHandler.AcceptAlert(Driver);
        }
    }
}