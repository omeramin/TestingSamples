using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc.Testing;
using WebApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace WebApplicationTestProject_MS
{
    [TestClass]
    public class WebApplicationIntegrationTestProject_MS
    {

        private readonly WebApplicationFactory<WebApplication.Startup> _factory;

        public WebApplicationIntegrationTestProject_MS()
        {
            _factory = new WebApplicationFactory<WebApplication.Startup>();
        }


        [TestMethod]
        [DataRow("/")]
        [DataRow("/Home/Index")]
        [DataRow("/Home/Privacy")]
        public async Task VerifySite_IntegrationTest(string url)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            Assert.AreEqual("text/html; charset=utf-8", response.Content.Headers.ContentType.ToString());
        }
    }
}

