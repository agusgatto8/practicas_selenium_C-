using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTests.PageObjects;

namespace SeleniumTests.TestCases{

    
    [TestFixture]
    public class LoginTests : BaseTest
    {        
        private string Username;
        private string Password;

        [Test, Order(1)]
        public void CreatedUser() 
        {
            SignUpPage signUpPage = new SignUpPage(Driver);
            Username = signUpPage.GenerateUsername();
            Password = signUpPage.GeneratePassword();
            signUpPage.CheckElements();
            signUpPage.SignUpStart(Username, Password);
        }

        [Test, Order(2)]
        public void LoginSuccessfull() 
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.CheckElements();
            loginPage.SelectLogin();
            Thread.Sleep(3000);
            loginPage.FillFields(Username, Password);
            Thread.Sleep(3000);
        }
    }
}