using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationTestProject_MS
{
    [TestClass]
    public class WebApplicationTestsMS
    {
        [TestMethod]
        public void VerifyIndexPageName()
        {
            HomeController hc = new HomeController();
            var result = hc.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);

        }
    }
}
