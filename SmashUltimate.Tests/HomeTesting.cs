using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmashUltimate.Controllers;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using SmashUltimate.Models;

namespace SmashUltimate.Tests
{
    [TestClass]
    public class HomeTesting : ApiController
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            HomeController homeController = new HomeController();
            //Act
            IHttpActionResult httpResult = homeController.DefaultCall();
            //Assert
            Assert.IsInstanceOfType(httpResult, typeof(OkNegotiatedContentResult<GameModel>));
        }
    }
}
