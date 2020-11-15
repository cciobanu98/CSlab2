using FluentAssertions;
using Lab6.Specs.Extensions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Lab6.Specs.Steps
{
    [Binding]
    public class SignUpStepDefinitions
    {

        private IWebElement _signUpButton;
        private IWebElement _signUpModal;
        private readonly IWebDriver _webDriver;
        public SignUpStepDefinitions(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [Given("I click on sign-up button")]
        public void GivenUserClickOnSignUpButton()
        {
            var _signUpButton = _webDriver.FindElement(By.CssSelector("a[data-target='#myModal2'"));
            _signUpButton.Should().NotBeNull();
            _signUpButton.Click();
            _signUpModal = _webDriver.WaitForElementToAppear(10, By.Id("myModal2"));
        }

        [Given("I have entered (.*) in name field")]
        public void WhenUserInsertedName(string data)
        {
            var name = _signUpModal.FindElement(By.CssSelector("input[name='Name'"));
            var element = _webDriver.WaitForElementToBeClickable(5, name);
            element.SendKeys(data);
        }

        [Given("I have entered (.*) in email field")]
        public void WhenUserInserteEmail(string data)
        {
            var email = _signUpModal.FindElement(By.CssSelector("input[name='Email'"));
            var element = _webDriver.WaitForElementToBeClickable(5, email);
            element.SendKeys(data);
        }

        [Given("I have entered (.*) in password field")]
        public void WhenUserInsertePassword(string data)
        {
            var password = _signUpModal.FindElement(By.CssSelector("input[name='password'"));
            var element = _webDriver.WaitForElementToBeClickable(5, password);
            element.SendKeys(data);
        }

        [Given("I have entered (.*) in confirm password field")]
        public void WhenUserInserteConfirmPassword(string data)
        {
            var password = _signUpModal.FindElement(By.CssSelector("input[name='Confirm Password'"));
            var element = _webDriver.WaitForElementToBeClickable(5, password);
            element.SendKeys(data);
        }

        [When("I press the sign-up button")]
        public void IPressTheSignInButton()
        {
            var buttonSingUp = _signUpModal.FindElement(By.CssSelector("input[value='Sign Up'"));
            buttonSingUp.Click();
        }

        [Then("I should see error pop-up: 'Different passwords'")]
        public void IShouldSeeErrorPopUpDiffernetPasswords()
        {
            var popup = _webDriver.FindElement(By.CssSelector("input:invalid"));
            popup.Should().NotBeNull();
        }
    }
}
