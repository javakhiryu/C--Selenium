using OpenQA.Selenium;
using TestProject.Forms;
using TestProject.Forms.Pages;

namespace TestProject.Test.Steps
{
    public class BlogSteps
    {
        private IWebDriver _driver;
        private LiveJournalPage _liveJournalPage;
        private LoginForm _loginForm;
        private NewPostForm _newPostForm;
        private const string BaseUrl = Constants.Constants.BaseUrl; 

        public BlogSteps(IWebDriver driver)
        {
            _driver = driver;
            _liveJournalPage = new LiveJournalPage(driver);
            _loginForm = new LoginForm(driver);
            _newPostForm = new NewPostForm(driver);
        }

        public void LoginToBlog(string username, string password)
        {
            _driver.Navigate().GoToUrl(BaseUrl);
            _liveJournalPage.OpenLoginForm();
            _loginForm.Login(username, password);
        }

        public void CreateNewPost(string title, string body)
        {
            _liveJournalPage.OpenNewPostForm();
            _newPostForm.CreatePost(title, body);
        }
    }
}
