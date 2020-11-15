using FluentAssertions;
using Lab6.Specs.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Lab6.Specs.Steps
{
    [Binding]
    public class SignInStepDefinitions
    {
        private readonly IWebDriver _webDriver;
        private IWebElement _signInModal;
        public SignInStepDefinitions(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [Given("I click on sign-in button")]
        public void GivenUserClickOnSignUpButton()
        {
            var _signUpButton = _webDriver.FindElement(By.CssSelector("a[data-target='#myModal'"));
            _signUpButton.Should().NotBeNull();
            _signUpButton.Click();
            _signInModal = _webDriver.WaitForElementToAppear(10, By.Id("myModal"));
        }

        [Given("I have entered (.*) in name field from sign-in pop-up")]
        public void WhenUserInsertedName(string data)
        {
            var name = _signInModal.FindElement(By.CssSelector("input[name='Name'"));
            var element = _webDriver.WaitForElementToBeClickable(5, name);
            element.SendKeys(data);
        }

        [Given("I have entered (.*) in password field from sign-in pop-up")]
        public void GibenUserInsertedPassword(string data)
        {
            var password = _signInModal.FindElement(By.CssSelector("input[name='password'"));
            var element = _webDriver.WaitForElementToBeClickable(5, password);
            element.SendKeys(data);
        }

        [When("I press the sign-in button")]
        public void IPressTheSignInButton()
        {
            var buttonSingUp = _signInModal.FindElement(By.CssSelector("input[value='Sign In'"));
            buttonSingUp.Click();
        }
    }
}
