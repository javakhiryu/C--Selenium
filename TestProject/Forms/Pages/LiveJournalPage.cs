using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestProject.Forms.Pages
{
    public class LiveJournalPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        private readonly By _loginButton = By.CssSelector("a.s-header-item__link--login");
        private readonly By _newPostButton = By.XPath("//span[contains(@class, 'PostPrompt')]");

        public LiveJournalPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10)); // Adjust the timeout as needed
        }

        public void OpenLoginForm()
        {
            var loginButton = _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(_loginButton));
            loginButton.Click();
        }

        public void OpenNewPostForm()
        {
            var newPostButton = _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(_newPostButton));
            newPostButton.Click();
        }
    }
}
