using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace TestHarness.Tests
{
    public class TestBase
    {
        public IWebDriver Driver { get; set; }
        public static Uri GridUrl { get; set; } = new Uri("http://localhost:4444/wd/hub");

        [OneTimeSetUp]
        public void InitialSetup()
        {
            Driver = new RemoteWebDriver(GridUrl, new ChromeOptions().ToCapabilities());
        }

        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Driver?.Quit();
        }

    }
}
