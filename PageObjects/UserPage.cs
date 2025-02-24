using OpenQA.Selenium;

namespace SeleniumTests.PageObjects;

public class UserPage 
{
    protected IWebDriver Driver;

    protected By WelcomeUser = By.Id("nameofuser"); 
}