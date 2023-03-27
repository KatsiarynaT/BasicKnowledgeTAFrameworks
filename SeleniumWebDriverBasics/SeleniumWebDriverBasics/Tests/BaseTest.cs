using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using SeleniumWebDriverBasics.Entities;
using SeleniumWebDriverBasics.WebDriver;
using SeleniumWebDriverBasics.WebObjects.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverBasics.Tests
{
    public abstract class BaseTest
    {
        private readonly HomePage homePage = new HomePage();
        private readonly LoginPage loginPage = new LoginPage();
        private readonly EmailPage emailPage = new EmailPage();

        [SetUp]
        public void TestSetup()
        {
            Browser.GetInstance();
            Browser.NavigateTo();
            Browser.MaximizeWindow();

            var login = Convert.ToString(Configuration.Login);
            var password = Convert.ToString(Configuration.Password);
            var user = new User(login, password);

            homePage.ClickOnLoginButton();
            loginPage.Login(user);
            homePage.WaitForComposeLinkIsVisible();
        }

        [TearDown]
        public void CleanUp()
        {
            Browser.Driver.Close();
            Browser.Driver.Quit();
            Browser.Quit();
        }
    }
}