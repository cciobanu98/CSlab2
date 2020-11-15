using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Lab6.Specs.Steps
{
    [Binding]
    public abstract class BaseSteps : IDisposable
    {
        protected IWebDriver _webDriver;

        public BaseSteps()
        {
            _webDriver = new ChromeDriver(Constants.DriverPath);
        }
        public void Dispose()
        {
            if (_webDriver != null)
            {
                _webDriver.Dispose();
                _webDriver = null;
            }
        }
    }
}
