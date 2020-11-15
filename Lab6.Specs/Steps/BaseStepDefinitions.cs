using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Lab6.Specs.Steps
{
    [Binding]
    public class BaseStepDefinitions 
    {
        private readonly IWebDriver _webDriver;

        public BaseStepDefinitions(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [Given("I have navigated to website")]
        public void UserAccessTheSite()
        {
            _webDriver.Url = Constants.Url.Base;
        }

        [Given("I have navigated to women cloths")]
        public void IHaveNavigatedToWomenCloths()
        {
            _webDriver.Navigate().GoToUrl(Constants.Url.WomenCloths);
        }

        [Then("I should be loged in app")]
        public void ThenIShouldBeLogedInApp()
        {
            var url = _webDriver.Url;
            url.Should().Be("https://loving-hermann-e2094b.netlify.app/");
            var elemts = _webDriver.FindElements(By.CssSelector("a[data-target='#myModal2'"));
            elemts.Should().BeEmpty();
        }
    }
}
