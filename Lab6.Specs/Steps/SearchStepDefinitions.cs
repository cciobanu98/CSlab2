using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Lab6.Specs.Steps
{
    [Binding]
    public class SearchStepDefinitions 
    {
        private readonly IWebDriver _webDriver;

        public SearchStepDefinitions(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [Given("I have entered (.*) as a search keyword")]
        public void GivenUserInsertDataInSearch(string data)
        {
            var searchElement = _webDriver.FindElement(By.Name("search"));
            searchElement.SendKeys(data);
        }
        [When("I press the search button")]
        public void UserClickOnSearchButton()
        {
            var searchElement = _webDriver.FindElement(By.Name("search"));
            searchElement.SendKeys(Keys.Enter);
        }
        [Then("I should navigate to search result page")]
        public void ProductPageIsDisplayed()
        {
            var url = _webDriver.Url;
            url.Should().Be("https://loving-hermann-e2094b.netlify.app/single.html");
        }

        [Then("Error popup should apear")]
        public void ErrorPopUpShouldApead()
        {
            var popup = _webDriver.FindElement(By.CssSelector("input:invalid"));
            popup.Should().NotBeNull();
        }
    }
}
