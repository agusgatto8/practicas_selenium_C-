using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests.Handler 
{
    public class WaitHandler
    {


        public static bool ElementIsDisplayed(IWebDriver driver, By locator) 
        {
            try 
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                wait.Until( d => d.FindElement(locator));
                return true;
            } 
            catch {}
            return false;
        }



        public static bool ElementIsClickeable(IWebDriver driver, By locator) 
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until( d => d.FindElement(locator).Displayed && d.FindElement(locator).Enabled);
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }

        }
    }
}