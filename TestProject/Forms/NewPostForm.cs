using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace TestProject.Forms
{
    public class NewPostForm
    {
        private IWebDriver _driver;

        // Locator for iframe
        private readonly By _iframeSelector = By.XPath("//iframe[contains(@class, 'Iframe')]");

        // Locators for elements inside the iframe
        private readonly By _postTitleField = By.XPath("//textarea[@class='text-0-2-60 js--post-title']");
        private readonly By _postBodyField = By.XPath("//div[@role='textbox']");

        public NewPostForm(IWebDriver driver)
        {
            _driver = driver;
        }

        public void CreatePost(string title, string body)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            
            // Switch to the iframe
            var iframe = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(_iframeSelector));
            _driver.SwitchTo().Frame(iframe);

            // Wait for the post title field to be visible and clickable
            var postTitleField = wait.Until(ExpectedConditions.ElementToBeClickable(_postTitleField));
            postTitleField.SendKeys(title);

            // Wait for the post body field to be visible and clickable
            var postBodyField = wait.Until(ExpectedConditions.ElementToBeClickable(_postBodyField));
            postBodyField.SendKeys(body);

            // Optionally, switch back to the main content (if needed)
            _driver.SwitchTo().DefaultContent();
        }
    }
}
