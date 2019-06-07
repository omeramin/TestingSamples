using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc.Testing;
using WebApplication;
using System.Net;



namespace WebApplicationTestProject_MS
{
    [TestClass]
    public class WebApplicationUITestMS
    {
        static IWebDriver driver;
        private readonly WebApplicationFactory<WebApplication.Startup> _factory;



        public WebApplicationUITestMS()
        {
            _factory = new WebApplicationFactory<WebApplication.Startup>();
        }

        [TestInitialize]
        public void SetUp()
        {
            //driver = new FirefoxDriver();
            //driver = new ChromeDriver();
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        }
        [TestMethod]
        public void NavigatetoHome()
        {
            driver.Navigate().GoToUrl("http://localhost:56242");
            var element = driver.FindElement(By.Id("myCarousel"));

            Assert.IsNotNull(element);

        }


        [AssemblyCleanup]
        public static void TearDown()
        {
            driver.Quit();
        }

    }
}
