using OpenQA.Selenium;
using SeleniumWebDriverBasics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverBasics.WebObjects.Pages
{
    public class LoginPage : BasePage
    {
        private static readonly By loginFieldXpath = By.Id("passp-field-login");

        public LoginPage() : base(loginFieldXpath, "Login Field") { }

        private readonly BaseElement loginField = new BaseElement(loginFieldXpath);
        private readonly BaseElement loginButton = new BaseElement(By.Id("passp:sign-in"));
        private readonly BaseElement passwordField = new BaseElement(By.Id("passp-field-passwd"));
        private readonly BaseElement ActualLoginMessage = new BaseElement(By.XPath("//div[@class='passp-auth-screen passp-welcome-page']/h1/span"));

        public void EnterLogin(string Login)
        {
            loginField.SendKeys(Login);
        }

        public void ClickConfirmationButton()
        {
            loginButton.JSClick();
        }

        public void EnterPassword(string Password)
        {
            passwordField.SendKeys(Password);
        }

        public void Login(User user)
        {
            EnterLogin(user.DataUser[0]);
            loginButton.HighlightElement();
            ClickConfirmationButton();
            EnterPassword(user.DataUser[1]);
            ClickConfirmationButton();
        }

        public string GetActualLoginMessage() => ActualLoginMessage.GetText();
    }
}