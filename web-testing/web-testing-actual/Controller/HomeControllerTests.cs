
using Microsoft.AspNetCore.Mvc;
using System;
using web_testing.Controllers;
using web_testing.Models;
using Xunit;

namespace web_testing_actual
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexActionReturnsView()
        {
            // Arrange
            var sut = new HomeController();

            // Act
            var result = sut.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }


        [Fact]
        public void IndexViewResultReturnsMessage()
        {
            // Arrange
            var expected = new IndexViewModel
            {
                Message = "Hello, welcome to my site!"
            };

            var sut = new HomeController();
            // Act 
            var viewResult = (ViewResult)sut.Index();

            // Assert
            Assert.Equal(expected.Message, ((IndexViewModel)viewResult.Model).Message);
            // Assert.Equal(expected, viewResult.Model);
        }
    }
}
