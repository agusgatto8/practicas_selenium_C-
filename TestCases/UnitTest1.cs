using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTests.PageObjects;

namespace SeleniumTests.TestCases{

    //INDICAMOS QUE TENEMOS UNA CLASE CON TEST A EJECUTAR
    [TestFixture]

    // SE DEFINE LA CLASE CON LAS PRUEBAS LA CUAL HEREDA LA CLASE BASETEST QUE CONTIENE LA CONFIGURACION DEL NAVEGADOR
    public class LoginTests : BaseTest
    {        
        private string Username;
        private string Password;

    // CON LA SIGUEINTE ANOTACION PODEMOS ORDENARLE AL NAVEGADOR QUE EJECUTE LAS PRUEBAS EN ORDEN SIN CERRAR EL MISMO.
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