using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Utilities
{
    public static class DriverManager
    {
        public static IWebDriver GetWebDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            return new ChromeDriver(options);
        }
    }
}