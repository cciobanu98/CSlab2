using FluentAssertions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Lab7.Steps
{
    [Binding]
    public class Variant1StepDefinitions
    {
        private readonly IWebDriver _webDriver;
        public Variant1StepDefinitions(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [Given("User navigated to (.*)")]
        public void UserAccessTheSite(string url)
        {
            _webDriver.Url = url;
        }

        [Then("The google page is shown")]
        public void TheGooglePageIsShown()
        {
            _webDriver.Url.Should().Be("https://www.google.com/");
        }

        [When("User leave the search input empty")]
        public void LeaveTheSearchInputEmpty()
        {

        }

        [When("User press the search button")]
        public void PressTheSearchButton()
        {
            var input = _webDriver.FindElement(By.CssSelector("input[class='gLFyf gsfi']"));
            input.SendKeys(Keys.Enter);
        }

        [Then("Count results on page")]
        public void CountResultsOnPage()
        {
            var elements = _webDriver.FindElements(By.ClassName("g"));
            elements.Count.Should().BeGreaterThan(0);
        }

        [When("User fill the search input with (.*)")]
        public void FillTheSearchInputWirh(string value)
        {
            var input = _webDriver.FindElement(By.CssSelector("input[class='gLFyf gsfi']"));
            input.SendKeys(value);
        }

        [Then("Do you mean link is present")]
        public void DoYouMeanLinkIsPresent()
        {
            var span = _webDriver.FindElement(By.CssSelector("span[class='gL9Hy']"));
            span.Should().NotBeNull();
        }
    }
}
