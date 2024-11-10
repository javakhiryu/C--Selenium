using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestProject.Forms
{
    public class LoginForm
    {
        private IWebDriver _driver;

        private readonly By _usernameField = By.Id("user");
        private readonly By _passwordField = By.Id("lj_loginwidget_password");
        private readonly By _submitLoginButton = By.Name("action:login");

        public LoginForm(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Login(string username, string password)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            // Wait for the username field to be visible and interactable
            var usernameElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(_usernameField));
            usernameElement.SendKeys(username);

            // Wait for the password field to be visible and interactable
            var passwordElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(_passwordField));
            passwordElement.SendKeys(password);

            // Wait for the login button to be clickable
            var loginButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(_submitLoginButton));
            loginButton.Click();
        }
    }
}
