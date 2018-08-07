using System;
using System.Collections.Generic;
using System.Text;
using Espresso.Controllers;
using Espresso.Models;
using Espresso.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using Xunit.Sdk;

namespace Espresso.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexTest()
        {
            // Arrange
            var controller = new HomeController(new StuffRepository());

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.NotNull(result);
        }

    }
}
