using FluentAssertions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Lab6.Specs.Steps
{
    [Binding]
    public class CartStepDefinitions
    {
        private readonly IWebDriver _webDriver;
        public CartStepDefinitions(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [When("I added (.*) products to cart")]
        public void IAddedProductsToCart(int number)
        {
            var addToCartButtons = _webDriver.FindElements(By.CssSelector("input[value='Add to cart'"));
            for (int i = 0; i < addToCartButtons.Count; i++)
            {
                if (i == number)
                {
                    break;
                }
                var button = addToCartButtons[i];
                button.Click();
            }
        }
        [Then("I should have (.*) products in cart")]
        public void IShouldHaveProducsInCart(int number)
        {
            var elemetnts = _webDriver.FindElements(By.CssSelector("#PPMiniCart .minicart-item"));
            elemetnts.Should().HaveCount(number);
        }

        [When("I removed an item from cart")]
        public void IRemovedAnItemFromCart()
        {
            var remove = _webDriver.FindElement(By.CssSelector("#PPMiniCart .minicart-remove"));
            remove.Click();
        }
    }
}
