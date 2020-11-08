using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    public class GgoogleTests
    {
        private IWebDriver _driver;
        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver("C:\\");
        }

        [Test]
        public void GoogleTestHeaderPresent()
        {
            _driver.Url = "http://www.google.com";
            var searchInput = _driver.FindElement(By.Name("q"));
            searchInput.SendKeys("Computer");
            searchInput.SendKeys(Keys.Enter);
            var logo = _driver.FindElement(By.Id("logo"));
            Assert.NotNull(logo);
        }
        [TearDown]
        public void CloseBrowser()
        {
            _driver.Close();
        }
    }
}