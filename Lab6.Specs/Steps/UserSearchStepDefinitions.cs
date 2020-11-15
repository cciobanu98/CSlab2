using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Lab6.Specs.Steps
{
    public class UserSearchStepDefinitions : BaseSteps
    {
        [Given("I have navigated to website")]
        public void UserAccessTheSite()
        {
            _webDriver.Url = Constants.BaseUrl;
        }
        [Given("I have entered (.*) as search keyword")]
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
            Thread.Sleep(5000);
            var popup = _webDriver.SwitchTo().;
            popup.Should().NotBeNull();
        }
    }
}
