using NUnit.Framework;
using OpenQA.Selenium;
using TestProject.Test.Constants;
using TestProject.Test.Steps;
using Utilities;

namespace Tests
{
    [TestFixture]
    public class LoginAndPostTest
    {
        private IWebDriver _driver;
        private BlogSteps _blogSteps;

        [SetUp]
        public void SetUp()
        {
            _driver = DriverManager.GetWebDriver();
            _blogSteps = new BlogSteps(_driver);
        }

        [Test]
        public void TestLoginAndCreatePost()
        {
            _blogSteps.LoginToBlog(Constants.Username, Constants.Password);
            _blogSteps.CreateNewPost("Javokhir Yulchiboev", "This is a test post body.");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}

